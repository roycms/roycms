using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.Administrator.NewHtml
{
    /// <summary>
    /// AJAXNewHtml
    /// </summary>
    public partial class AJAXNewHtml : ROYcms.AdminPage
    {
        /// <summary>
        /// 
        /// </summary>
        public static bool IsStatic = ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("html") == "true" ? true : false; //是否是静态生成
        /// <summary>
        /// Page_Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            string PER = null;
            if (IsStatic)
            {
                int StaticHtmlType0 = ROYcms.Common.Request.GetFormInt("StaticHtmlType0"); //0首页，1封面频道，2列表频道，3频道内文章
                int StaticHtmlType1 = ROYcms.Common.Request.GetFormInt("StaticHtmlType1"); //0首页，1封面频道，2列表频道，3频道内文章
                int StaticHtmlType2 = ROYcms.Common.Request.GetFormInt("StaticHtmlType2"); //0首页，1封面频道，2列表频道，3频道内文章
                int StaticHtmlType3 = ROYcms.Common.Request.GetFormInt("StaticHtmlType3"); //0首页，1封面频道，2列表频道，3频道内文章
                int ClassKind = ROYcms.Common.Request.GetFormInt("DdClassKind");
                int Class = ROYcms.Common.Request.GetFormInt("DdClass");
                //int KClass = ROYcms.Common.Request.GetFormInt("Class");
                int ListCon = ROYcms.Common.Request.GetFormInt("ListCon");
                int ArticleCon = ROYcms.Common.Request.GetFormInt("ArticleCon");
                int ArticleStar = ROYcms.Common.Request.GetFormInt("ArticleStar");
                int ArticleEnd = ROYcms.Common.Request.GetFormInt("ArticleEnd");

                int ONE = ROYcms.Common.Request.GetQueryInt("ONE"); //一键快捷生成事件

                if (ONE == 1) //一键生成首页 	
                {
                    PER = ROYcms.Templet.StaticHtmlHelp.StaticIndex();
                }
                else if (ONE == 2) //一键生成站点所有文件
                {
                    PER = ROYcms.Templet.StaticHtmlHelp.StaticAll();
                }
                else if (ONE == 3) //一键生成所有频道 
                {
                    PER = ROYcms.Templet.StaticHtmlHelp.StaticAllChannel();
                }
                else if (ONE == 4) // 一键生成所有文章
                {
                    PER = ROYcms.Templet.StaticHtmlHelp.StaticAllArticle();
                }
                else  //非一键生成 和 栏目快捷生成
                {
                  
                        if (Class != 0)
                        {
                            if (StaticHtmlType0 == 0) { PER = ROYcms.Templet.StaticHtmlHelp.StaticIndex(); }//生成首页
                            if (StaticHtmlType1 == 1) { PER = ROYcms.Templet.StaticHtmlHelp.StaticChannel(Class, 0); }//生成封面 
                            if (StaticHtmlType2 == 2) {//生成列表
                                if (ListCon == 0) { ListCon = 10; }
                                PER = ROYcms.Templet.StaticHtmlHelp.StaticChannel(Class,1, ListCon); //生成10页
                            
                            }
                            if (StaticHtmlType3 == 3) { PER = ROYcms.Templet.StaticHtmlHelp.StaticChannelArticle(Class); }//生成文章 
                        }
                        else
                        {
                            PER = ROYcms.Templet.StaticHtmlHelp.StaticObjetChannel(ClassKind, 1);
                        }
                   
                }
            }
            else { PER = "0"; }
            Response.ContentType = "text/plain";
            Response.Write(PER);
        }
    }
}