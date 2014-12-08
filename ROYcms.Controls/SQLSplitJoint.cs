using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI;
using System.ComponentModel;
using System.Web.UI.WebControls;
using System.Data;

namespace ROYcms.Controls
{
    /// <summary>
    /// SQL拼接
    /// </summary>
    public class SQLSplitJoint
    {
        public ROYcms.Sys.BLL.ROYcms_class ROYcms_classBll = new ROYcms.Sys.BLL.ROYcms_class();
        public ROYcms.Sys.BLL.ROYcms_news ROYcms_newsBLL = new ROYcms.Sys.BLL.ROYcms_news();
        public ROYcms.Sys.BLL.ROYcms_Url ROYcms_UrlBLL = new ROYcms.Sys.BLL.ROYcms_Url();
        /// <summary>
        /// WebRepeater拼接
        /// </summary>
        /// <param name="MyStr"></param>
        /// <returns></returns>
        public string Wheres(string MyStr,string WhereField)
        {
            string Strs = null; 
            string[] Strz = null;
            if (MyStr.Contains("|")) { Strz = MyStr.Split('|'); }

            for (int i = 0; i < Strz.Length; i++)
            {
                Strs += " (" + WhereField + "='" + Strz[i] + "') OR";
            }
            return "(" + Strs.Substring(0, Strs.Length - 2) + ")";
        }
        /// <summary>
        /// WebRepeater拼接 
        /// </summary>
        /// <param name="MYclass"></param>
        /// <returns></returns>
        public string ClassWheres(string MYclass)
        {
            string Strs = null;

            DataSet DS = ROYcms_classBll.GetSubClassList(ROYcms_classBll.GetClassId(Convert.ToInt32(MYclass)));

            DataTable dt = DS.Tables[0];
            //遍历行
            if (dt.Rows.Count < 1)
            {
                Strs = MYclass + ",";
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Strs += dr["Id"].ToString() + ",";
                }

            }
            Strs = Strs.Substring(0, Strs.Length - 1);
            return Strs;
        }
        /// <summary>
        /// 获取地址
        /// </summary>
        /// <param name="Id">新闻ID</param>
        /// <param name="Class">分类ID</param>
        /// <param name="Div">层级</param>
        /// <returns></returns>
        public string GetLink(int Id,int Class,int Div)
        {
            string Url = null;
            try
            {
                if (Class == 0) //返回文章URL地址
                {
                    int ClassId = Convert.ToInt32(ROYcms_newsBLL.GetField(Id, "classname"));
                    string ShowRules = ROYcms_classBll.GetClassField(ClassId, "ShowRules");

                    string jumpurl = ROYcms_newsBLL.GetField(Id, "jumpurl").Trim();
                    ShowRules = ShowRules.Replace("{id}", Id.ToString()).Replace("{yyyy}/{MM}/{dd}/", "show_");
                    if (jumpurl.Length > 2) //如果启用跳转则输出跳转的URL
                    {
                        Url = jumpurl;
                    }
                    else
                    {
                        //if (ROYcms_UrlBLL.Exists_bh(Convert.ToInt32(Id))) { Url = ___ROYcms_Url.GetUrl(Convert.ToInt32(this.Rid)); }
                        //else
                        //{
                        Url = (ROYcms_classBll.GetClassField(ClassId, "FilePath").Replace("{cmspath}/", "/")) + ShowRules;
                        //}
                    }

                }
                else //返回列表的链接地址 默认是封面 1是频道
                {
                    if (Div == 1)
                    {
                        string ListRules = ROYcms_classBll.GetClassField(Class, "ListeRules");
                        Url = (ROYcms_classBll.GetClassField(Class, "FilePath").Replace("{cmspath}/", "/")) + ListRules.Replace("{class}", Class.ToString());
                    }
                    else
                    {

                        string DefaultFile = ROYcms_classBll.GetClassField(Class, "DefaultFile");
                        if (DefaultFile == "index.aspx") { DefaultFile = ""; }
                        Url = (ROYcms_classBll.GetClassField(Class, "FilePath").Replace("{cmspath}/", "/")) + DefaultFile;
                    }

                }
               return Url;
            }
            catch { return "<!--输出错误！-->"; }
        }
    }
}
