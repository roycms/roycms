using System;
using System.Collections;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using ROYcms.UI.Admin;
/// <summary>
/// 
/// </summary>
public partial class createTaOK : ROYcms.AdminPage
{
    static string strSQLSer;
    static string strUid;
    static string strPwd;
    static string strDB;
    static string strTB;
    static int couNumber;
    /// <summary>
    /// Handles the Load event of the Page control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    protected void Page_Load(object sender, EventArgs e)
    {
        strSQLSer = Session["SqlServer"].ToString();
        strUid = Session["user"].ToString();
        strPwd = Session["password"].ToString();
        strDB = Request.QueryString.Get("requestDB");
        strTB = Request.QueryString.Get("requestTB");
        couNumber = Convert.ToInt32(Request.QueryString.Get("requestNumber"));
        txtTB.Text = strTB;

        txtSqlName.Text = strSQLSer;
        txtUserName.Text = strUid;
        txtDBName.Text = strDB;
        //创建字段数据类型数组,只是列举了几种常用的，可以自行添加
        ArrayList infoItem = new ArrayList();
        infoItem.Add("datetime");
        infoItem.Add("float");
        infoItem.Add("int");
        infoItem.Add("text");
        infoItem.Add("varchar");
        //声明TableRow
        TableRow tRow = new TableRow();
        tRow.BackColor = System.Drawing.Color.SteelBlue;
        //将TableRow添加到Tbinfo表中
        Tbinfo.Rows.Add(tRow);
        //创建TableCell对象
        TableCell tCell1 = new TableCell();
        tCell1.Text = "列名";
        TableCell tCell2 = new TableCell();
        tCell2.Text = "数据类型";
        TableCell tCell3 = new TableCell();
        tCell3.Text = "允许空";
        //将TableCell对象添加到TableRow中
        tRow.Cells.Add(tCell1);
        tRow.Cells.Add(tCell2);
        tRow.Cells.Add(tCell3);
        //动态创建用于创建表的信息
        //行总数
        int rowTotal = couNumber;
        //目前行
        int rowCurrent;
        for (rowCurrent = 1; rowCurrent <= rowTotal; rowCurrent++)
        {
            tRow = new TableRow();
            Tbinfo.Rows.Add(tRow);
            tCell1 = new TableCell();
            //创建文本框，并添加到tCell1中
            TextBox txt = new TextBox();
            txt.CssClass = "textbox";
            txt.ID = "name" + rowCurrent.ToString();
            tCell1.Controls.Add(txt);
            tCell2 = new TableCell();
            //创建下拉列表框，存储字段数据类型
            DropDownList ddl = new DropDownList();
            ddl.CssClass = "textbox";
            //将上面创建的infoItem付给ddl
            ddl.DataSource = infoItem;
            ddl.DataBind();
            ddl.ID = "type" + rowCurrent.ToString();
            tCell2.Controls.Add(ddl);
            tCell3 = new TableCell();
            //创建选择框，用于决定某列字段属否为空
            CheckBox cb = new CheckBox();
            cb.ID = "isNull" + rowCurrent.ToString();
            tCell3.Controls.Add(cb);
            tRow.Cells.Add(tCell1);
            tRow.Cells.Add(tCell2);
            tRow.Cells.Add(tCell3);
        }
        //动态创建按钮
        tRow = new TableRow();
        Tbinfo.Rows.Add(tRow);
        tCell1 = new TableCell();
        tCell1.ColumnSpan = 3;
        Button butt = new Button();
        butt.Text = "确定";
        butt.CssClass = "button";
        //添加按钮点击事件
        butt.Click += new System.EventHandler(this.butt_Click);
        tCell1.Controls.Add(butt);
        tRow.Cells.Add(tCell1);
    }
    private void butt_Click(object sender, System.EventArgs e)
    {
        string strConnection = "data source=" + strSQLSer + ";user id=" + strUid + ";password=" + strPwd + ";initial catalog=" + strDB;
        SqlConnection myconn = new SqlConnection(strConnection);
        //以下构造创建数据表的sql语句
        string strSQL = "CREATE TABLE " + strTB + "( ";
        for (int i = 1; i <= couNumber; i++)
        {
            string txtid = "name" + i.ToString();
            TextBox box = (TextBox)Page.FindControl(txtid);
            strSQL = strSQL + "[" + box.Text + "] ";
            string listid = "type" + i.ToString();
            DropDownList ddl = (DropDownList)Page.FindControl(listid);
            switch (ddl.SelectedIndex)
            {
                case 0:
                    strSQL = strSQL + "[datetime] ";
                    break;
                case 1:
                    strSQL = strSQL + "[float] ";
                    break;
                case 2:
                    strSQL = strSQL + "[int] ";
                    break;
                case 3:
                    strSQL = strSQL + "[text] ";
                    break;
                case 4:
                    strSQL = strSQL + "[varchar](50) ";
                    break;
                default:
                    strSQL = strSQL + "[varchar](50) ";
                    break;
            }
            string chid = "isNull" + i.ToString();
            CheckBox cb = (CheckBox)Page.FindControl(chid);
            if (cb.Checked)
                strSQL = strSQL + "NULL,";
            else
                strSQL = strSQL + "NOT NULL,";
        }
        strSQL = strSQL + ")";
        SqlCommand myCommand = new SqlCommand(strSQL, myconn);
        myconn.Open();
        myCommand.ExecuteNonQuery();
        myconn.Close();
        Response.Redirect("mainServer.aspx");
    }
    /// <summary>
    /// Handles the Click event of the backMana control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    protected void backMana_Click(object sender, EventArgs e)
    {
        Response.Redirect("mainServer.aspx");
    }
}
