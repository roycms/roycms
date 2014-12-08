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
using System.IO;
using System.Data.SqlClient;
using System.Text;

namespace ROYcms.UI.Admin.Administrator.config
{    /// <summary>
    /// XML help?
    /// </summary>
    public partial class SQL :AdminPage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// //执行sql脚本 Executes the in file.
        /// </summary>
        /// <param name="ScriptText">The SQL con.</param>
        private void ExecuteInFile( string ScriptText)
        {
            SqlConnection sqlCon = new SqlConnection(ROYcms.DB.PubConstant.ConnectionString);
            string sqlString = ScriptText;
            //StreamReader reader = null;
            //if (!System.IO.File.Exists(pathToScriptFile))
            //{
            //    throw new Exception("文件" + pathToScriptFile + " 未找到!");
            //}
            //Stream stream = System.IO.File.OpenRead(pathToScriptFile);
            //reader = new StreamReader(stream);
            SqlCommand command = new SqlCommand();
            try
            {
                sqlCon.Open();
            }
            catch
            {
               // Errors.Text = "连接打开失败，请检查连接字符串是否正确。";
                return;
            }

            command.Connection = sqlCon;
            command.CommandType = System.Data.CommandType.Text;
            //while (null != (sqlString = ReadNextFromStream(reader)))
            //{
                command.CommandText = sqlString;
                command.ExecuteNonQuery();
            //}
            //reader.Close();
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button_star_Click(object sender, EventArgs e)
        {
            ExecuteInFile(TextBox_SQL.Text);
        }
    }
}
