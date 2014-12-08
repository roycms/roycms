/**********************************************************************************
 * Description:     
 * MemberVariable:
 * Functions:       
 * Modify information:     
 * 2008-8-5     New           DuYaoHui     Create Class
 * 
 * ********************************************************************************/
using System;

using ROYcms.Common;
using System.Web.UI.WebControls;
using System.IO;
namespace ROYcms.UI.Admin
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Administrator_template_edit : AdminPage
    {
        ROYcms.Sys.BLL.ROYcms_template BLL = new ROYcms.Sys.BLL.ROYcms_template();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                ROYcms.Sys.Model.ROYcms_template Model = new ROYcms.Sys.Model.ROYcms_template();
                if (Request["id"] != null)
                {
                    Model = BLL.GetModel(Convert.ToInt32(Request["id"] == null ? "0" : Request["id"]));
                    TextBox_title.Text = Model.name;
                    TextBox_miaoshu.Text = Model.tag;
                }
                else
                {
                    TextBox_title.Visible = false;
                    TextBox_miaoshu.Visible = false;
                    Label1.Visible = false;
                    Label2.Visible = false;
                    Label_title.Text = "默认模板编辑";
                    Label_title_content.Text = "模板名 - " + Request["type"];
                }
                try
                {

                    TextBox_HTML.Text = SystemCms.Read_File(Server.MapPath(ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_root") + Session["template_z_path"].ToString() + Request["type"] + Request["id"] + ".html"), ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_language"));
                   
                }
                catch
                {
                    TextBox_HTML.Text = Model.htmlcontent;
                }

            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            //更新数据
            ROYcms.Sys.Model.ROYcms_template Model_update = new ROYcms.Sys.Model.ROYcms_template();
            if (Request["id"] != null)
            {
                Model_update.bh = Convert.ToInt32(Request["id"] == null ? "0" : Request["id"]);
                Model_update.name = TextBox_title.Text;
                Model_update.tag = TextBox_miaoshu.Text;
                Model_update.htmlcontent = TextBox_HTML.Text;
                Model_update.class_name = Request["type"];
                Model_update.htmltimes = DateTime.Now;
                Model_update.y = 0;
                BLL.Update(Model_update);
            }
            //更新模板文件
            try
            {
                string path = Server.MapPath("~/" + ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_root") + "/" + Session["template_z_path"].ToString() + "/" + Request["type"] + Request["id"] + ".html");
                if (!Directory.Exists(Server.MapPath("~/" + ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_root") + "/" + Session["template_z_path"].ToString() + "/")))
                {
                    Directory.CreateDirectory(Server.MapPath("~/" + ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_root") + "/" + Session["template_z_path"].ToString() + "/"));
                }
                SystemCms.CreateFile(path, TextBox_HTML.Text,ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_language"));
                ROYcms.Common.SystemCms.RemoveAllCache();//清除全局缓存
            }
            catch { Response.Redirect("/administrator/Message.aspx?message=更新模板出错了！&z=no"); }
            Response.Redirect("/administrator/Message.aspx?message=更新模板成功！&z=yes");
           
        }

    }
}