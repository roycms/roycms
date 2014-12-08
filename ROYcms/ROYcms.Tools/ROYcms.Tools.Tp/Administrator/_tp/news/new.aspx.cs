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

namespace ROYcms.Tools.Tp.Administrator._tp
{
    public partial class _new : System.Web.UI.Page
    {
        public int id = 0;
        public string title = null;
        public string content = null;
        public string time = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request["id"]);
            new_show();
        }

        void new_show()
        {
            title = ROYcms.DB.DbHelpers.GetSingle("select title from [ROYcms_New] where id=" + id).ToString();
            content = ROYcms.DB.DbHelpers.GetSingle("select content from [ROYcms_New] where id=" + id).ToString();
            time = ROYcms.DB.DbHelpers.GetSingle("select time from [ROYcms_New] where id=" + id).ToString();
       
            string SQL1 = "select top 10 * from [ROYcms_New] where type=1 order by id desc ";
           
            Repeater_new1.DataSource = SqlHelper.ExecuteReader(SqlHelper.Conn, CommandType.Text, SQL1, null);
            Repeater_new1.DataBind();
         
        }
     
    }
}
