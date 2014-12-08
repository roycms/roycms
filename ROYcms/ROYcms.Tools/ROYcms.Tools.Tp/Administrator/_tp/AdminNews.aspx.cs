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
using ROYcms.DB;

namespace ROYcms.Tools.Tp.Administrator._tp
{
    public partial class AdminNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["TP_admin"] == null) { Response.Redirect("/index.aspx"); }
        }

        protected void Button_add_Click(object sender, EventArgs e)
        {
            if (TextBox_title.Text != "" || TextBox_title.Text != null)
            {
                adddate();
                GridView1.DataBind();
                ROYcms.Common.MessageBox.Show(this,"添加信息成功！");

            }
        }


        public void adddate()
        {
            string SQL = "INSERT INTO [ROYcms_New] ([type], [title],[content]) VALUES (" + DropDownList_type.SelectedValue.Trim() + ",'" + TextBox_title.Text.Trim() + "','" + FCKeditor1.Value + "')";
          
            SqlHelper.ExecuteNonQuery(SqlHelper.Conn, CommandType.Text, SQL, null);
        }
    }
}
