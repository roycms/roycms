using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;

namespace ROYcms.UI.Admin
{
    /// <summary>
    /// 创建人：杜耀辉
    /// 创建时间：2009年8月1日
    /// 功能描述：实现数据库的备份和还原
    /// 更新记录：
    /// </summary>
    public partial class SqlManagement_DbBackup : AdminPage
    {
        /// <summary>
        /// 服务器
        /// </summary>
        private string _server;

        /// <summary>
        /// 登录名
        /// </summary>
        private string _uid;

        /// <summary>
        /// 登录密码
        /// </summary>
        private string _pwd;

        /// <summary>
        /// 要操作的数据库
        /// </summary>
        private string _database;

        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        private string _conn;
        /// <summary>
        /// 
        /// </summary>
        private string _path;
        /// <summary>
        /// 
        /// </summary>
        public string server
        {
            set { _server = value; }
            get { return _server; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string uid
        {
            set { _uid = value; }
            get { return _uid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string path
        {
            set { _path = value; }
            get { return _path; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string conn
        {
            set { _conn = value; }
            get { return _conn; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pwd
        {
            set { _pwd = value; }
            get { return _pwd; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string database
        {
            set { _database = value; }
            get { return _database; }
        }

        /// <summary>
        /// DbBackup类的构造函数
        /// 在这里进行字符串的切割，获取服务器，登录名，密码，数据库
        /// </summary>
        public SqlManagement_DbBackup()
        {
           // conn = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            conn = ROYcms.DB.PubConstant.ConnectionString;
            server = StringCut(conn, "Source=", ";");
            uid = StringCut(conn, "ID=", ";");
            pwd = StringCut(conn, "Password=", ";");
            database = StringCut(conn, "Catalog=", ";");

            string CurrTime = System.DateTime.Now.ToString();
            CurrTime = CurrTime.Replace("-", "_");
            CurrTime = CurrTime.Replace(":", "_");
            CurrTime = CurrTime.Replace(" ", "_");
            CurrTime = CurrTime.Substring(0, 12);
            path = "~/App_Data/BAK/";
            path += database;
            path += "_db_";
            path += CurrTime;
            path += ".BAK";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BAK_BOX.Text = path;
                BAK_name.Text = "BAK备份名称" + System.DateTime.Now.ToString();
            }     
        }
        /**/
        /// <summary>
        /// 构造文件名
        /// </summary>
        /// <returns>文件名</returns>
        public string CreatePath()
        {
            return HttpContext.Current.Server.MapPath(path).ToString();
        }
        /// <summary>
        /// 切割字符串
        /// </summary>
        /// <param name="str"></param>
        /// <param name="bg"></param>
        /// <param name="ed"></param>
        /// <returns></returns>
        public string StringCut(string str, string bg, string ed)
        {
            string sub;
            sub = str.Substring(str.IndexOf(bg) + bg.Length);
            sub = sub.Substring(0, sub.IndexOf(";"));
            return sub;
        }

        /**/
        /// <summary>
        /// 数据库备份
        /// </summary>
        /// <returns>备份是否成功</returns>
        public bool DbBackup()
        {
            string path = CreatePath();
            SQLDMO.Backup oBackup = new SQLDMO.BackupClass();
            SQLDMO.SQLServer oSQLServer = new SQLDMO.SQLServerClass();
            try
            {
                oSQLServer.LoginSecure = false;
                oSQLServer.Connect(server, uid, pwd);
                oBackup.Action = SQLDMO.SQLDMO_BACKUP_TYPE.SQLDMOBackup_Database;
                oBackup.Database = database;
                oBackup.Files = path;
                oBackup.BackupSetName = database;
                oBackup.BackupSetDescription = "数据库备份";
                oBackup.Initialize = true;
                oBackup.SQLBackup(oSQLServer);

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
            finally
            {
                oSQLServer.DisConnect();
            }
        }

        /// <summary>
        /// 数据库恢复
        /// </summary>
        /// <returns></returns>
        public string DbRestore()
        {
            if (exepro() != true)//执行存储过程
            {
                return "操作失败";
            }
            else
            {
                SQLDMO.Restore oRestore = new SQLDMO.RestoreClass();
                SQLDMO.SQLServer oSQLServer = new SQLDMO.SQLServerClass();
                try
                {
                    exepro();
                    oSQLServer.LoginSecure = false;
                    oSQLServer.Connect(server, uid, pwd);
                    oRestore.Action = SQLDMO.SQLDMO_RESTORE_TYPE.SQLDMORestore_Database;
                    oRestore.Database = database;
                    //自行修改
                    oRestore.Files = Server.MapPath(DropDownList_path.SelectedValue.Trim());
                    oRestore.FileNumber = 1;
                    oRestore.ReplaceDatabase = true;
                    oRestore.SQLRestore(oSQLServer);

                    return "ok 恢复成功！";
                }
                catch (Exception e)
                {
                    return "恢复数据库失败";
                    throw e;
                }
                finally
                {
                    oSQLServer.DisConnect();
                }
            }
        }

        /**/
        /// <summary>
        /// 杀死当前库的所有进程
        /// </summary>
        /// <returns></returns>
        private bool exepro()
        {

            SqlConnection conn1 = new SqlConnection("server=" + server + ";uid=" + uid + ";pwd=" + pwd + ";database=master");
            SqlCommand cmd = new SqlCommand("killspid", conn1);
            cmd.CommandType = CommandType.StoredProcedure;
          //  cmd.Parameters.Add("@dbname", database);
            try
            {
                conn1.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch 
            {
                return false;
            }
            finally
            {
                conn1.Close();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void wbtn_Backup_Click(object sender, EventArgs e)
        {
            SqlManagement_DbBackup dbop = new SqlManagement_DbBackup();
            if (dbop.DbBackup()) 
            { 
                Response.Write("成功！");
                new ROYcms.Common.XmlControl(Server.MapPath("~/administrator/app_Config/DbBackup.xml")).InsertElement("Db", "File", "Time,name,path", System.DateTime.Now.ToString() + "," + BAK_name.Text.Trim() + "," + BAK_BOX.Text.Trim());

            }
            else { Response.Write("备份失败！"); }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button_huanyuan_Click(object sender, EventArgs e)
        {
            Response.Write(DbRestore());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button_daochu_Click(object sender, EventArgs e)
        {

        }
    }
}