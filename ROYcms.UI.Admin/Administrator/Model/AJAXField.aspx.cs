using System;

namespace ROYcms.UI.Admin.Administrator.Model
{
    /// <summary>
    /// AJAXField
    /// </summary>
    public partial class AJAXField : ROYcms.AdminPage
    {
        /// <summary>
        /// ROYcms_Field
        /// </summary>
        public ROYcms.Sys.BLL.ROYcms_Field Bll = new ROYcms.Sys.BLL.ROYcms_Field();
        /// <summary>
        /// Page_Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["Del"] != null) //删除操作
            {
                bool E = ___ROYcms_Field_bll.Delete(Convert.ToInt32(Request["Del"]));
                Response.ContentType = "text/plain";
                Response.Write(E == true ? 1 : 0);
            }
            else if (Request["Order"] != null && Request["PId"] != null) //排序操作
            {
                string[] PId = Request["PId"].Replace("undefined,", "").Split(',');
                string[] Order = Request["Order"].Replace("undefined,", "").Split(',');

                if (PId.Length == Order.Length)
                {
                    bool E = false;
                    for (int i = 0; i < PId.Length; i++)
                    {
                        E = Bll.UpdateOrderBy(Convert.ToInt32(PId[i]), Convert.ToInt32(Order[i]));
                    }

                    Response.ContentType = "text/plain";
                    Response.Write(E == true ? 1 : 0);
                   
                }
            }

        }
    }
}
