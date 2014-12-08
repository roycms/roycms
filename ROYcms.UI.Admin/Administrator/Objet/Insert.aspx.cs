using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.Administrator.Objet
{
    /// <summary>
    /// Insert
    /// </summary>
    public partial class Insert : ROYcms.AdminPage
    {
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.BLL.ROYcms_Class_Model BLL = new ROYcms.Sys.BLL.ROYcms_Class_Model();
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.BLL.ROYcms_Gallery GalleryBll = new Sys.BLL.ROYcms_Gallery();
        public ROYcms.Sys.BLL.ROYcms_Appendix AppendixBll = new Sys.BLL.ROYcms_Appendix();
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.BLL.CMS CMSBLL = new ROYcms.Sys.BLL.CMS();
        /// <summary>
        /// Page_Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["GalleryInt"] != null) //删除相册临时数据
            {
                GalleryBll.Delete("Rid=" + Application["GalleryInt"]);
            }
            else
            {
                Application["GalleryInt"] = ROYcms.Common.StringPlus.GetRamTimeCode();//修改相册时用到
            }
            if (Application["AppendixInt"] != null) //删除相册临时数据
            {
                AppendixBll.Delete("Rid=" + Application["AppendixInt"]);
            }
            else
            {
                Application["AppendixInt"] = ROYcms.Common.StringPlus.GetRamTimeCode();//修改相册时用到
            }
            //绑定输出相册数据
            if (ROYcms.Common.Request.GetQueryInt("Id") != 0)
            {
                GalleryBind(ROYcms.Common.Request.GetQueryInt("Id"));
                AppendixBind(ROYcms.Common.Request.GetQueryInt("Id"));
            }
            DdClass_bind();//频道菜单
            
            if (Request["Class"] != null)
            {
                DdClass.SelectedValue = Request["Class"];

                int Class =Convert.ToInt32(Request["Class"]);
                string Mid = BLL.CidGetP("Mid", "Cid=" + Class.ToString());

                
                if (Mid != null && CMSBLL.Exists(new ROYcms.Sys.BLL.ROYcms_Custom().GetTableName(Class)))
                {
                    FormBind(Convert.ToInt32(Mid));// FormBind  只能输出表单
                }
                else
                { //无关联模型 按照默认的模型输出
                    PostPanel.Visible = true;
                }
            }
        }
        /// <summary>
        /// 菜单绑定
        /// </summary>
        void DdClass_bind()
        {
            this.DdClass.Items.Clear();
            this.DdClass.Items.Add(new System.Web.UI.WebControls.ListItem("选择频道", "0"));
            DataSet ds = new ROYcms.Sys.BLL.ROYcms_class().GetClassList(Convert.ToInt32(Request["ClassKind"]));
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                int ClassTj = Convert.ToInt32(dr["ClassTj"]);
                string ClassId = dr["Id"].ToString().Trim();
                string ClassName = dr["ClassName"].ToString().Trim() + "[ID:" + dr["Id"].ToString() + "]";

                if (ClassTj == 1)
                {
                    this.DdClass.Items.Add(new ListItem(ClassName, ClassId));
                }
                else
                {
                    ClassName = "├ " + ClassName;
                    ClassName = ROYcms.Common.StringPlus.StringOfChar(ClassTj - 1, "　") + ClassName;
                    this.DdClass.Items.Add(new System.Web.UI.WebControls.ListItem(ClassName, ClassId));
                }
            }

        }
        /// <summary>
        /// FormBind  只能输出表单
        /// </summary>
        /// <param name="Rid"></param>
        public void FormBind(int Rid)
        {
            Repeater_Form_Put.DataSource = ___ROYcms_Field_bll.GetList(80, "Rid=" + Rid, " OrderBy");
            Repeater_Form_Put.DataBind();
        }
        /// <summary>
        /// 编辑状态下相册输出
        /// </summary>
        /// <param name="Rid"></param>
        public void GalleryBind(int Rid)
        {
            
            Repeater_Gallery.DataSource = GalleryBll.GetList(80, "Rid=" + Rid, " TIME");
            Repeater_Gallery.DataBind();
        }
        public void AppendixBind(int Rid)
        {
            Repeater_Appendix.DataSource = AppendixBll.GetList(80, "Rid=" + Rid + " AND TYPE=0 ", " TIME");
            Repeater_Appendix.DataBind();
        }

    }
}
