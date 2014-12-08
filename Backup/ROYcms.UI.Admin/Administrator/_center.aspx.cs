/**********************************************************************************
 * Description:     
 * MemberVariable:
 * Functions:       
 * Modify information:     
 * 2008-8-5     New           DuYaoHui     Create Class
 * 
 * ********************************************************************************/
using System;

using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
namespace ROYcms.UI.Admin
{
    /// <summary>
    /// 
    /// </summary>
    public partial class admin_admin_center : AdminPage
    {
        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {

            String serverOS = Environment.OSVersion.ToString();
            String CpuSum = Environment.GetEnvironmentVariable("NUMBER_OF_PROCESSORS");         // CPU个数：
            String CpuType = Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER");        // CPU类型：
            String ServerSoft = Request.ServerVariables["SERVER_SOFTWARE"];                     // 信息服务软件：
            String MachineName = Server.MachineName;                                            // 服务器名
            String ServerName = Request.ServerVariables["SERVER_NAME"];                         // 服务器域名
            String ServerPath = Request.ServerVariables["APPL_PHYSICAL_PATH"];                  // 虚拟服务绝对路径
            String ServerNet = ".NET CLR " + Environment.Version.ToString();                    // DotNET 版本
            String ServerArea = (DateTime.Now - DateTime.UtcNow).TotalHours > 0 ? "+" + (DateTime.Now - DateTime.UtcNow).TotalHours.ToString() : (DateTime.Now - DateTime.UtcNow).TotalHours.ToString();    // 服务器时区
            //    String ServerTimeOut = Server.ScriptTimeout.ToString();                             // 脚本超时时间
            String ServerStart = ((Double)System.Environment.TickCount / 3600000).ToString("N2");   // 开机运行时长
            // AspNet CPU时间
            String ServerSessions = Session.Contents.Count.ToString();                          // Session总数
            String ServerApp = Application.Contents.Count.ToString();                           // Application总数
            String ServerCache = Cache.Count.ToString();                                        //应用程序缓存总数
            String ServerTimeOut = Server.ScriptTimeout.ToString() + "毫秒";


            Label2.Text = MachineName;
            Label3.Text = ServerName;
            Label4.Text = ServerPath;
            Label5.Text = ServerNet;
            Label6.Text = ServerApp;
            Label8.Text = CpuSum;
            Label9.Text = ServerStart;
            Label10.Text = ServerCache;


            Label001.Text = new ROYcms.Sys.BLL.ROYcms_news().GetCount("").ToString();
            Label002.Text = (new ROYcms.Sys.BLL.ROYcms_news().GetCount("")).ToString();
            Label003.Text = new ROYcms.Sys.BLL.ROYcms_news().GetCount(" switchs = 0 ").ToString();
            Label004.Text = new ROYcms.Sys.BLL.ROYcms_user().GetCount("").ToString();
            //Label005.Text = (new ROYcms.Sys.BLL.ROYcms_user().GetCount("")-26).ToString();
            //Label006.Text = "新闻|企业|商铺|会员";
            Label007.Text = (new ROYcms.Sys.BLL.ROYcms_news().GetCount(" time > '"+DateTime.Now.ToString()+"'")/10).ToString();
        }

    }
}