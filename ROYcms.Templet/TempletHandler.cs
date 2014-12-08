using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Xml;
using System.Data;

namespace ROYcms.Templet
{
    public class TempletHandler : IHttpHandler
    {
        public bool IsReusable
        {
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write(ResponseHtml(context.Request.PhysicalPath));
        }

        /// <summary>
        /// 输出Html
        /// </summary>
        /// <param name="path">此次访问文件的地址</param>
        /// <returns></returns>
        private string ResponseHtml(string path)
        {
            //创建一个XmlReaderSettings对象，用于指定如何解析Xml文件
            XmlReaderSettings xrs = new XmlReaderSettings();
            xrs.CloseInput = true;
            xrs.IgnoreComments = true;
            xrs.IgnoreWhitespace = true;
            xrs.ProhibitDtd = false;
            XmlReader xr = XmlReader.Create(path, xrs);

            //为页面手动添加一条Html过渡要求信息
            string strHtml = "<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">";

            // 将返回的html代码添加到strHtml
            strHtml += GetHtml(xr).ToString();

            // 退出xr
            xr.Close();

            // 返回html
            return strHtml;
        }

        /// <summary>
        /// 获取Html
        /// </summary>
        /// <param name="xr">声明好的xr</param>
        /// <returns></returns>
        private StringBuilder GetHtml(XmlReader xr)
        {
            StringBuilder html = new StringBuilder();
            while (xr.Read())
            {
                //判断是否为开始标记，如果是则进行相关调用
                if (xr.IsStartElement())
                {
                    switch (xr.Name.ToLower())
                    {
                        case "view":
                            html.Append(GetView(xr.ReadSubtree()));
                            break;
                        case "repeat":
                            html.Append(GetRepeat(xr.ReadSubtree()));
                            break;
                        default:
                            //首先查看是否为单标签元素，如果是则在标签的最后加入 /
                            if (xr.IsEmptyElement)
                            {
                                //查看该节点是否存在属性，如果存在则循环输出//5+1+a+s+p+x
                                if (xr.HasAttributes)
                                {
                                    html.Append("<" + xr.Name);
                                    while (xr.MoveToNextAttribute())
                                        html.Append(" " + xr.Name + "=\"" + xr.Value + "\"");
                                    html.Append(" />");
                                }
                                else
                                {
                                    html.Append("<" + xr.Name + " />");
                                }
                            }
                            //如果不是单标签元素，则正常输出
                            else
                            {
                                if (xr.HasAttributes)
                                {
                                    html.Append("<" + xr.Name);
                                    while (xr.MoveToNextAttribute())
                                        html.Append(" " + xr.Name + "=\"" + xr.Value + "\"");
                                    html.Append(">");
                                }
                                else
                                {
                                    html.Append("<" + xr.Name + ">");
                                }
                            }
                            break;
                    }
                }
                //判断该节点是否有值，如果有则直接输出
                else if (xr.HasValue)
                {
                    html.Append(xr.Value);
                }
                //如果不是开始标记，则输出结束标记
                else
                {
                    if (xr.Name.ToLower() != "view" && xr.Name.ToLower() != "repeat")
                    {
                        html.Append("</" + xr.Name + ">");
                    }
                }
            }

            // 退出xr
            xr.Close();

            // 返回html
            return html;
        }

        /// <summary>
        /// 生成View控件
        /// </summary>
        /// <param name="xr"></param>
        /// <returns></returns>
        private string GetView(XmlReader xr)
        {
            // xr开始读取
            xr.Read();

            // 声明需要返回的StringBuilder
            StringBuilder html = new StringBuilder("");

            // 获取基础的sql查询字符串
            string strSql = xr.GetAttribute("sql");

            // 注：在此做了简单的参数替换，如果将此代码应用到实际项目中，请酌情修改。
            if (HttpContext.Current.Request.QueryString["id"] != null)
            {
                strSql = strSql.Replace("{id}", HttpContext.Current.Request.QueryString["id"].ToString());

                // 查询数据
                DataSet ds = null;//5=1=a=s=p=x

                // 验证数据并替换
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        // 如果数据源确实存在数据，则将内容添加到html，准备替换
                        html.Append(xr.ReadInnerXml());

                        // 循环替换数据标签
                        foreach (DataColumn dc in ds.Tables[0].Columns)
                        {
                            html.Replace("{" + dc.ColumnName + "}", ds.Tables[0].Rows[0][dc.ColumnName].ToString());
                        }
                    }
                }
                else
                {
                    html.Append("暂无数据！");
                }
            }
            else
            {
                html.Append("没有可以使用的id参数！");
            }

            // 退出xr
            xr.Close();

            // 返回html.ToString()
            return html.ToString();
        }

        /// <summary>
        /// 生成Repeat控件
        /// </summary>
        /// <param name="xr"></param>
        /// <returns></returns>
        private string GetRepeat(XmlReader xr)
        {
            // xr开始读取
            xr.Read();

            // 声明需要返回的StringBuilder
            StringBuilder html = new StringBuilder("");

            // 获取基础的sql查询字符串
            string strSql = xr.GetAttribute("sql");

            // 查询数据
            DataSet ds =  null;

            // 验证数据并替换
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // 如果数据源确实存在数据，则声明一个字符串，用于保存xr.ReadInnerXml
                    // 注：xr.ReadInnerXml()将该节点下的所有节点以字符串返回
                    string strInner = xr.ReadInnerXml();

                    // 循环数据源，替换数据标签并将条目添加到html
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        // 准备一个用于不断替换的StringBuilder。。
                        // 注意：在此不是用的全局StringBuilder html
                        StringBuilder sbRow = new StringBuilder(strInner);

                        // 循环替换数据标签
                        foreach (DataColumn dc in ds.Tables[0].Columns)
                        {
                            sbRow.Replace("{" + dc.ColumnName + "}", dr[dc.ColumnName].ToString());
                        }

                        // 将替换过的本行代码sbRow添加到html
                        html.Append(sbRow.ToString());
                    }
                }
            }
            else
            {
                html.Append("暂无数据！");
            }

            // 退出xr
            xr.Close();

            // 返回html.ToString()
            return html.ToString();
        }
    }
}
