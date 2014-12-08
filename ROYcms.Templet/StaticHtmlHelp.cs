using System;
using System.Configuration;
using System.Collections;
using System.Data;
using System.Web;
using System.IO;

namespace ROYcms.Templet
{
    /// <summary>
    /// StaticHtmlDate
    /// </summary>
    public class StaticHtmlHelp
    {
       /// <summary>
        /// 生成首页
       /// </summary>
       /// <returns></returns>
        public static string StaticIndex() 
        {
            if (StaticHtmlDate.StaticI()) 
            {
                return " 生成首页成功！ ";
            }
            else {
                return " 生成首页失败！ ";
            }
        }
        /// <summary>
        ///  静态生成频道
        /// </summary>
        /// <param name="Class">频道ID</param>
        /// <param name="StaticHtmlType">频道类型 0封面 1列表+分页</param>
        /// <returns></returns>
        public static string StaticChannel(int Class, int StaticHtmlType)
        {
            return StaticChannel( Class,  StaticHtmlType,10 );
        }

        /// <summary>
        ///  静态生成分页频道
        /// </summary>
        /// <param name="Class">频道ID</param>
        /// <param name="StaticHtmlType">频道类型 0封面 1列表+分页</param>
        /// <returns></returns>
        public static string StaticChannel(int Class, int StaticHtmlType,int page)
        {
            string ERR = null;
            bool e1, e2 = false;
            e1 = StaticHtmlDate.StaticChannel(Class);
            if (StaticHtmlType > 0)
            {
                e2 = StaticHtmlDate.StaticChannelList(Class, page);
            }
            if (!e1)
            {
                ERR += " 静态生成频道封面失败频道编号" + Class.ToString();
            }
            if (!e2)
            {
                ERR += " 静态生成频道列表失败频道编号" + Class.ToString();
            }

            if (e1 && StaticHtmlType < 1) { ERR = " 生成频道封面成功！ "; }

            if (((StaticHtmlType > 0) && e2)) { ERR = " 生成频道列表成功！ "; }
            return ERR;
        }
        /// <summary>
        ///  静态生成频道下所有文章
        /// </summary>
        /// <param name="Class">频道ID</param>
        /// <returns></returns>
        public static string StaticChannelArticle(int Class)
        {
            int s = 0;//成功生成个数
            int e = 0;//失败生成个数
            DataSet ds = new ROYcms.Sys.BLL.ROYcms_news().GetList("classname='" + Class + "'");
            if (ds == null) return "频道下无文章";
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (StaticHtmlDate.StaticArticle(Convert.ToInt32(dr["bh"])))
                {
                    s++;
                }
                else
                {
                    e++;
                }
            }
            return " 成功生成频道下所有文章[" + s.ToString() + "]个失败[" + e.ToString() + "]个！ ";
        }
        /// <summary>
        ///  静态生成模块下所有频道
        /// </summary>
        /// <param name="ClassKind">模块ID</param>
        /// <returns></returns>
        public static string StaticObjetChannel(int ClassKind, int StaticHtmlType)
        {
            int s = 0;//成功生成个数
            int e = 0;//失败生成个数
            DataSet ds = new ROYcms.Sys.BLL.ROYcms_class().GetClassList(ClassKind);
            if (ds == null) return "模块下无频道";
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                bool t1, t2 = false;
                t1 = StaticHtmlDate.StaticChannel(Convert.ToInt32(dr["Id"]));
                if (StaticHtmlType > 0)
                {
                    t2 = StaticHtmlDate.StaticChannelList(Convert.ToInt32(dr["Id"]),10);
                }
                if (t1 && t2)
                {
                    s++;
                }
                else
                {
                    e++;
                }
            }
            return " 成功生成模块下频道[" + s.ToString() + "]个失败[" + e.ToString() + "]个！ ";
        }
        /// <summary>
        ///  静态生成所有频道
        /// </summary>
        /// <returns></returns>
        public static string StaticAllChannel()
        {
            int s = 0;//成功生成个数
            int e = 0;//失败生成个数
            DataSet ds = new ROYcms.Sys.BLL.ROYcms_class().GetClassList();
            if (ds == null) return "无频道";
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                bool t1, t2 = false;
                t1 = StaticHtmlDate.StaticChannel(Convert.ToInt32(dr["Id"]));
                t2 = StaticHtmlDate.StaticChannelList(Convert.ToInt32(dr["Id"]),10);
                if (t1 && t2)
                {
                    s++;
                }
                else
                {
                    e++;
                }
            }
            return "  成功生成所有频道[" + s.ToString() + "]个失败[" + e.ToString() + "]个！  ";
        }
        /// <summary>
        ///  静态生成所有文章
        /// </summary>
        /// <returns></returns>
        public static string StaticAllArticle()
        {
            int s = 0;//成功生成个数
            int e = 0;//失败生成个数
            DataSet ds = new ROYcms.Sys.BLL.ROYcms_news().GetAllList();
            if (ds == null) return "无文章内容";
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (StaticHtmlDate.StaticArticle(Convert.ToInt32(dr["bh"])))
                {
                    s++;
                }
                else
                {
                    e++;
                }
            }
            return " 成功生成所有文章[" + s.ToString() + "]个失败[" + e.ToString() + "]个！ ";
        }
        /// <summary>
        ///  一键生成所有
        /// </summary>
        /// <returns></returns>
        public static string StaticAll()
        {
            string AllIndex = StaticIndex();
            string AllChannel = StaticAllChannel();
            string AllArticle = StaticAllArticle();
            return AllIndex + AllChannel + AllArticle;
        }
    }
}