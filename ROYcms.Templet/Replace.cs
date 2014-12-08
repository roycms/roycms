using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Data;

namespace ROYcms.Templet
{
    /// <summary>
    /// 
    /// </summary>
    public class Replace
    {
        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <param name="content">The content.</param>
        /// <returns></returns>
        public static string Replaces(string content)
        {
            string CON = content;
            string filepath = HttpContext.Current.Server.MapPath("~/APP_data/tag/10.xml");

            //DataSet DS = new DataSet();
            //DS.ReadXml(filepath);
            //DataTable dt = new ROYcms.Common.XmlControl(filepath).GetDataTable("Root/Tag/");
            //DataTable dt = DS.Tables[0];
            //for (int i = 0; i < dt.Rows.Count;i++ ) 
            //{
            //    string str = CON;
            //    str = str.Replace(dt.Rows[i]["keyword"].ToString(), "<a href='/Search.ashx?keyword=" + dt.Rows[i]["keyword"].ToString() + "'>" + dt.Rows[i]["keyword"].ToString() + "</a>");
            //    CON = str;
            //}
            //foreach (DataRow[] dr in dt.Rows)
            //{
            //    string str = CON;
            //    str = str.Replace(dr[0]["keyword"].ToString(), "<a href='/Search.ashx?keyword=" + dr[0]["keyword"].ToString() + "'>" + dr["keyword"].ToString() + "</a>");
            //    CON = str;
            //}
            return CON;
        }
    }
}
