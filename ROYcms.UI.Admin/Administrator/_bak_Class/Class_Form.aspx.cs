using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin
{
    /// <summary>
    /// 
    /// </summary>
	public partial class Class_Form : AdminPage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind();
                if (Request["del"] != null) 
                {
                    ___ROYcms_Form_class_classkind_bll.class_id_Delete(Convert.ToInt32(Request["del"]));
                    Response.Redirect("/administrator/class/index.aspx?classkind="+Request["classkind"]);
                }
                else
                {
                    Add(); 
                }
            }
        }
        /// <summary>
        /// Binds this instance.
        /// </summary>
        void Bind()
        {
            Repeater_admin.DataSource = ___ROYcms_Form_bll.GetAllList();
            Repeater_admin.DataBind();
        }
        /// <summary>
        /// 
        /// </summary>
        protected void Add()
        {
            if (Request["From_id"] != null)
            {
                int From_id = int.Parse(Request["From_id"]);
                string From_GUID = Request["From_GUID"];
                int class_id = int.Parse(Request["class_id"]);
                int classkind_id = int.Parse(Request["classkind_id"] == null ? "0" : Request["classkind_id"]);
                DateTime Time = DateTime.Now;

                if (!___ROYcms_Form_class_classkind_bll.class_id_Exists(class_id))
                {
                    ___ROYcms_Form_class_classkind_model.From_id = From_id;
                    ___ROYcms_Form_class_classkind_model.From_GUID = From_GUID;
                    ___ROYcms_Form_class_classkind_model.class_id = class_id;
                    ___ROYcms_Form_class_classkind_model.classkind_id = classkind_id;
                    ___ROYcms_Form_class_classkind_model.Time = Time;

                    ___ROYcms_Form_class_classkind_bll.Add(___ROYcms_Form_class_classkind_model);
                }
                else
                {
                    ___ROYcms_Form_class_classkind_model.From_id = From_id;
                    ___ROYcms_Form_class_classkind_model.From_GUID = From_GUID;
                    ___ROYcms_Form_class_classkind_model.class_id = class_id;
                    ___ROYcms_Form_class_classkind_model.classkind_id = classkind_id;
                    ___ROYcms_Form_class_classkind_model.Time = Time;

                    ___ROYcms_Form_class_classkind_bll.class_id_Update(___ROYcms_Form_class_classkind_model);
                }

                Response.Redirect("/administrator/class/index.aspx?classkind=" + Request["classkind"]);
            }

        }
	}
}
