using System;
using System.Data;
using ROYcms.DB;
using ROYcms.Common;

namespace ROYcms.Tools.Tp.Administrator._tp
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                show();
                
                
               // new_show();
            }
        }
        void show()
        {
            string SQL1 = "select * from [ROYcms_TP_date]  where z_id='13'";

            string SQL2 = "select * from [ROYcms_TP_date]  where z_id='14' ";
            string SQL3 = "select * from [ROYcms_TP_date]  where z_id='15' ";
            string SQL4 = "select * from [ROYcms_TP_date]  where z_id='16' ";
            //string SQL5 = "select * from [ROYcms_TP_date]  where z_id='8' ";
            //string SQL6 = "select * from [ROYcms_TP_date]  where z_id='9' ";
            //string SQL7 = "select * from [ROYcms_TP_date]  where z_id='10' ";
            //string SQL8 = "select * from [ROYcms_TP_date]  where z_id='11' ";
            //string SQL9 = "select * from [ROYcms_TP_date]  where z_id='12' ";
            //string SQL10 = "select * from [ROYcms_TP_date]  where z_id='13' ";
            Repeater_tu1.DataSource = SqlHelper.ExecuteReader(SqlHelper.Conn, CommandType.Text, SQL1, null);
            Repeater_tu1.DataBind();
            Repeater_tu2.DataSource = SqlHelper.ExecuteReader(SqlHelper.Conn, CommandType.Text, SQL2, null);
            Repeater_tu2.DataBind();
            Repeater_tu3.DataSource = SqlHelper.ExecuteReader(SqlHelper.Conn, CommandType.Text, SQL3, null);
            Repeater_tu3.DataBind();
            Repeater_tu4.DataSource = SqlHelper.ExecuteReader(SqlHelper.Conn, CommandType.Text, SQL4, null);
            Repeater_tu4.DataBind();
            //Repeater_tu5.DataSource = SqlHelper.ExecuteReader(SqlHelper.Conn, CommandType.Text, SQL5, null);
            //Repeater_tu5.DataBind();
            //Repeater_tu6.DataSource = SqlHelper.ExecuteReader(SqlHelper.Conn, CommandType.Text, SQL6, null);
            //Repeater_tu6.DataBind();
            //Repeater_tu7.DataSource = SqlHelper.ExecuteReader(SqlHelper.Conn, CommandType.Text, SQL7, null);
            //Repeater_tu7.DataBind();
            //Repeater_tu8.DataSource = SqlHelper.ExecuteReader(SqlHelper.Conn, CommandType.Text, SQL8, null);
            //Repeater_tu8.DataBind();
            //Repeater_tu9.DataSource = SqlHelper.ExecuteReader(SqlHelper.Conn, CommandType.Text, SQL9, null);
            //Repeater_tu9.DataBind();
            //Repeater_tu10.DataSource = SqlHelper.ExecuteReader(SqlHelper.Conn, CommandType.Text, SQL10, null);
            //Repeater_tu10.DataBind();
        }
        //void new_show()
        //{
        //    string SQL1 = "select top 9 * from [ROYcms_New] where type=1 order by id desc ";
        //    string SQL2 = "select top 9  * from [ROYcms_New] where type=2 order by id desc";
          
        //    Repeater_new1.DataSource = SqlHelper.ExecuteReader(SqlHelper.Conn, CommandType.Text, SQL1, null);
        //    Repeater_new1.DataBind();
        //    Repeater_new2.DataSource = SqlHelper.ExecuteReader(SqlHelper.Conn, CommandType.Text, SQL2, null);
        //    Repeater_new2.DataBind();
         
        //}
        protected void ImageButton_tp_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
           // ROYcms.Common.SystemCms.CreateFile(Server.MapPath("/61/index.php"), ROYcms.Common.GetUrlText.GetText("http://www.5visp.com/61/index.aspx", "utf-8"), "utf-8");
            //add_pl();
            Server.Transfer("ROYcms_TP.aspx");

        }
        /// <summary>
        /// 添加评论
        /// </summary>
        //public void add_pl()
        //{
        //    if (t_name.Value != "" && t_tel.Value != "" && t_card.Value != "")
        //    {
        //        string sql = "insert into [ROYcms_TP_remark] (pl_title,tel,card,pl_content,z_id) values('" + t_name.Value + "','" + t_tel.Value + "','" + t_card.Value + "','" + t_content.Value + "','0')";
        //        int ii = SqlHelper.ExecuteNonQuery(SqlHelper.Conn, CommandType.Text, sql, null);

        //        Server.Transfer("ROYcms_TP.aspx");

        //    }
        //    else { MessageBox.Show(this, "你没有完整的填写信息！"); }
        //}

        //protected void SearchImageButton_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        //{
        //    Server.Transfer("Search.aspx");

        //}
    }
}
