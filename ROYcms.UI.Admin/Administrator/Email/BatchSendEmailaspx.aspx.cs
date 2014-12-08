using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.Administrator.Email
{
    public partial class BatchSendEmailaspx :ROYcms.AdminPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 导入邮件按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button_add_email_Click(object sender, EventArgs e)
        {
            FileUpload_index.PostedFile.SaveAs(Server.MapPath("/App_Templet/SystemTemplate/email_index.xls"));
            ROYcms.Common.MessageBox.Show(this,"导入成功可以点击发送按钮直接发送了");
        }
        /// <summary>
        /// 发送邮件按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button_send_mail_Click(object sender, EventArgs e)
        {
            DataSet ds = ExcelDataSource(Server.MapPath("/App_Templet/SystemTemplate/email_index.xls"), "name");
            string email = "";
            string title = "";
            string content = "";
            for(int i=0;i<ds.Tables[0].Rows.Count;i++)
            {
                email += ds.Tables[0].Rows[i].ItemArray[0].ToString();
                title += ds.Tables[0].Rows[i].ItemArray[1].ToString();
                content += ds.Tables[0].Rows[i].ItemArray[2].ToString();

                ROYcms.Common.SystemCms.SendMail(title, content, email);
            }
        }
           /// <summary>
        /// 该方法实现从Excel中导出数据到DataSet中，其中filepath为Excel文件的绝对路径，sheetname为表示那个Excel表；
        /// </summary>
        /// <param name="filepath"></param>
        /// <param name="sheetname"></param>
        /// <returns></returns>
        public DataSet ExcelDataSource(string filepath, string sheetname)
        {
            string strConn;
            strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filepath + ";Extended Properties=Excel 8.0;";
            OleDbConnection conn = new OleDbConnection(strConn);
            OleDbDataAdapter oada = new OleDbDataAdapter("select * from [" + sheetname + "$]", strConn);
            DataSet ds = new DataSet();
            oada.Fill(ds);
            return ds;
        }
    }
}