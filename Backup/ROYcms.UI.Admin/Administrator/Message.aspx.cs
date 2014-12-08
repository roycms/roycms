/**********************************************************************************
 * Description:     
 * MemberVariable:
 * Functions:       
 * Modify information:     
 * 2008-8-5     New           DuYaoHui     Create Class
 * 
 * ********************************************************************************/
using System;

namespace ROYcms.UI.Admin
{
    /// <summary>
    /// 信息中心类
    /// </summary>
    public partial class Administrator_Message : AdminPage
    {
        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["z"] != null && Request["message"] != null && Request.UrlReferrer != null)
            {
                string z = Request["z"];
                string message = Request["message"];
                if (z.Trim() == "yes" || z.Trim() == "no" || z.Trim() == "what")
                {
                    image_mes.ImageUrl = "/administrator/images/" + z.Trim() + ".png";
                    if (z.Trim() == "no")
                    {
                        Label_z.Text = "系统异常！";
                    }
                }
                else { image_mes.ImageUrl = "/administrator/images/what.png"; Label_z.Text = "未知操作！"; }
                Label_message.Text = message;
                //上一页 地址
                string host = Request.UrlReferrer.ToString();
                HyperLink_url.Text = host;
                HyperLink_url.NavigateUrl = host;
                HyperLink_host.NavigateUrl = host;
                if (Request["new"] != null)
                {
                    //分组新闻
                    string[] news = Request["new"].Split(',');
                    if (news.Length > 1) { New_group.Text = string.Format("<a href='/administrator/objet/Insert.aspx?ClassKind={0}&Class={1}&newid={2}'>分组信息，录入第二页信息</a>", news[1], news[2], news[3]); }
                }
            }
            Label_message.Text = Request["message"];
        }
    }
}