using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.Administrator.DNS
{
    public partial class SetUserGrade : ROYcms.AdminPage
    {
        public ROYcms.Sys.BLL.ROYcms_UserInfo Bll = new ROYcms.Sys.BLL.ROYcms_UserInfo();
        public ROYcms.Sys.Model.ROYcms_UserInfo Model = new ROYcms.Sys.Model.ROYcms_UserInfo();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["UserId"] = ROYcms.Common.Request.GetQueryInt("UserId");
                Grade_bind();

            }
        }

        /// <summary>
        /// 
        /// </summary>
        void Grade_bind()
        {
            ROYcms.Sys.BLL.ROYcms_UserGrade bll = new ROYcms.Sys.BLL.ROYcms_UserGrade();
            this.txtGradeID.Items.Add(new ListItem("选择会员等级", ""));
            DataSet ds = bll.GetAllList();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                string Id = dr["Id"].ToString().Trim();
                string Name = dr["GradeName"].ToString().Trim();
                this.txtGradeID.Items.Add(new ListItem(Name, Id));
            }

            int UserId = Convert.ToInt32(ViewState["UserId"]);
            int GradeID = Bll.GetModel_(UserId) == null ? 0 : Bll.GetModel_(UserId).GradeID;
            if (GradeID > 0) { this.txtGradeID.SelectedValue = GradeID.ToString(); }
            else { this.txtGradeID.SelectedValue = ""; }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtGradeID.SelectedValue != "")
            {
                if (setGrade(Convert.ToInt32(ViewState["UserId"]), Convert.ToInt32(this.txtGradeID.SelectedValue)))
                {
                    Response.Redirect("/Administrator/ucenter/User.aspx");
                }
            }
            else { Response.Redirect("/Administrator/ucenter/User.aspx"); }
        }
        /// <summary>
        /// 设置等级
        /// </summary>
        /// <param name="id"></param>
        /// <param name="GradeID"></param>
        /// <returns></returns>
        public bool setGrade(int id, int GradeID)
        {
            Model = Bll.GetModel_(id);
            Model.GradeID = GradeID;

            return Bll.Update(Model);
        }
        /// <summary>
        /// 获得等级
        /// </summary>
        /// <returns></returns>
        public string getGrade()
        {
            int UserId = Convert.ToInt32(ViewState["UserId"]);

            int GradeID = Bll.GetModel_(UserId) == null ? 0 : Bll.GetModel_(UserId).GradeID;
            ROYcms.Sys.BLL.ROYcms_UserGrade bll = new ROYcms.Sys.BLL.ROYcms_UserGrade();

            if (GradeID > 0)
            {
                return bll.GetModel(GradeID) == null ? "" : bll.GetModel(GradeID).GradeName;
            }
            else { return ""; }
        }
    }
}