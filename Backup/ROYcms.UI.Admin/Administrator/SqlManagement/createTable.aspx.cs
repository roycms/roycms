using System;
using System.Data;
using System.Data.SqlClient;
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
public partial class createTable : ROYcms.AdminPage
{
    static string strDBName;
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        //message.Text = "数据库已创建!";
        
        //Response.Write("<script>alert('数据库已经创建');</script>");

        string strSQLSer = Session["SqlServer"].ToString();

        string strUid = Session["user"].ToString();

        string strPwd = Session["password"].ToString();

        strDBName = Request.QueryString.Get("requestDB");
        txtSqlName.Text = strSQLSer;
        txtUserName.Text = strUid;
        txtDBName.Text = strDBName;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void DBOK_Click(object sender, EventArgs e)
    {
        RequiredFieldValidator1.Enabled = true;
        RequiredFieldValidator2.Enabled = true;
        string tbName = txtNewTBName.Text.ToString();
        string tbNumber = txtNumber.Text.ToString();
        Response.Redirect("createTaOK.aspx?requestDB=" + strDBName + "&requestTB=" + tbName + "&requestNumber=" + tbNumber);
    }
}
