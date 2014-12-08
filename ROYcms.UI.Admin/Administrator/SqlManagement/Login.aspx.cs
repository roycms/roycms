using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using ROYcms.UI.Admin;
/// <summary>
/// 
/// </summary>
public partial class Login : ROYcms.AdminPage
{
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
    protected void loginOk_Click(object sender, EventArgs e)
    {
        SQLDMO.SQLServer SqlEXPRESS = new SQLDMO.SQLServerClass();
        //组合SQLEXPRESS服务器名称
        string sqlServer = txtSQL.Text.ToString();
        string uid = txtUid.Text.ToString();
        string pwd = txtPwd.Text.ToString();
        try
        {
            SqlEXPRESS.Connect(sqlServer,uid,pwd);
            Session["SqlServer"] = sqlServer;
            Session["user"] = uid;
            Session["password"] = pwd;
            Response.Redirect("mainServer.aspx");
        }
        catch
        {
            Response.Write("服务器连接错误");
            for (int i = 0; i < this.Controls.Count; i++)
            {
                this.Controls[i].Visible = false;
            }
        }
    }
}
