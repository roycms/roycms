using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.Administrator.Config
{
    public partial class AdminRol : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["Id"] = Request["Id"];
                //ViewState["ClassId"] = Request["ClassId"];
                //ViewState["ClassKind"] = Request["ClassKind"];

                SysAdminBind();

                Repeater_Objet.DataSource = new ROYcms.Sys.BLL.ROYcms_Objet().GetAllList();
                Repeater_Objet.DataBind();
                //绑定数据
                ROYcms.UI.Admin.Administrator.AdminMap.index Index = new AdminMap.index();
                Repeater_admin.DataSource = Index.BLL.GetAllList();
                Repeater_admin.DataBind();
            }
        }
        /// <summary>
        /// 系统管理(超级管理员)(管理员)
        /// </summary>
        public void SysAdminBind()
        {

            ROYcms.Sys.BLL.ROYcms_Jurisdiction Bll = new Sys.BLL.ROYcms_Jurisdiction();
            ROYcms.Sys.Model.ROYcms_Jurisdiction Model = new Sys.Model.ROYcms_Jurisdiction();

            int AdminId = Convert.ToInt32(Request["Id"]);
            int ClassID = Convert.ToInt32(ViewState["ClassId"]);
            //存在数据则 true  否则 false     A001-A019
            for (int i = 1; i < 20; ++i)
            {
                if (Bll.GetList(" JID='" + "A" + i.ToString() + "' AND AdminID=" + AdminId + " AND ClassID=" + ClassID).Tables[0].Rows.Count > 0)
                {
                    CheckBox Checkboxs = (CheckBox)Page.Form.FindControl("A" + i.ToString());
                    Checkboxs.Checked = true;
                }
                else {
                    CheckBox Checkboxs = (CheckBox)Page.Form.FindControl("A" + i.ToString());
                    Checkboxs.Checked = false;
                }
            }

        }
        /// <summary>
        /// 权限发生更改时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void A_CheckedChanged(object sender, EventArgs e)
        {  
            
            ROYcms.Sys.BLL.ROYcms_Jurisdiction Bll = new Sys.BLL.ROYcms_Jurisdiction();
            ROYcms.Sys.Model.ROYcms_Jurisdiction Model = new Sys.Model.ROYcms_Jurisdiction();

           // int AdminId = Convert.ToInt32(ROYcms.Common.Session.Get("administrator_id"));
            int AdminId = Convert.ToInt32(Request["Id"]);
            String JID = ((CheckBox)sender).ID; //获取权限标识ID
            if (((CheckBox)sender).Checked)
            {
                //判断 该权限是否存在
                if (Bll.GetList(" JID='" + JID + "' AND AdminID=" + AdminId).Tables[0].Rows.Count < 1)
                { //

                    Model.AdminID = AdminId;
                    Model.ClassID = 0;
                    Model.ClassKind = "0";
                    Model.JID = JID;
                    Model.CreateTime = DateTime.Now;

                    Bll.Add(Model);
                }

            }
            else
            {
                if (Bll.GetList(" JID='" + JID + "' AND AdminID=" + AdminId).Tables[0].Rows.Count > 0)
                {
                    int Id = Convert.ToInt32(Bll.GetList(" JID='" + JID + "' AND AdminID=" + AdminId).Tables[0].Rows[0]["Id"]);

                    Bll.Delete(Id);
                }
            }


            
            //存在不做任何处理

            //不存在创建

            //选中则 没有数据则添加  有则 无任何动作    A001-A019

        }
    }
}