using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace ROYcms.UI.Admin
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Administrator_class_Report : AdminPage
    {
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.BLL.ROYcms_news NewBll = new Sys.BLL.ROYcms_news();
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Templet.GetMyUrl MyUrl = new ROYcms.Templet.GetMyUrl();
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.BLL.ROYcms_class ClassBll = new Sys.BLL.ROYcms_class();
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_class Model = new Sys.Model.ROYcms_class();
        /// <summary>
        /// 
        /// </summary>
		protected void Page_Load(object sender, EventArgs e)
		{
            ViewState["Class"] = ROYcms.Common.Request.GetQueryInt("Id");
            Model = ClassBll._GetModel(ViewState["Class"].ToString());
            
		}
        /// <summary>
        /// 返回频道下文章总数
        /// </summary>
        /// <returns></returns>
        public int ArticleSize() 
        {
           int ArticleSize = NewBll.GetCount("classname=" + ViewState["Class"]);
           return ArticleSize;
        }
        /// <summary>
        /// 返回频道地址
        /// </summary>
        /// <returns></returns>
        public string GetArticleUrl(int I)
        {
            string MyUrls = null;
            int Class = Convert.ToInt32(ViewState["Class"]);
            if (I == 0){ //返回静态地址
                MyUrls = MyUrl.GetStaticChannel(Class, 0);
            }
            else if (I == 1) {//返回频道列表地址
                MyUrls = MyUrl.GetStaticChannel(Class, 1).ToLower().Replace("{page}","1");//替换参数;
            }
            else if (I == 2) {//返回动态地址
                MyUrls = "/Channel-" + Class.ToString() + ".aspx";
            }
            return MyUrls;
        }

	}
}
