using System;
using System.Data;
using ROYcms.Common;
using ROYcms.DB;
namespace ROYcms.Tools.Tp
{
    public partial class _Default : System.Web.UI.Page
    {
        public string group_name, group_content, group_x, group_time;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request["group"] != null)
                {
                    Panel_show.Visible = true;
                    show();
                    group_date();
                    Page.Title = group_name;
                    Label_group_name.Text = group_name;
                    Label_group_content.Text = group_content;
                    Label_group_x.Text = group_x;
                    Label_group_date_time.Text = group_time;
                }
                else
                {
                    list_show();
                    Panel_show.Visible = false;
                }
                string SQL = "select top 10 * from [ROYcms_TP_group] order by id DESC ";
                Repeater_right1_group.DataSource = SqlHelper.ExecuteReader(SqlHelper.Conn, CommandType.Text, SQL, null);
                Repeater_right1_group.DataBind();
                string SQL2 = "select top 10 * from [ROYcms_TP_group]";
                Repeater_right2_group.DataSource = SqlHelper.ExecuteReader(SqlHelper.Conn, CommandType.Text, SQL2, null);
                Repeater_right2_group.DataBind();
            }
        }

        void list_show()
        {
            string SQL = "select * from [ROYcms_TP_group] order by id DESC ";
            Repeater_group.DataSource = SqlHelper.ExecuteReader(SqlHelper.Conn, CommandType.Text, SQL, null);
            Repeater_group.DataBind();
        }
        void show()
        {
            string SQL = "select * from [ROYcms_TP_date] where z_id = '" + Request["group"] + "' order by id DESC ";
            Repeater_tu.DataSource = SqlHelper.ExecuteReader(SqlHelper.Conn, CommandType.Text, SQL, null);
            Repeater_tu.DataBind();

            string SQL2 = "select * from [ROYcms_TP_remark] where z_id = '" + Request["group"] + "' order by id DESC ";
            Repeater_pl.DataSource = SqlHelper.ExecuteReader(SqlHelper.Conn, CommandType.Text, SQL2, null);
            Repeater_pl.DataBind();

        }
        //百分比计算
        public string ny(int n)
        {
            string strSql = "select sum(ballot) from [ROYcms_TP_date] where y = '1' ";
            if (Request["group"] != null) { strSql = "select sum(ballot) from [ROYcms_TP_date] where z_id='" + Request["group"] + "' and y = '1'"; }
            float i = 0;
            try
            {
                i = Convert.ToInt64(SqlHelper.ExecuteScalar(SqlHelper.Conn, CommandType.Text, strSql, null));
                Label_group_num.Text = i.ToString();
            }
            catch
            {
                i = 1;
            }

            return ((((n / i) > 0.98 ? 0.98 : (n / i)) * 100).ToString() + "0000").Substring(0, 2).Replace(".", "") + "%";

        }
        public string hot_group(int n)
        {

            string strSql = "select sum(ballot) from [ROYcms_TP_date] where z_id='" + n + "' and y = '1'";
            int i = 0;
            try
            {
                i = Convert.ToInt32(SqlHelper.ExecuteScalar(SqlHelper.Conn, CommandType.Text, strSql, null));
            }
            catch
            {
                i = 1;
            }
            return i.ToString();
        }
        public string time_c(string date_time)
        {
            try
            {
                DateTime dt1 = DateTime.Now;
                DateTime dt2 = Convert.ToDateTime(date_time);
                TimeSpan ts = dt1 - dt2;
                if (ts.TotalHours > 24)
                {
                    return Convert.ToInt32(ts.TotalDays).ToString() + "天" + Convert.ToInt32(ts.TotalHours - 24).ToString() + "小时以前";
                }
                else { return Convert.ToInt32(ts.TotalHours).ToString() + "小时以前"; }
            }
            catch { return "未知"; }
        }
        public string sum_pl(int n)
        {

            string strSql = "select * from [ROYcms_TP_remark] where z_id='" + n + "'";
            int i = 0;
            try
            {
                i = Convert.ToInt32(SqlHelper.ExecuteScalar(SqlHelper.Conn, CommandType.Text, strSql, null));
            }
            catch
            {
                i = 1;
            }
            return i.ToString();
        }
        void group_date()
        {
            string SQL = "select top 1 * from [ROYcms_TP_group] where id='" + Request["group"] + "' ";
            DataSet dt = ROYcms.DB.SqlHelper.ExecuteDataSet(ROYcms.DB.SqlHelper.Conn, SQL);
            if (dt.Tables[0].Rows.Count > 0)
            {
                this.group_name = dt.Tables[0].Rows[0]["group_name"].ToString().Trim();
                this.group_content = dt.Tables[0].Rows[0]["group_content"].ToString().Trim();
                this.group_time = dt.Tables[0].Rows[0]["date_time"].ToString().Trim();
                this.group_x = dt.Tables[0].Rows[0]["group_x"].ToString().Trim() == "1" ? "单选" : "多选";
            }
        }
        protected void ImageButton_liuyan_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            /// <summary>
            /// 添加评论
            /// </summary>
            if (Request["remark_title"] != "" && Request["remark_content"] != "")
            {
                string sql = "insert into [ROYcms_TP_remark] (pl_title,pl_content,z_id) values('" + Request["remark_title"] + "','" + Request["remark_content"] + "','" + Request["group"] + "')";
                SqlHelper.ExecuteNonQuery(SqlHelper.Conn, CommandType.Text, sql, null);

                show();
                MessageBox.Show(this, "评论添加成功！");
            }
            else { MessageBox.Show(this, "你没有完整的填写信息！"); }

        }
        public string type()
        {
            group_date();
            string types = "checkbox";
            if (this.group_x == "单选") { types = "radio"; }
            else { types = "checkbox"; }
            return types;
        }
        protected void ImageButton_tp_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            Server.Transfer("ROYcms_TP.aspx");
        }
    }
}