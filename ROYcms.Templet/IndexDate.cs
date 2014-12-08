using System;
using System.Configuration;
using System.Collections;
using System.Data;
using System.Web;
using System.IO;

namespace ROYcms.Templet
{
    /// <summary>
    /// IndexDate返回页面数据类  首页  频道 频道列表  文章
    /// </summary>
    public class IndexDate
    {
        public static string EncodIng = ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_language"); //模板编码
       // public static string IndexTemplet = "/App_Templet/Default/Index.aspx"; //首页模板地址
        public ROYcms.Sys.BLL.ROYcms_class ClassBll = new ROYcms.Sys.BLL.ROYcms_class();
        public ROYcms.Sys.BLL.ROYcms_news NewsBll = new ROYcms.Sys.BLL.ROYcms_news();
        
        /// <summary>
        /// 返回首页首页数据
        /// </summary>
        /// <returns></returns>
        public string IDate()
        {
            try
            {
                string MyUrl = "http://" + this.GetDoMain() + ClassBll.GetIndexTemplate(); //拼接后的地址
                string MyHtml = ROYcms.Common.GetUrlText.GetText(MyUrl, EncodIng);
                return MyHtml;
            }
            catch
            {
                new ROYcms.Sys.BLL.ROYcms_Log().InsertSystemLog("5", "获取首页数据失败", "获取首页数据失败");//写入日志
                return null;
            }
        }
        /// <summary>
        /// 返回频道数据
        /// </summary>
        /// <param name="IndexModels"></param>
        /// <returns></returns>
        public string ChannelDate(IndexModel IndexModels)
        {
            try
            {
                string TemplateIndex = ClassBll.GetClassField(IndexModels.type, "TemplateIndex");//对应的模板文件
                string QPre = "?type=" + IndexModels.type + "&classkind=" + IndexModels.classkind;//参数
                string MyUrl = "http://" + this.GetDoMain() + TemplateIndex + QPre;//拼接后的地址
                string MyHtml = ROYcms.Common.GetUrlText.GetText(MyUrl, EncodIng);
                return MyHtml;
            }
            catch
            {
                new ROYcms.Sys.BLL.ROYcms_Log().InsertSystemLog("5", "获取返回频道数据失败", "获取返回频道数据失败");//写入日志
                return null;
            }
        }
        /// <summary>
        /// 获取频道列表数据
        /// </summary>
        /// <param name="IndexModels"></param>
        /// <returns></returns>
        public string ChannelListDate(IndexModel IndexModels)
        {
            try
            {
                string TemplateIndex = ClassBll.GetClassField(IndexModels.type, "TemplateList");//对应的列表模板文件
                string QPre = "?type=" + IndexModels.type + "&classkind=" + IndexModels.classkind + "&page=" + IndexModels.page;//参数
                string MyUrl = "http://" + this.GetDoMain() + TemplateIndex + QPre;//拼接后的地址
                string MyHtml = ROYcms.Common.GetUrlText.GetText(MyUrl, EncodIng);
                return MyHtml;
            }
            catch
            {
                new ROYcms.Sys.BLL.ROYcms_Log().InsertSystemLog("5", "获取频道列表数据失败", "获取频道列表数据失败");//写入日志
                return null;
            }
        }
        /// <summary>
        /// 返回文章数据
        /// </summary>
        /// <param name="IndexModels"></param>
        /// <returns></returns>
        public string ArticleDate(IndexModel IndexModels)
        {
            try
            {
                IndexModels.type = Convert.ToInt32(NewsBll.GetClassName(IndexModels.id)); //获取分类ID
                string TemplateShow = ClassBll.GetClassField(IndexModels.type, "TemplateShow");//对应的模板文件
                string QPre = "?id=" + IndexModels.id + "&type=" + IndexModels.type;//参数
                string MyUrl = "http://" + this.GetDoMain() + TemplateShow + QPre;//拼接后的地址
                string MyHtml = ROYcms.Common.GetUrlText.GetText(MyUrl, EncodIng);
                return MyHtml;
            }
            catch
            {
                new ROYcms.Sys.BLL.ROYcms_Log().InsertSystemLog("5", "获取返回文章数据失败", "获取返回文章数据失败");//写入日志
                return null;
            }
        }
        /// <summary>
        /// 返回商品的数据
        /// </summary>
        /// <param name="IndexModels"></param>
        /// <returns></returns>
        //public string GoodsDate(IndexModel IndexModels)
        //{
        //    try
        //    {
        //      return this.ArticleDate(IndexModels);
        //    }
        //    catch
        //    {
        //        new ROYcms.Sys.BLL.ROYcms_Log().InsertSystemLog("5", "获取返回商品数据失败", "获取返回商品数据失败");//写入日志
        //        return null;
        //    }
        //}
        /// <summary>
        /// 返回文章数据
        /// </summary>
        /// <param name="Rid"></param>
        /// <returns></returns>
        public string GetArticleDate(int Rid)
        {
            IndexModel IndexModels = new IndexModel();
            IndexModels.id = Rid;
            IndexModels.type = Convert.ToInt32(NewsBll.GetClassName(Rid));
            string MyHtml = ArticleDate(IndexModels);
            return MyHtml;
        }
        /// <summary>
        /// 返回频道数据
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public string GetChannelDate(int type)
        {
            IndexModel IndexModels = new IndexModel();
            IndexModels.classkind = Convert.ToInt32(ClassBll.GetClassField(type, "ClassKind"));
            IndexModels.type = type;
            string MyHtml = ChannelDate(IndexModels);
            return MyHtml;
        }
        /// <summary>
        /// 返回频道列表数据
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public string GetChannelListDate(int type,int page)
        {
            IndexModel IndexModels = new IndexModel();
            IndexModels.classkind = Convert.ToInt32(ClassBll.GetClassField(type, "ClassKind"));
            IndexModels.type = type;
            IndexModels.page = page;
            string MyHtml = ChannelListDate(IndexModels);
            return MyHtml;
        }
        /// <summary>
        /// 返回域名
        /// </summary>
        /// <returns>返回格式www.roycms.cn</returns>
        public string GetDoMain()
        {
            string DoMainUrl = HttpContext.Current.Request.Url.AbsoluteUri;
            string DoMain = DoMainUrl.Substring(DoMainUrl.IndexOf(":") + 3).Substring(0, DoMainUrl.Substring(DoMainUrl.IndexOf(":") + 3).IndexOf("/")); //请求的域名
            return DoMain;
        }

    }
}