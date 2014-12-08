using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.Common
{
   public class DataSetToExcel
    {
       public static void ToExcel(DataSet oDS, HttpResponse Response, string fileName)
        {
            if (oDS == null || oDS.Tables[0] == null || oDS.Tables[0].Rows.Count == 0) { return; }
            Response.Clear();
            //Encoding pageEncode = Encoding.GetEncoding(PageEncode);
            HttpContext.Current.Response.Charset = "gb2312";
            //Response.ContentType = "application/vnd-excel";//"application/vnd.ms-excel";
            //Response.ContentType = "application/x-octet-stream";//"application/vnd.ms-excel";
            Response.ContentType = "text/csv";//"application/vnd.ms-excel";
            Response.AppendHeader("Content-Disposition", "attachment;filename=" + fileName + ".cvs");
            System.IO.StringWriter oSW = new System.IO.StringWriter();
            HtmlTextWriter oHW = new HtmlTextWriter(oSW);
            DataGrid dg = new DataGrid();
            dg.DataSource = oDS.Tables[0];
            dg.DataBind();
            dg.RenderControl(oHW);
            Response.Write(oSW.ToString());
            Response.Flush();
            Response.Close();
        }
    }
}
