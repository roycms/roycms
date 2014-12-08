/**********************************************************************************
 * Description:     
 * MemberVariable:
 * Functions:       
 * Modify information:     
 * 2008-8-5     New           DuYaoHui     Create Class
 * 
 * ********************************************************************************/
using System;

using System.IO;
using System.Web.UI.WebControls;
namespace ROYcms.UI.Admin
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Administrator_template_edit_template : AdminPage
    {
        ROYcms.Sys.BLL.ROYcms_template bll = new ROYcms.Sys.BLL.ROYcms_template();
        ROYcms.Sys.BLL.ROYcms_TemplateGroup _bll = new ROYcms.Sys.BLL.ROYcms_TemplateGroup();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                TreeBind();
                listBing();

                if (Request["del"] != null)
                {
                    bll.Delete(Convert.ToInt32(Request["id"]));
                    File.Delete(Server.MapPath("~/" + ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("templet_root") + "/" + Session["template_z_path"].ToString() + "/" + Request["type"] + Request["id"] + ".html"));
                    Response.Redirect("/administrator/Message.aspx?message=删除模板成功！&z=yes");
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        void listBing() 
        {
             Repeater1.DataSource = bll.GetList(" y = '0' and z_id = '" + Session["template_z_id"] + "'");
             Repeater1.DataBind();
        }
        /// <summary>
        /// 
        /// </summary>
        void TreeBind()
        {

            template_f.DataSource = _bll.GetAllList();
            template_f.DataTextField = "z_name";
            template_f.DataValueField = "bh";
            template_f.DataBind();
            template_f.Items.Insert(0, new ListItem("◆默认模板组方案◆", ""));//插入空项，此举必须放到数据绑定之后


            if (Session["template_z_name"] != null)
            {
                template_f.SelectedValue = Session["template_z_id"].ToString();
            }
            else {
                Session["template_z_id"] = "0";
                Session["template_z_name"] = "默认方案";
                Session["template_z_path"] = "default";
                Session["template_z_url"] = "~/";
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void template_f_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (template_f.SelectedValue != "")
            {
                ROYcms.Sys.Model.ROYcms_TemplateGroup model = _bll.GetModel(Convert.ToInt32(template_f.SelectedValue));
                Session["template_z_id"] = model.bh;
                Session["template_z_name"] = model.z_name;
                Session["template_z_path"] = model.z_path;
                Session["template_z_url"] = model.z_url;
            }
            else
            {
                Session["template_z_id"] = "0";
                Session["template_z_name"] = "默认方案";
                Session["template_z_path"] = "default";
                Session["template_z_url"] = "~/";
            }
            listBing();
        }
    }
}