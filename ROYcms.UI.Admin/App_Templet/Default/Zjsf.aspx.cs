using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.App_Templet.Default
{
    public partial class Zjsf : System.Web.UI.Page
    {
        //public ClassLibrary1.SearchInf getZS = new ClassLibrary1.SearchInf();
        protected void Page_Load(object sender, EventArgs e)
        {
     
        }
        /// <summary>
        /// 授权
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button_get_Click(object sender, EventArgs e)
        {
            //if (getsu())
            //{
            //    ROYcms.Common.Session.Add("Zname", this.username.Text);
            //}
            //else { ROYcms.Common.MessageBox.Show(this,"身份验证错误"); }
        }
        /// <summary>
        /// 获得权限方法
        /// </summary>
        /// <returns></returns>
        //public bool getsu() { 
        //    string District = this.quyu.SelectedValue;
        //    string username = this.username.Text;
        //    string password = this.password.Text;
        //    return getZS.UserLogin(District, username, password);
        
        //}
        /// <summary>
        /// 查询结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button_getval_Click(object sender, EventArgs e)
        {
            //if (ROYcms.Common.Session.Get("Zname") != null)
            //{
            //    string userID = ROYcms.Common.Session.Get("Zname");
            //    string starTime = this.starTime.Text;
            //    string endTime = this.endTime.Text;
            //    DataTable dt = new DataTable();
            //    getZS.GetExpenses(userID, starTime, endTime, ref dt);
               
            //    Repeater_list.DataSource = dt;
            //    Repeater_list.DataBind();
            //}
        }
    }
}