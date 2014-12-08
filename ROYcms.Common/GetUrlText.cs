using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;

namespace ROYcms.Common
{
    /// <summary>
    /// 获取URL地址的网页内容
    /// </summary>
    public class GetUrlText
    {
        /// <summary>
        /// 请求URL 返回的数据
        /// </summary>
        /// <param name="url">地址 The URL.</param>
        /// <param name="Encoding">编码 The encoding.</param>
        /// <returns></returns>
        public static string GetText(string url, string Encoding)
        {

            int HttpStatus;
            WebResponse wr_result = null;
            StringBuilder txthtml = new StringBuilder();
            try
            {
                WebRequest wr_req = WebRequest.Create(url);
                wr_result = wr_req.GetResponse();
                HttpStatus = (int)(((HttpWebResponse)wr_result).StatusCode);
                if (HttpStatus == 200)
                {
                    Stream ReceiveStream = wr_result.GetResponseStream();
                    Encoding encode = System.Text.Encoding.GetEncoding(Encoding);
                    StreamReader sr = new StreamReader(ReceiveStream, encode);
                    if (true)
                    {
                        Char[] read = new Char[256];
                        int count = sr.Read(read, 0, 256);
                        while (count > 0)
                        {
                            String str = new String(read, 0, count);
                            txthtml.Append(str);
                            count = sr.Read(read, 0, 256);
                        }
                    }
                }
                else {
                    ROYcms.Common.SystemCms.InsertErrLog("读取模板错误！状态码是：" + HttpStatus.ToString(), url);
                    //记录到系统日志
                    return null;
                }
            }
            catch (Exception)
            {
               return null;
            }
            finally
            {
                if (wr_result != null)
                {
                    wr_result.Close();
                }
            }
            return txthtml.ToString();
        }


        /// <summary>
        /// 获取url 内容 并格式化标记 从开始到结束
        /// </summary>
        /// <param name="url"></param>
        /// <param name="starS"></param>
        /// <param name="endS"></param>
        /// <param name="Enco"></param>
        /// <returns></returns>
        public static string GetContent(string url, string starS, string endS, string Enco)
        {
            string Contents = ROYcms.Common.GetUrlText.GetText(url, Enco);
            Contents = ForMat(Contents);//格式化
            int star = Contents.IndexOf(ForMat(starS)) + ForMat(starS).Length;
            int end = Contents.IndexOf(ForMat(endS));
            return Contents.Substring(star, end - star);
        }
        /// <summary>
        /// 把字符转化为文本格式
        /// </summary>
        /// <param name="Input"></param>
        /// <returns></returns>
        public static string ForMat(string Input)
        {
            StringBuilder sb = new StringBuilder(Input);

            sb.Replace("\"", "[yh]");
            sb.Replace(" ", "[kg]");
            sb.Replace("'", "[dyh]");
            sb.Replace(".", "[dian]");
            sb.Replace("\\", "[fxg]");
            sb.Replace("/", "[xg]");
            sb.Replace("?", "[wh]");
            return sb.ToString();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Input"></param>
        /// <returns></returns>
        public static string NoForMat(string Input)
        {
            StringBuilder sb = new StringBuilder(Input);

            sb.Replace("[yh]", "\"");
            sb.Replace("[kg]", " ");
            sb.Replace("[dyh]", "'");
            sb.Replace("[dian]", ".");
            sb.Replace("[fxg]", "\\");
            sb.Replace("[xg]", "/");
            sb.Replace("[wh]", "?");
            return sb.ToString();
        }
    }
}
