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
public partial class mainServer : ROYcms.AdminPage
{ 
        SQLDMO.SQLServer SqlEXPRESS = new SQLDMO.SQLServerClass();
/// <summary>
/// 
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        string strSqlSer = Session["SqlServer"].ToString();

        string strUid = Session["user"].ToString();

        string strPwd = Session["password"].ToString();

        txtUser.Text = strUid;

        txtname.Text = strSqlSer;
        

        SqlEXPRESS.Connect(strSqlSer,strUid,strPwd);

        foreach(SQLDMO.Database dataExample in SqlEXPRESS.Databases)
        {
               if(dataExample.Name!=null)
               {
                    databaseList.Items.Add(dataExample.Name.ToString());
               }
        }
    }
/// <summary>
/// 
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
protected void  viewTable_Click(object sender, EventArgs e)
{
    for(int i=1;i<=SqlEXPRESS.Databases.Count;i++)
    {
            if(SqlEXPRESS.Databases.Item(i,"dbo").Name==databaseList.SelectedItem.ToString())
            {
                   SQLDMO.Database dataObj=(SQLDMO.Database)SqlEXPRESS.Databases.Item(i,"dbo");

                tableList.Items.Clear();

                for(int j=1;j<=dataObj.Tables.Count;j++)
                {
                        tableList.Items.Add(dataObj.Tables.Item(j,"dbo").Name);
                }
            }
    }
    tableList.SelectedIndex=0;
    tableList.Visible=true;
    detail.Visible = true;
}
/// <summary>
/// 
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
protected void  detail_Click(object sender, EventArgs e)
{
    string dbName=databaseList.SelectedItem.ToString();
    string tableName=tableList.SelectedItem.ToString();
    Response.Redirect("viewTableDetail.aspx?requestDbName="+dbName+"&requestTbName="+tableName);
}
/// <summary>
/// 
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
protected void  CreateDB_Click(object sender, EventArgs e)
{
    Response.Redirect("createDB.aspx");
}
/// <summary>
/// 
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
protected void  addNewTable_Click(object sender, EventArgs e)
{
    string dbName=databaseList.SelectedItem.ToString();
    Response.Redirect("createTable.aspx?requestDB="+dbName);
}
}
