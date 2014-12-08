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
public partial class viewTableDetail : ROYcms.AdminPage
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        string strSqlSer = Session["sqlServer"].ToString();
        string strUid = Session["user"].ToString();
        string strPwd = Session["password"].ToString();
        string DbName = Request.QueryString.Get("requestDbName");
        string TbName = Request.QueryString.Get("requestTbName");
        txtDB.Text = DbName;
        txtTB.Text = TbName;

        string strConn = "data source=" + strSqlSer + ";user id=" + strUid + ";password=" + strPwd + ";initial catalog=" + DbName; ;
        SqlConnection myConn = new SqlConnection(strConn);
        string strSQL = "SELECT * FROM " + TbName;
        SqlCommand myCommand = new SqlCommand(strSQL, myConn);
        myConn.Open();
        myGW.DataSource = myCommand.ExecuteReader();
        myGW.DataBind();
        myConn.Close();
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    protected void back_Click(object sender, EventArgs e)
    {
        Response.Redirect("mainServer.aspx");
    }
}
