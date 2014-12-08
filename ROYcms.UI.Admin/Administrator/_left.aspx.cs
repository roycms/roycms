using System;
using System.Data;
using ROYcms.Common;
namespace ROYcms.UI.Admin
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Administrator_admin_left : BasePage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Repeater_Objet.DataSource = new ROYcms.Sys.BLL.ROYcms_Objet().GetAllList();
                Repeater_Objet.DataBind();
                string XSLString = "~/administrator/App_Config/AdminMenu/Navigation.xsl";
                Xml1.DocumentSource = "~/administrator/App_Config/AdminMenu/AdminNavigationTab1.xml";
                Xml1.TransformSource = XSLString;
                Xml2.DocumentSource = "~/administrator/App_Config/AdminMenu/AdminNavigationTab2.xml";
                Xml2.TransformSource = XSLString;
                Xml3.DocumentSource = "~/administrator/App_Config/AdminMenu/AdminNavigationTab3.xml";
                Xml3.TransformSource = XSLString;
            }
        }
    }
}
