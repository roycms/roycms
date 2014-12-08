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
using System.IO;

namespace ROYcms.UI.Admin.Administrator.Class
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Insert : ROYcms.AdminPage
    {
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.UI.Admin.Administrator.Model.AdminModel Index = new ROYcms.UI.Admin.Administrator.Model.AdminModel();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater_admin.DataSource = Index.Bll.GetAllList();
            Repeater_admin.DataBind(); 
        }


        /// <summary>
        /// 商品分类页面加载前类
        /// </summary>
        /// <param name="writer"></param>
        protected override void Render(HtmlTextWriter writer)
        {

            string content = string.Empty;
            StringWriter stringWriter = new StringWriter();
            HtmlTextWriter htmlWriter = new HtmlTextWriter(stringWriter);
            try
            {
                // 将当前页面的内容呈现到临时的 HtmlTextWriter 对象中  
                base.Render(htmlWriter);
                htmlWriter.Close();
                // 得到当前页面的全部内容  
                content = stringWriter.ToString();
                // 替换页面中的部分内容  
                string newContent = content;
                if (HttpContext.Current.Request.QueryString["ClassKind"] == "888888888")
                {
                    newContent = newContent.Replace("频道", "商品分类").Replace("栏目", "商品分类");
                }
                // 将新页面的内容显示出来  
                writer.Write(newContent);
            }
            catch { }
            finally
            {
                stringWriter.Dispose();
                htmlWriter.Close();
                htmlWriter.Dispose();
            }
        }
    }
}
