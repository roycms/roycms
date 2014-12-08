using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.Administrator.CMSHelp
{
    public partial class InsertSynonyms : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_Synonyms Model = new ROYcms.Sys.Model.ROYcms_Synonyms();
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.BLL.ROYcms_Synonyms BLL = new ROYcms.Sys.BLL.ROYcms_Synonyms();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["id"] != null)
            {
                Model = BLL.GetModel(Convert.ToInt32(Request["id"]));
            }
        }
    }
}