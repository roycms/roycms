using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.Administrator.go
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Add_objet : AdminPage
    {
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_Objet Model = new ROYcms.Sys.Model.ROYcms_Objet();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["id"] != null) { 
                Model = ___ROYcms_Objet_bll.GetModel(Convert.ToInt32(Request["id"])); 
                
            }

           
            //else { Model.Title = "11111111"; }
            
           
        }
    }
}
