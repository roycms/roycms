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
using ROYcms.Common;

namespace ROYcms.Tools.Tp.Administrator._tp
{
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                show();
            }
        }
        void show()
        {
            string SQL = "";

            if (Request["t"] != null) { SQL = "select * from [ROYcms_TP_date] where z_id='" + Request["t"].Trim() + "'"; }
            else if (Request["keyword"]!="") { SQL = "select * from [ROYcms_TP_date] where names like '%" + Request["keyword"].Trim() + "%' "; }
            else{SQL = "select * from [ROYcms_TP_date] ";}
            Repeater_tu.DataSource = SqlHelper.ExecuteReader(SqlHelper.Conn, CommandType.Text, SQL, null);
            Repeater_tu.DataBind();
          
        }
        protected void ImageButton_tp_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            add_pl();
        }
        /// <summary>
        /// 添加评论
        /// </summary>
        public void add_pl()
        {
            if (t_name.Value != "" && t_tel.Value != "" && t_card.Value != "")
            {
                string sql = "insert into [ROYcms_TP_remark] (pl_title,tel,card,pl_content,z_id) values('" + t_name.Value + "','" + t_tel.Value + "','" + t_card.Value + "','" + t_content.Value + "','0')";
                int ii = SqlHelper.ExecuteNonQuery(SqlHelper.Conn, CommandType.Text, sql, null);

                Server.Transfer("ROYcms_TP.aspx");

            }
            else { MessageBox.Show(this, "你没有完整的填写信息！"); }
        }
        protected void SearchImageButton_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            Server.Transfer("Search.aspx");

        }
    }
}
