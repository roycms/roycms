using System;
using System.Data;
using System.Web;
using ROYcms.Common;
using System.Data.SqlClient;
using System.Globalization;
using System.Web.UI.WebControls;
using ROYcms.DB;
using System.IO;

namespace ROYcms.Tools.Tp
{
    public partial class ROYcms_TP : System.Web.UI.Page
    {


        public int TIME;
        public string userip = null;//获取当前IP
        public string Redirect;
        public string tp_id = null;//
        public string[] tp_id_z = null;//
        public string ConfigPath = "~/Administrator/App_Config/ROYcms_TP.config";//

        protected void Page_Load(object sender, EventArgs e)
        {
            XmlControl Config = new XmlControl(Server.MapPath(ConfigPath));

            this.TIME = Convert.ToInt32(Config.GetText("//TP_time"));//同一IP 限定时间;
            this.Redirect = Config.GetText("//TP_Redirect");//投票成功之后返回的页面;
            if (!IsPostBack)
            {
               // Page.Session["TP_admin"] = "ADMIN";

                if (Request["tp_id"] == null && Request["tp_id[]"] == null)
                {
                    BIND();
                    if (Session["TP_admin"] != null)
                    {
                        Panel_index.Visible = true;
                        Panel_tu.Visible = false;
                        switch (Request["t"])
                        {
                            case "del":
                                del(); BIND(); MessageBox.ResponseScript(this, "TabbedPanels1.showPanel(2)");
                                break;
                            case "y":
                                update(); BIND(); MessageBox.ResponseScript(this, "TabbedPanels1.showPanel(2)");
                                break;
                            case "group_del":
                                group_del(); BIND(); MessageBox.ResponseScript(this, "TabbedPanels1.showPanel(5)");
                                break;
                            case "group_edit":
                                Panel_edit_group.Visible = true;
                                group_edit_bind(); MessageBox.ResponseScript(this, "TabbedPanels1.showPanel(5)");
                                break;
                            case "date_edit":
                                Panel_edit_date.Visible = true;
                                date_edit_bind(); MessageBox.ResponseScript(this, "TabbedPanels1.showPanel(2)");
                                break;
                            case "remark_del":
                                remark_del(); BIND(); MessageBox.ResponseScript(this, "TabbedPanels1.showPanel(7)");
                                break;
                            case "baoming_del":
                                baoming_del(); BIND(); MessageBox.ResponseScript(this, "TabbedPanels1.showPanel(7)");
                                break;
                            case "logout":
                                Session["group"] = null;
                                Session["group_name"] = null;
                                BIND();
                                break;
                            case "out":
                                Session["TP_admin"] = null;
                                Response.Redirect("ROYcms_TP.aspx");
                                break;
                        }
                    }
                    else
                    {
                        Panel_index.Visible = false;
                        Panel_tu.Visible = true;
                    }

                }
                else
                {
                    Panel_index.Visible = false;
                    Panel_tu.Visible = false;

                    if (Request["tp_id[]"] != null)
                    {
                        tp_id_z = Request["tp_id[]"].Trim().Split(',');
                    }
                    if (Request["tp_id"] != null)
                    {
                        tp_id_z = Request["tp_id"].Trim().Split(',');
                    }
                    for (int i = 0; i < tp_id_z.Length; ++i)
                    {
                        tp_id = tp_id_z[i];
                        //投票
                        userip = Request.UserHostAddress.ToString();


                        //如果配置文件设置关闭了限制同一IP投票 则在这里直接投票
                        if (Config.GetText("//TP_IP_Y") == "false")
                        {
                            addIP();//添加IP
                            tt();   //投票
                        }

                        else
                        {
                            //ip存在
                            if (checkVoterIP() == true)
                            {
                                //接下来要做的事情是检测该用户上次投票时间间隔
                                if (checkTime() == true)
                                {
                                    if (tp_id_z.Length == 1)
                                    {
                                        Response.Write("对不起，为了公平，请不要反复投票！");
                                        MessageBox.ShowAndRedirect(this, "对不起，为了公平，请不要反复投票！", Redirect);
                                    }
                                }
                                else
                                {
                                    update_date();//修改IP时间
                                    tt();//投票  
                                }
                            }
                            //IP不存在时
                            else
                            {
                                addIP();//添加IP
                                tt();   //投票
                            }
                        }
                    }

                    if (tp_id_z.Length > 1)
                    {
                        Response.Write("批量投" + tp_id_z.Length + "票成功！");
                        MessageBox.ShowAndRedirect(this, "批量投" + tp_id_z.Length + "票成功！", Redirect);
                    }
                    else
                    {
                        MessageBox.ShowAndRedirect(this, "你没有选择！", Redirect);
                    }

                }

                //评论
                if (Request["remark_title"] != null)
                {
                    Panel_index.Visible = false;
                    Panel_tu.Visible = false;
                    add_remark();
                }
                //
                if (Request["administrator"] != null)
                {
                    Panel_administrator.Visible = true;
                }

            }

        }
        private void baoming_del()
        {
            string SQL = "delete [ROYcms_TP_baoming] where id= '" + Request["id"] + "'";
            SqlHelper.ExecuteNonQuery(SqlHelper.Conn, CommandType.Text, SQL, null);
        }
        //删除组
        private void group_del()
        {
            string SQL = "delete [ROYcms_TP_group] where id= '" + Request["id"] + "'";
            SqlHelper.ExecuteNonQuery(SqlHelper.Conn, CommandType.Text, SQL, null);
            //同时删除组里的所有所有项目
            //string SQL2 = "delete [ROYcms_TP_date] where z_id= '" + Request["id"] + "'";
            //SqlHelper.ExecuteNonQuery(SqlHelper.Conn, CommandType.Text, SQL2, null);
        }

        //百分比计算
        public string ny(int n)
        {
            string strSql = "select sum(ballot) from [ROYcms_TP_date] where y = '1' ";
            if (Session["group"] != null) { strSql = "select sum(ballot) from [ROYcms_TP_date] where z_id='" + Session["group"] + "' and y = '1'"; }
            float i = 0;
            try
            {
                i = Convert.ToInt64(SqlHelper.ExecuteScalar(SqlHelper.Conn, CommandType.Text, strSql, null));
            }
            catch
            {
                i = 1;
            }
            return ((((n / i) > 0.98 ? 0.98 : (n / i)) * 100).ToString() + "0000").Substring(0, 2).Replace(".", "") + "%";
        }
        //审核连接显示
        public string no(string id)
        {
            return " - <a href='?id=" + id + "&t=y' >审核</a>";
        }

        public void adddate(string img_path)
        {
            string SQL = "INSERT INTO [ROYcms_TP_date] ([img_path], [names],[link_url],[characterization],[y]) VALUES ('" + img_path.Trim() + "','" + names.Text.Trim() + "','" + link_url.Text.Trim() + "','" + characterization.Text.Trim() + "','1')";
            if (Session["group"] != null)
            {
                SQL = "INSERT INTO [ROYcms_TP_date] ([img_path], [names],[link_url],[characterization],[z_id],[y]) VALUES ('" + img_path.Trim() + "','" + names.Text.Trim() + "','" + link_url.Text.Trim() + "','" + characterization.Text.Trim() + "','" + Session["group"] + "','1')";
            }
            SqlHelper.ExecuteNonQuery(SqlHelper.Conn, CommandType.Text, SQL, null);
        }

        public void small_adddate()
        {
            string SQL = "INSERT INTO [ROYcms_TP_date] ([img_path], [names],[link_url],[characterization],[y]) VALUES ('null','" + small_names.Text.Trim() + "','null','null','1')";
            if (Session["group"] != null)
            {
                SQL = "INSERT INTO [ROYcms_TP_date] ([img_path], [names],[link_url],[characterization],[z_id],[y]) VALUES ('null','" + small_names.Text.Trim() + "','null','null','" + Session["group"] + "','1')";
            }
            SqlHelper.ExecuteNonQuery(SqlHelper.Conn, CommandType.Text, SQL, null);
        }


        //添加项目事件
        protected void Button1_Click(object sender, EventArgs e)
        {
            XmlControl Config = new XmlControl(Server.MapPath(ConfigPath));

            string times = DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss_");

            HttpFileCollection files = HttpContext.Current.Request.Files;
            try
            {
                for (int iFile = 0; iFile < files.Count; iFile++)
                {
                    HttpPostedFile postedFile = files[iFile];
                    string fileName, fileExtension;
                    fileName = System.IO.Path.GetFileName(postedFile.FileName);
                    if (fileName != null)
                    {
                        string dataName = times + iFile;
                        fileExtension = System.IO.Path.GetExtension(fileName);
                        postedFile.SaveAs(System.Web.HttpContext.Current.Request.MapPath(Config.GetText("//TP_upfile")) + dataName + fileExtension);
                        String IMG_URL = dataName + fileExtension;
                        //生成缩略图
                        System.Drawing.Image.GetThumbnailImageAbort callb = null;
                        System.Drawing.Image image = System.Drawing.Image.FromFile(System.Web.HttpContext.Current.Request.MapPath(Config.GetText("//TP_upfile")) + dataName + fileExtension);
                        string[] w_h = Config.GetText("//TP_upfile_w_h").Split(',');
                        System.Drawing.Image newimage = image.GetThumbnailImage(Convert.ToInt32(w_h[0]), Convert.ToInt32(w_h[1]), callb, new System.IntPtr());
                        newimage.Save(System.Web.HttpContext.Current.Request.MapPath(Config.GetText("//TP_upfile") + "small_") + dataName + fileExtension);
                        adddate(IMG_URL);
                        BIND();
                        MessageBox.ResponseScript(this, "TabbedPanels1.showPanel(1);alert('项目添加成功！');");
                    }
                    else
                    {
                        MessageBox.ResponseScript(this, "alert('你选的文件类型不符!');");
                    }

                }
            }
            catch { MessageBox.ResponseScript(this, "alert('出现错误!');"); }
        }

        //管理项目绑定数据

        public void del()
        {
            //string SQL = "select img_path from [ROYcms_TP_date] where id= '" + Request["id"] + "'";
            //string path = Convert.ToString(SqlHelper.ExecuteScalar(SqlHelper.Conn, CommandType.Text, SQL, null));
            // File.Delete(Server.MapPath(ConfigurationManager.AppSettings["TP_upfile"]+path));
            string SQL1 = "delete [ROYcms_TP_date] where id= '" + Request["id"] + "'";
            SqlHelper.ExecuteNonQuery(SqlHelper.Conn, CommandType.Text, SQL1, null);


        }
        public void update()
        {
            string SQL = "update [ROYcms_TP_date] set y='1' where id= '" + Request["id"] + "'";
            SqlHelper.ExecuteNonQuery(SqlHelper.Conn, CommandType.Text, SQL, null);
        }
        public void BIND()
        {
            //管理列表
            string SQL = "select * from [ROYcms_TP_date] order by id DESC ";
            if (Session["group"] != null) { SQL = "select * from [ROYcms_TP_date] where z_id='" + Session["group"] + "' and y='1' order by id DESC "; }
            string SQL2 = "select * from [ROYcms_TP_group] order by id DESC ";
            Repeater_xmlist.DataSource = SqlHelper.ExecuteReader(SqlHelper.Conn, CommandType.Text, SQL, null);
            Repeater_xmlist.DataBind();
            //示意图数据绑定
            Repeater_tu.DataSource = SqlHelper.ExecuteReader(SqlHelper.Conn, CommandType.Text, SQL, null);
            Repeater_tu.DataBind();

            //Repeater_tu_s.DataSource = SqlHelper.ExecuteReader(SqlHelper.Conn, CommandType.Text, SQL, null);
            //Repeater_tu_s.DataBind();

            Repeater_group.DataSource = SqlHelper.ExecuteReader(SqlHelper.Conn, CommandType.Text, SQL2, null);
            Repeater_group.DataBind();

            DropDownList_group.DataSource = SqlHelper.ExecuteReader(SqlHelper.Conn, CommandType.Text, SQL2, null);
            DropDownList_group.DataTextField = "group_name";
            DropDownList_group.DataValueField = "id";
            try
            {
                DropDownList_group.DataBind();
            }
            catch { }
            DropDownList_group.Items.Insert(0, new ListItem("◆请选择要管理初始化的投票组◆", ""));//插入空项，此举必须放到数据绑定之后
            if (Session["group"] != null)
            {
                try
                {
                    DropDownList_group.SelectedValue = Session["group"].ToString();
                }
                catch { }
            }
            else { DropDownList_group.SelectedValue = ""; }

            XmlControl Config = new XmlControl(Server.MapPath(ConfigPath));

            config_time.Text = Config.GetText("//TP_time");
            TP_upfile.Text = Config.GetText("//TP_upfile");
            TP_upfile_w_h.Text = Config.GetText("//TP_upfile_w_h");
            admin_password.Text = Config.GetText("//TP_password");
            TP_Redirect.Text = Config.GetText("//TP_Redirect");
            if (Config.GetText("TP_IP_Y") == "true")
            {
                CheckBox_IP_Y.Checked = true;
            }

            //前台示意图绑定
            string SQL3 = "select * from [ROYcms_TP_date] where z_id='" + Request["group"] + "' order by id DESC ";
            if (Request["group"] != null)
            {
                Repeater_user_tu.DataSource = SqlHelper.ExecuteReader(SqlHelper.Conn, CommandType.Text, SQL3, null);
                Repeater_user_tu.DataBind();
            }

            //根据ID返回组数据
            string SQL4 = "select * from [ROYcms_TP_group] where id= '" + Request["group"] + "'";
            Repeater_user_z.DataSource = SqlHelper.ExecuteReader(SqlHelper.Conn, CommandType.Text, SQL4, null);
            Repeater_user_z.DataBind();

            if (Session["group_type"] != null && Convert.ToInt32(Session["group_type"]) == 1)
            {
                Panel_small.Visible = true;
                Panel_big.Visible = false;
            }
        }
        //配置文件设置事件
        protected void Button2_Click(object sender, EventArgs e)
        {
            XmlControl Config = new XmlControl(Server.MapPath(ConfigPath));
            Config.Replace("//TP_time", config_time.Text.Trim());
            Config.Replace("//TP_upfile", TP_upfile.Text.Trim());
            Config.Replace("//TP_upfile_w_h", TP_upfile_w_h.Text.Trim());
            Config.Replace("//TP_password", admin_password.Text.Trim());
            Config.Replace("//TP_Redirect", TP_Redirect.Text.Trim());

            if (CheckBox_IP_Y.Checked)
            {
                Config.Replace("//TP_IP_Y", "true");
            }
            else { Config.Replace("//TP_IP_Y", "false"); }

            Config.Save();

            MessageBox.ResponseScript(this, "TabbedPanels1.showPanel(3);alert('配置文件设置成功！');");
        }
        //small项目添加；
        protected void Button4_Click(object sender, EventArgs e)
        {
            small_adddate();
            BIND();
            MessageBox.ResponseScript(this, "TabbedPanels1.showPanel(1);alert('项目添加成功！');");
        }

        //项目组添加事件
        protected void Button3_Click(object sender, EventArgs e)
        {
            string CK = "";
            if (CheckBoxA.Checked) { CK = "0"; }
            else { CK = "1"; }
            string SQL = "INSERT INTO [ROYcms_TP_group] ([group_name], [group_content], [group_type], [group_x]) VALUES ('" + group_name.Text.Trim() + "','" + group_content.Text.Trim() + "','" + CK + "','" + RadioButtonListX.SelectedValue + "')";
            SqlHelper.ExecuteNonQuery(SqlHelper.Conn, CommandType.Text, SQL, null);
            BIND();
            MessageBox.ResponseScript(this, "TabbedPanels1.showPanel(4);alert('项目组添加成功！');");
        }
        protected void DropDownList_group_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList_group.SelectedValue != "")
            {
                Page.Session["group"] = DropDownList_group.SelectedValue.Trim();

                string SQL = "select * from [ROYcms_TP_group] where id='" + DropDownList_group.SelectedValue.Trim() + "' ";
                DataSet dt = ROYcms.DB.SqlHelper.ExecuteDataSet(ROYcms.DB.SqlHelper.Conn, SQL);
                if (dt.Tables[0].Rows.Count > 0)
                {
                    Page.Session["group_type"] = dt.Tables[0].Rows[0]["group_type"].ToString().Trim();
                    Page.Session["group_name"] = dt.Tables[0].Rows[0]["group_name"].ToString().Trim();
                }
                BIND();
            }
            else
            {
                Page.Session["group"] = null;
                Page.Session["group_name"] = null;
                Page.Session["group_type"] = null;
            }
            Response.Redirect("ROYcms_TP.aspx");

        }
        protected void LinkButton_password_Click(object sender, EventArgs e)
        {
            XmlControl Config = new XmlControl(Server.MapPath(ConfigPath));

            if (password.Text.Trim() == Config.GetText("//TP_password"))
            {
                Page.Session["TP_admin"] = password.Text.Trim();
                //new ROYcms.Common.cooks().SaveCookie("TP_admin", password.Text.Trim(), 100000);
                ROYcms.Common.cooks.SaveCookie("TP_admin", password.Text.Trim(), 100000);
                Response.Redirect("ROYcms_TP.aspx");
            }
            else
            {
                Page.Session["TP_admin"] = null;
                MessageBox.Show(this, "密码错误！");
            }
        }

        ///
        ///
        //下面的方法属于 投票方法集合
        ///
        ///
        ///定义一个用于从数据库中检索投票者的IP
        private bool checkVoterIP()
        {
            //获取投票者IP
            bool flag = false;

            //开始检测IP
            string SQL = "select count(*) from [ROYcms_TP_ip] where ip = '" + userip + "' and tp_id='" + tp_id + "'";
            int result = Convert.ToInt32(SqlHelper.ExecuteScalar(SqlHelper.Conn, CommandType.Text, SQL, null));
            if (result > 0)
            {
                flag = true;
            }
            return flag;
        }
        //定义一个用于获取投票者上次投票的时间间隔
        private bool checkTime()
        {
            bool flag = false;

            //取出系统配置中限制时间间隔 秒
            string strSql = "select datediff(s,datetime,getdate()) from [ROYcms_TP_ip] where [ip] ='" + userip + "' and tp_id='" + tp_id + "'";
            long i = Convert.ToInt64(SqlHelper.ExecuteScalar(SqlHelper.Conn, CommandType.Text, strSql, null));//获取到距投票者上次投票的时间间隔

            if (i < TIME)
            {
                flag = true;
            }
            return flag;
        }
        public void tt()
        {
            if (tp_id != null)
            {
                SqlParameter[] myparm = new SqlParameter[1];
                myparm[0] = new SqlParameter("@id", SqlDbType.Int);
                myparm[0].Value = tp_id;
                string sql = "update [ROYcms_TP_date] set ballot=ballot+'1' where id=@id ";
                SqlHelper.ExecuteNonQuery(SqlHelper.Conn, CommandType.Text, sql, myparm);
                if (tp_id_z.Length == 1)
                {
                    MessageBox.ShowAndRedirect(this, "投票成功！", Redirect);
                    Response.Write("投票成功！");
                }
            }
        }
        public void addIP()
        {
            string sql = "insert into ROYcms_TP_ip(ip,tp_id) values('" + userip + "','" + tp_id + "')";
            SqlHelper.ExecuteNonQuery(SqlHelper.Conn, CommandType.Text, sql, null);
        }

        public void update_date()
        {
            SqlParameter[] myparm = new SqlParameter[1];
            myparm[0] = new SqlParameter("@t", SqlDbType.DateTime);
            myparm[0].Value = DateTime.Now.ToString();
            string sql = "update [ROYcms_TP_ip] set datetime=@t where ip= '" + userip + "' and tp_id='" + tp_id + "'";
            SqlHelper.ExecuteNonQuery(SqlHelper.Conn, CommandType.Text, sql, myparm);
        }








        /// <summary>
        /// 添加评论
        /// </summary>
        public void add_remark()
        {
            if (Request["remark_title"] != null && Request["remark_content"] != null)
            {
                string sql = "insert into [ROYcms_TP_remark] (pl_title,pl_content) values('" + Request["remark_title"] + "','" + Request["remark_content"] + "')";
                if (Request["remark_date_id"] != null)
                {
                    sql = "insert into [ROYcms_TP_remark] (pl_title,pl_content,date_id) values('" + Request["remark_title"] + "','" + Request["remark_content"] + "','" + Request["remark_date_id"] + "')";
                }
                if (Request["z_id"] != null)
                {
                    sql = "insert into [ROYcms_TP_remark] (pl_title,pl_content,z_id) values('" + Request["remark_title"] + "','" + Request["remark_content"] + "','" + Request["z_id"] + "')";
                }
                SqlHelper.ExecuteNonQuery(SqlHelper.Conn, CommandType.Text, sql, null);
                MessageBox.ShowAndRedirect(this, "评论成功！感谢您的参与！", Redirect);

                Response.Write("评论成功！感谢您的参与。");
            }
            else { MessageBox.ShowAndRedirect(this, "请填写完整的信息！", Redirect); Response.Write("请填写完整的信息。"); }

        }
        /// <summary>
        /// 删除评论
        /// </summary>
        private void remark_del()
        {
            string SQL = "delete [ROYcms_TP_remark] where id= '" + Request["id"] + "'";
            SqlHelper.ExecuteNonQuery(SqlHelper.Conn, CommandType.Text, SQL, null);
        }


        /// <summary>
        /// 编辑项目  数据绑定
        /// </summary>
        private void date_edit_bind()
        {

            string SQL = "select top 1 * from [ROYcms_TP_date] where id='" + Request["id"] + "' ";
            DataSet dt = ROYcms.DB.SqlHelper.ExecuteDataSet(ROYcms.DB.SqlHelper.Conn, SQL);
            if (dt.Tables[0].Rows.Count > 0)
            {
                edit_names.Text = dt.Tables[0].Rows[0]["names"].ToString().Trim();
                edit_characterization.Text = dt.Tables[0].Rows[0]["characterization"].ToString().Trim();
                edit_date_p.Text = dt.Tables[0].Rows[0]["ballot"].ToString().Trim();
                edit_date_img.Text = dt.Tables[0].Rows[0]["img_path"].ToString().Trim();
                edit_link_url.Text = dt.Tables[0].Rows[0]["link_url"].ToString().Trim();
            }
            string SQL2 = "select * from [ROYcms_TP_group] ";
            DropDownList_edit_date.DataSource = SqlHelper.ExecuteReader(SqlHelper.Conn, CommandType.Text, SQL2, null);
            DropDownList_edit_date.DataTextField = "group_name";
            DropDownList_edit_date.DataValueField = "id";
            DropDownList_edit_date.DataBind();
            DropDownList_edit_date.Items.Insert(0, new ListItem("◆请选择分组◆", ""));//插入空项，此举必须放到数据绑定之后
            if (dt.Tables[0].Rows[0]["z_id"] != null)
            {
                try
                {
                    DropDownList_edit_date.SelectedValue = dt.Tables[0].Rows[0]["z_id"].ToString().Trim();
                }
                catch { }
            }
        }
        /// <summary>
        /// 编辑组  数据绑定
        /// </summary>
        private void group_edit_bind()
        {

            string SQL = "select top 1 * from [ROYcms_TP_group] where id='" + Request["id"] + "' ";
            DataSet dt = ROYcms.DB.SqlHelper.ExecuteDataSet(ROYcms.DB.SqlHelper.Conn, SQL);
            if (dt.Tables[0].Rows.Count > 0)
            {
                edit_group_name.Text = dt.Tables[0].Rows[0]["group_name"].ToString().Trim();
                edit_group_content.Text = dt.Tables[0].Rows[0]["group_content"].ToString().Trim();
            }
        }
        /// <summary>
        /// 编辑组 事件
        /// </summary>
        protected void Button_edit_group_Click(object sender, EventArgs e)
        {
            string sql = "update [ROYcms_TP_group] set group_name='"
                + edit_group_name.Text.Trim() +
                "', group_content='"
                + edit_group_content.Text.Trim() +
                "' where id='"
                + Request["id"] +
                "'";
            SqlHelper.ExecuteNonQuery(SqlHelper.Conn, CommandType.Text, sql, null);
            group_edit_bind();
            BIND();

            MessageBox.ResponseScript(this, "TabbedPanels1.showPanel(5);alert('编辑组成功！');");

        }
        /// <summary>
        /// 编辑项目事件
        /// </summary>
        protected void Button_edit_date_Click(object sender, EventArgs e)
        {
            string sql = "update [ROYcms_TP_date] set names='"

                    + edit_names.Text.Trim() +
                    "', characterization='"
                    + edit_characterization.Text.Trim() +
                     "', ballot='"
                    + edit_date_p.Text.Trim() +
                     "', img_path='"
                    + edit_date_img.Text.Trim() +
                     "', link_url='"
                    + edit_link_url.Text.Trim() +
                     "', z_id='"
                    + DropDownList_edit_date.SelectedValue.Trim() +
                    "' where id='"
                    + Request["id"] +
                    "'";


            SqlHelper.ExecuteNonQuery(SqlHelper.Conn, CommandType.Text, sql, null);
            date_edit_bind();
            BIND();
            MessageBox.ResponseScript(this, "TabbedPanels1.showPanel(2);alert('编辑项目成功！');");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (DropDownList1.SelectedIndex)
            {
                case 0:
                    string SQL1 = "select * from [ROYcms_TP_remark] order by id DESC ";
                    Repeater_user_remark.DataSource = SqlHelper.ExecuteReader(SqlHelper.Conn, CommandType.Text, SQL1, null);
                    Repeater_user_remark.DataBind();
                    Repeater_user_remark.Visible = true;
                    Repeater_baoming.Visible = false;
                    break;
                case 1:
                    string SQL2 = "select * from [ROYcms_TP_remark] order by id DESC ";
                    Repeater_user_remark.DataSource = SqlHelper.ExecuteReader(SqlHelper.Conn, CommandType.Text, SQL2, null);
                    Repeater_user_remark.DataBind();
                    Repeater_user_remark.Visible = true;
                    Repeater_baoming.Visible = false;
                    break;
                //case 2:
                //    string SQL3 = "select * from [ROYcms_TP_baoming] where type='1' order by id DESC ";
                //    Repeater_baoming.DataSource = SqlHelper.ExecuteReader(SqlHelper.Conn, CommandType.Text, SQL3, null);
                //    Repeater_baoming.DataBind();
                //    break;
                default:
                    string SQL4 = "select * from [ROYcms_TP_remark] order by id DESC ";
                    Repeater_user_remark.DataSource = SqlHelper.ExecuteReader(SqlHelper.Conn, CommandType.Text, SQL4, null);
                    Repeater_user_remark.DataBind();
                    Repeater_user_remark.Visible = false;
                    Repeater_baoming.Visible = true;
                    break;
            }
            MessageBox.ResponseScript(this, "TabbedPanels1.showPanel(7);");
        }

        //public string copyright()
        //{
        //    //Config.ConfigType = (int)ConfigFileType.custom;
        //    //Config.ConfigPath = "~/App_Config/ROYcms_TP.config";
        //    //return Config.GetText("//copyright").ToString();

        //}
    }
}