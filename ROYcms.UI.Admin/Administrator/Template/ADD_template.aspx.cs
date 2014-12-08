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
    public partial class Administrator_template_ADD_template : AdminPage
    {
        /// <summary>
        /// 
        /// </summary>
        ROYcms.Sys.BLL.ROYcms_template BLL = new ROYcms.Sys.BLL.ROYcms_template();
        /// <summary>
        /// 
        /// </summary>
        ROYcms.Sys.Model.ROYcms_template Model = new ROYcms.Sys.Model.ROYcms_template();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void add_Button_Click(object sender, EventArgs e)
        {
            
            if (BLL.Exists() == 0)
            {
                //插入数据

                Model.name = TextBox_title.Text.Trim();
                Model.z_id = Convert.ToInt32(Session["template_z_id"].ToString());
                Model.tag = TextBox_miaoshu.Text.Trim();
                Model.htmlcontent = TextBox_htmlContent.Text;
                Model.class_name = DropDownList_type.SelectedValue.Trim();
                Model.htmltimes = DateTime.Now;
                Model.y = 0;

                //创建模板文件
                try
                {
                    string path = "";
                    path = Server.MapPath("~/" + ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_root") + "/" + Session["template_z_path"].ToString() + "/" + DropDownList_type.SelectedValue.Trim() + BLL.Add(Model) + ".html");
                    if (!Directory.Exists(Server.MapPath("~/" + ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_root") + "/" + Session["template_z_path"].ToString() + "/")))
                    {
                        Directory.CreateDirectory(Server.MapPath("~/" + ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_root") + "/" + Session["template_z_path"].ToString() + "/"));
                    }
                    SystemCms.CreateFile(path, TextBox_htmlContent.Text, ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_language"));
                }
                catch { Response.Redirect("/administrator/Message.aspx?message=创建模板出错了！&z=no"); }
                Response.Redirect("/administrator/Message.aspx?message=创建模板成功！&z=yes");
            }
            else
            {

                //更新数据
                Model.bh = BLL.Exists();
                Model.z_id = Convert.ToInt32(Session["template_z_id"].ToString());
                Model.name = TextBox_title.Text.Trim();
                Model.tag = TextBox_miaoshu.Text.Trim();
                Model.htmlcontent = TextBox_htmlContent.Text;
                Model.class_name = DropDownList_type.SelectedValue.Trim();
                Model.htmltimes = DateTime.Now;
                Model.y = 0;
                //创建模板文件
                try
                {
                    string path = "";
                    path = Server.MapPath("~/" + ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_root") + "/" + Session["template_z_path"].ToString() + "/" + DropDownList_type.SelectedValue.Trim() + BLL.Exists().ToString() + ".html");
                    if (!Directory.Exists(Server.MapPath("~/" + ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_root") + "/" + Session["template_z_path"].ToString() + "/")))
                    {
                        Directory.CreateDirectory(Server.MapPath("~/" + ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_root") + "/" + Session["template_z_path"].ToString() + "/"));
                    }
                    SystemCms.CreateFile(path, TextBox_htmlContent.Text,ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_language"));
                    BLL.Update(Model);
                }
                catch { Response.Redirect("/administrator/Message.aspx?message=创建模板出错了！&z=no"); }
                Response.Redirect("/administrator/Message.aspx?message=创建模板成功！&z=yes");


            }
        }
      
    }
}