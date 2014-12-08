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
using System.Data.SqlClient;
using ROYcms.UI.Admin;


/// <summary>
/// 
/// </summary>
public partial class createDB : ROYcms.AdminPage
{
    static string strSQLServer;
    static string strUid;
    static string strPwd;
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        strSQLServer = Session["SqlServer"].ToString();
        strUid = Session["user"].ToString();
        strPwd = Session["password"].ToString();
        txtSqlName.Text = strSQLServer;
        txtUserName.Text = strUid;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void DBOK_Click(object sender, EventArgs e)
    {
        string strConnection = "data source=" + strSQLServer + "user id=" + strUid + "password=" + strPwd + "initial catalog=master";

        SqlConnection myConn = new SqlConnection(strConnection);

        string sqlCreateDb = "CREATE DATABASE" + txtDB.Text.ToString();

        SqlCommand myCommand = new SqlCommand(sqlCreateDb, myConn);

        myConn.Open();

        myCommand.ExecuteNonQuery();

        Response.Redirect("createTable.aspx?requestDB=" + txtDB.Text.ToString());

        myConn.Close();
    }
}
