using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = ExcelDataSource(Server.MapPath("name.xls"), "name");

            string email = "";
            string content = "";

            if (ds.Tables[0].Rows.Count > 0)
            {
                email += ds.Tables[0].Rows[0].ItemArray[0].ToString();
                content += ds.Tables[0].Rows[0].ItemArray[1].ToString();
            }
            Response.Write(email + content);
          
        }
        /// <summary>
        /// 获得Excel中的所有sheetname。
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public ArrayList ExcelSheetName ( string filepath )
        {
            ArrayList al = new ArrayList ();
            string strConn;
            strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=;Extended Properties=Excel 8.0;";
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open ();
            DataTable sheetNames = conn.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables,new object[]{null,null,null,"TABLE"});
            conn.Close ();
            foreach ( DataRow dr in sheetNames.Rows )
            {
                al.Add ( dr[2] );
            }
            return al;
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