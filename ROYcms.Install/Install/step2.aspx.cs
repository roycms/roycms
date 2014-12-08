using System;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Web.UI;
using ROYcms.Common;
namespace ROYcms.Install
{
    /// <summary>
    /// step2  类
    /// </summary>
    public partial class Install_step2 : System.Web.UI.Page
    {
        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            InstallNow.Click += new EventHandler(InstallNow_Click);
            if (!IsPostBack)
                DBCreated.Checked = true;
        }

        /// <summary>
        /// Handles the Click event of the InstallNow control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void InstallNow_Click(object sender, EventArgs e)
        {
            //创建链接
            String connectionString = string.Format("server={0};uid={1};pwd={2};Trusted_Connection=no;database={3}", DBServerIP.Text, DBOwner.Text, DBOwenerPassWord.Text, DBName.Text);
            SqlConnection sqlConnection = GetSqlConnection(connectionString);

            if (sqlConnection == null)
            {
                Errors.Text = "创建连接失败";
                return;
            }

            #region 数据库

            bool emptyDBCreated = false;
            // 首先创建数据库

            #region 创建空数据库

            //是否需要自动创建数据库
            if (DBCreated.Checked)
            {
                //数据库已经创建
                emptyDBCreated = true;
            }
            else
            {
                //数据库为创建需要，程序自动创建
                //创建空数据库
                //构建连接字符串
                string connectionStr = string.Format("Data Source={0};User ID={1};Password={2};Initial Catalog=master;Pooling=true ", DBServerIP.Text, DBOwner.Text, DBOwenerPassWord.Text);
                SqlConnection sqlCon = GetSqlConnection(connectionStr);
                if (sqlCon != null)
                {
                    string createDateBase = string.Format(" create database {0} ", DBName.Text);
                    SqlCommand createDBCommand = new SqlCommand(createDateBase, sqlCon);

                    //创建空数据库
                    try
                    {
                        createDBCommand.Connection.Open();
                        createDBCommand.ExecuteNonQuery();
                        sqlCon.Close();
                        emptyDBCreated = true;
                    }
                    catch
                    {
                        Errors.Text = "创建数据库失败";
                        //创建数据库失败
                        emptyDBCreated = false;
                        return;
                    }
                }
            }
            #endregion

            #region 执行脚本

            //如果空数据库创建完成，那么创建数据库表，初始化数据
            if (emptyDBCreated)
            {

                if (sqlConnection != null)
                {
                    //执行脚本 ROYcms.xml 完成数据库框架
                    try { ExecuteInFile(sqlConnection, Server.MapPath("~/Install/SqlScripts/ROYcms.xml")); }
                    catch
                    {
                        Errors.Text = "在文件：" + Server.MapPath("~/Install/SqlScripts/ROYcms.xml") + " 中产生异常。"; return;
                    }

                    //执行脚本ROYcms.Data.xml 初始化数据
                    //try { ExecuteInFile(sqlConnection, Server.MapPath("~/Install/SqlScripts/ROYcms.Data.xml")); }
                    //catch { Errors.Text = "在文件：" + Server.MapPath("~/Install/SqlScripts/ROYcms.Data.xml") + " 中产生异常。"; return; }

                    //创建管理员
                    string createSiteAdmin = string.Format("INSERT  [ROYcms_Admin] ([name],[password],[Rol]) VALUES ( 'admin','{0}',0)",SiteAdminPassword.Text);
                    SqlCommand createSiteAdminCommand = new SqlCommand(createSiteAdmin, sqlConnection);

                    try
                    {
                        createSiteAdminCommand.Connection.Open();
                        createSiteAdminCommand.ExecuteNonQuery();
                        sqlConnection.Close();
                    }
                    catch
                    {
                        //创建站点管理员失败
                        Errors.Text = "创建管理员失败";
                        return;
                    }
                }
            }

            #endregion

            #endregion

            #region 编辑web.config

            //修改web.config文件
            try { SetWebConfig(connectionString); }
            catch { Errors.Text = "数据库安装成功，修改web.config 失败"; return; }


            #endregion

            Page.Response.Redirect("~/Install/Succeed.aspx");
        }

        #region 工具方法

        //获取链接
        /// <summary>
        /// Gets the SQL connection.
        /// </summary>
        /// <param name="ConnectionString">The connection string.</param>
        /// <returns></returns>
        private SqlConnection GetSqlConnection(string ConnectionString)
        {
            try
            {
                return new SqlConnection(ConnectionString);
            }
            catch
            {
                return null;
            }
        }

        
        /// <summary>
        /// //执行sql脚本 Executes the in file.
        /// </summary>
        /// <param name="sqlCon">The SQL con.</param>
        /// <param name="pathToScriptFile">The path to script file.</param>
        private void ExecuteInFile(SqlConnection sqlCon, string pathToScriptFile)
        {
            string sqlString = "";
            StreamReader reader = null;
            if (!System.IO.File.Exists(pathToScriptFile))
            {
                throw new Exception("文件" + pathToScriptFile + " 未找到!");
            }
            Stream stream = System.IO.File.OpenRead(pathToScriptFile);
            reader = new StreamReader(stream);
            SqlCommand command = new SqlCommand();
            try
            {
                sqlCon.Open();
            }
            catch
            {
                Errors.Text = "连接打开失败，请检查连接字符串是否正确。";
                return;
            }

            command.Connection = sqlCon;
            command.CommandType = System.Data.CommandType.Text;
            while (null != (sqlString = ReadNextFromStream(reader)))
            {
                command.CommandText = sqlString;
                command.ExecuteNonQuery();
            }
            reader.Close();
            sqlCon.Close();
        }

        
        /// <summary>
        /// //读取文件中的下一行 Reads the next from stream.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns></returns>
        private string ReadNextFromStream(StreamReader reader)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string textLine;
            while (true)
            {
                textLine = reader.ReadLine();
                if (textLine == null)
                {
                    if (stringBuilder.Length > 0)
                    {
                        return stringBuilder.ToString();
                    }
                    else
                    {
                        return null;
                    }
                }
                if (textLine.TrimEnd().ToUpper() == "GO")
                {
                    break;
                }
                stringBuilder.AppendFormat("{0}\r\n", textLine);
            }
            return stringBuilder.ToString();
        }

       
        /// <summary>
        ///  //设置web.config Sets the web config.
        /// </summary>
        /// <param name="ConnectionString">The connection string.</param>
        private void SetWebConfig(string ConnectionString)
        {

            ReadWriteConfig Config = new ReadWriteConfig();
            try
            {
                Config.ConfigType = (int)ConfigFileType.WebConfig;
               
                Config.connectionStrings_modifyElement("ConnectionString",ROYcms.Common.DESEncrypt.Encrypt(ConnectionString));
            }
            catch
            {
                throw new Exception("修改 web.config 时出错");
            }
        }
        #endregion
    }
}