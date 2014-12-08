using System;
using System.Configuration;
using System.Collections;
using System.Data;
using System.Web;
using System.IO;
using System.Threading;

namespace ROYcms.Templet
{
    /// <summary>
    /// StaticHtmlDate
    /// </summary>
    public class StaticHtmlDate
    {
        /// <summary>
        ///  静态生成首页
        /// </summary>
        /// <returns></returns>
        public static bool StaticI()
        {
            try
            {
                string IndexUrl = new ROYcms.Templet.GetMyUrl().GetStaticIndex();
                if (IndexUrl == null) return false;
                //2013-08-07修复BUG
                Thread.Sleep(200);//暂停0.5秒
                string IndexD = new IndexDate().IDate();
                if (IndexD == null) return false;
                return ROYcms.Common.SystemCms.Create(HttpContext.Current.Server.MapPath(IndexUrl), IndexD, IndexDate.EncodIng);
            }
            catch {
                new ROYcms.Sys.BLL.ROYcms_Log().InsertSystemLog("5", "静态生成首页失败", "静态生成首页失败");//写入日志
                return false;
            }
        }
        /// <summary>
        /// 静态生成频道封面
        /// </summary>
        /// <param name="IndexModels"></param>
        /// <returns></returns>
        public static bool StaticChannel(int Type)
        {
            try
            {
                string ChannelUrl = new ROYcms.Templet.GetMyUrl().GetStaticChannel(Type, 0);
                if (ChannelUrl == null) return false;
                //2013-08-07修复BUG
                Thread.Sleep(200);//暂停0.5秒
                string ChannelD = new IndexDate().GetChannelDate(Type);
                if (ChannelD == null) return false;
                GRoot(ChannelUrl);//创建目录
                return ROYcms.Common.SystemCms.Create(HttpContext.Current.Server.MapPath(ChannelUrl), ChannelD, IndexDate.EncodIng);
            }
            catch
            {
                new ROYcms.Sys.BLL.ROYcms_Log().InsertSystemLog("5", "静态生成频道失败", "静态生成频道失败");//写入日志
                return false;
            }
        }
        /// <summary>
        /// 静态生成频道的列表
        /// </summary>
        /// <param name="IndexModels"></param>
        /// <returns></returns>
        public static bool StaticChannelList(int Type,int page)
        {
            try
            {
                bool e = false;
                if (page > 0)
                {
                    //2013-07-27修复BUG   i = 1
                    for (int i = 1; i < page; i++)
                    {
                        //2013-08-07修复BUG
                        Thread.Sleep(200);//暂停0.5秒

                        string ChannelListUrl = new ROYcms.Templet.GetMyUrl().GetStaticChannel(Type, 1);
                        //2013-07-27修复BUG
                        if (ChannelListUrl == null) return false;
                        ChannelListUrl = ChannelListUrl.ToLower().Replace("{page}", i.ToString());//替换参数
                       
                        string ChannelListD = new IndexDate().GetChannelListDate(Type, i);
                        //2013-07-27修复BUG
                        if (ChannelListD == null) return false;
                        GRoot(ChannelListUrl);//创建目录
                        e = ROYcms.Common.SystemCms.Create(HttpContext.Current.Server.MapPath(ChannelListUrl), ChannelListD, IndexDate.EncodIng);
                    }
                }
                return e;
            }
            catch
            {
                new ROYcms.Sys.BLL.ROYcms_Log().InsertSystemLog("5", "静态生成频道的列表失败", "静态生成频道的列表失败");//写入日志
                return false;
            }
        }
        /// <summary>
        /// 静态生成文章
        /// </summary>
        /// <param name="IndexModels"></param>
        /// <returns></returns>
        public static bool StaticArticle(int Id)
        {
            try
            {
                string ArticleUrl = new ROYcms.Templet.GetMyUrl().GetStaticArticle(Id);
                if (ArticleUrl == null) return false;
                //2013-08-07修复BUG
                Thread.Sleep(200);//暂停0.5秒
                string ArticleD = new IndexDate().GetArticleDate(Id);
                if (ArticleD == null) return false;
                GRoot(ArticleUrl);//创建目录
                return ROYcms.Common.SystemCms.Create(HttpContext.Current.Server.MapPath(ArticleUrl), ArticleD, IndexDate.EncodIng);
            }
            catch
            {
                new ROYcms.Sys.BLL.ROYcms_Log().InsertSystemLog("5", "静态生成文章失败", "静态生成文章失败");//写入日志
                return false;
            }
        }
        /// <summary>
        /// 创建目录
        /// </summary>
        /// <param name="FilePath"></param>
        /// <returns></returns>
        public static void GRoot(string FilePath)
        {
            string Root = FilePath.Substring(0,FilePath.LastIndexOf("/"));
            if (!Directory.Exists(HttpContext.Current.Server.MapPath(Root)))
            {
                Directory.CreateDirectory(HttpContext.Current.Server.MapPath(Root));
            }
        }
      
    }
}