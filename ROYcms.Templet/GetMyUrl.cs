using System;
using System.Collections.Generic;
using System.Text;

namespace ROYcms.Templet
{
    public class GetMyUrl
    {
        public ROYcms.Sys.BLL.ROYcms_class ClassBll = new ROYcms.Sys.BLL.ROYcms_class();
        public ROYcms.Sys.BLL.ROYcms_news NewBll = new ROYcms.Sys.BLL.ROYcms_news();
        public static bool IsStatic = ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("html") == "true" ? true : false; //是否是静态生成
        /// <summary>
        ///返回首页地址
        /// </summary>
        /// <returns></returns>
        public string GetIndex()
        {
            string Url = null; //首页模板地址;
            if (IsStatic)
            {
                Url = this.GetStaticIndex();
            }
            else {
                Url = "/index.aspx";
            }
            return Url;
        }
        /// <summary>
        /// 返回首页静态地址
        /// </summary>
        /// <returns></returns>
        public string GetStaticIndex()
        {
            return "/index.html";
        }
        /// <summary>
        /// 返回频道URL
        /// </summary>
        /// <param name="Class"></param>
        /// <param name="Rules"></param>
        /// <returns></returns>
        public string GetChannel(int Class, int Rules)
        {
            try{
            string Url = null;
            if (IsStatic)
            {
                Url = this.GetStaticChannel(Class, Rules);
            }
            else {
                Url = "/Channel-" + Class.ToString()+".aspx";
            }
            return Url;
                     }
            catch {
                return null;
            }
        }
        /// <summary>
        /// 返回频道URL静态地址
        /// </summary>
        /// <param name="Class"></param>
        /// <param name="Rules">0封面地址，1列表地址</param>
        /// <returns></returns>
        public string GetStaticChannel(int Class, int Rules)
        {
            try{
            string Url = null;
            string FilePath = ClassBll.GetClassField(Class, "FilePath");//频道目录
            string DefaultFile = ClassBll.GetClassField(Class, "DefaultFile");//生成静态文件的默认文件
            string ListeRules = ClassBll.GetClassField(Class, "ListeRules");//列表规则
            FilePath = FilePath.ToLower().Replace("{cmspath}", "/");//替换参数
            ListeRules = ListeRules.ToLower().Replace("{cmspath}", "/");//替换参数
            ListeRules = ListeRules.ToLower().Replace("{channel}", FilePath.Replace("/", ""));//替换参数
            ListeRules = ListeRules.ToLower().Replace("{class}", Class.ToString());//替换参数
           
            if (Rules > 0)
            {
                Url = FilePath + ListeRules;
            }
            else
            {
                Url = FilePath + DefaultFile;
            }
            Url = Url.ToLower().Replace("///", "/").Replace("//", "/");//替换
            return Url;
                     }
            catch {
                return null;
            }
        }
        /// <summary>
        /// 返回文章URL
        /// </summary>
        /// <param name="Rid"></param>
        /// <returns></returns>
        public string GetArticle(int Rid)
        {
            try
            {
                string Url = null;
                if (IsStatic)
                {
                    Url = this.GetStaticArticle(Rid);
                }
                else
                {
                    Url = "/Article-" + Rid.ToString() + ".aspx";
                    string jumpurl = NewBll.GetField(Rid, "jumpurl") == null ? "" : NewBll.GetField(Rid, "jumpurl").Trim();//跳转地址
                    if (jumpurl.Length > 2)//跳转地址
                    {
                        Url = jumpurl;
                    }
                }
                return Url;
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// 返回文章URL静态地址
        /// </summary>
        /// <param name="Rid"></param>
        /// <returns></returns>
        public string GetStaticArticle(int Rid)
        {
            try
            {
                string Url = null;
                int ClassId = Convert.ToInt32(NewBll.GetClassName(Rid));//频道ID
                string ShowRules = ClassBll.GetClassField(ClassId, "ShowRules");//文章生成规则
                string jumpurl = NewBll.GetField(Rid, "jumpurl") == null ? "" : NewBll.GetField(Rid, "jumpurl").Trim();//跳转地址
                string url = NewBll.GetField(Rid, "url") == null ? "" : NewBll.GetField(Rid, "url").Trim();//
                string FilePath = ClassBll.GetClassField(ClassId, "FilePath");//频道目录
                DateTime Time = Convert.ToDateTime(NewBll.GetField(Rid, "TIME"));//文章的ID
                //参数替换
                FilePath = FilePath.ToLower().Replace("{cmspath}", "/");//替换参数
                ShowRules = ShowRules.ToLower().Replace("{cmspath}", "/");//替换参数
                ShowRules = ShowRules.ToLower().Replace("{channel}", FilePath);//替换参数
                ShowRules = ShowRules.ToLower().Replace("{id}", Rid.ToString());
                ShowRules = ShowRules.Replace("{yyyy}", Time.Year.ToString());//替换年参数
                ShowRules = ShowRules.Replace("{MM}", Time.Month.ToString());//替换月参数
                ShowRules = ShowRules.Replace("{dd}", Time.Day.ToString());//替换日参数


                Url = ShowRules;
                if (url.Length > 2)//自定义地址
                {
                    Url = url;
                }
                if (jumpurl.Length > 2)//跳转地址
                {
                    Url = jumpurl;
                }
                Url = Url.Replace("//", "/").Replace("///", "/");//替换
                return Url;
            }
            catch {
                return null;
            }

        }
    }
}
