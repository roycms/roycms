using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ROYcms.UI.Admin;

namespace ROYcms.UCenter
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Flash : UserPage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { 
                Bind();
                if (Request["del"] != null) { ___ROYcms_Flash_bll.Delete(Convert.ToInt32(Request["del"])); Bind(); }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        void Bind()
        {
            Repeater_list.DataSource = ___ROYcms_Flash_bll.GetList("id>0 order by id desc ");
            Repeater_list.DataBind();
            Repeater_MyList.DataSource = ___ROYcms_Flash_bll.GetList("user_id=" + ROYcms.Common.Session.Get("user_id"));
            Repeater_MyList.DataBind();
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button_ADDflash_Click(object sender, EventArgs e)
        {
            int User_Id = int.Parse(ROYcms.Common.Session.Get("user_id"));
            string title = this.TextBox_flash_title.Text;
            DateTime Time = DateTime.Now;
            ___ROYcms_Flash_model.User_Id = User_Id;
            ___ROYcms_Flash_model.title = title;
            ___ROYcms_Flash_model.Time = Time;
            ___ROYcms_Flash_bll.Add(___ROYcms_Flash_model);
            //从新绑定一下
            Bind();
        }
    }
}
