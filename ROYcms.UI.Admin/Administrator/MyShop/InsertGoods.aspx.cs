using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ROYcms.UI.Admin.Administrator.MyShop
{
    /// <summary>
    /// 
    /// </summary>
    public partial class InsertGoods : ROYcms.AdminPage
    {
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.BLL.ROYcms_Goods BLL = new Sys.BLL.ROYcms_Goods();
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_Goods Model = new Sys.Model.ROYcms_Goods();
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.BLL.ROYcms_Gallery GalleryBll = new Sys.BLL.ROYcms_Gallery();
        public ROYcms.Sys.BLL.ROYcms_Appendix AppendixBll = new Sys.BLL.ROYcms_Appendix();
        /// <summary>
        /// 
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
            //绑定输出相册数据
            if (ROYcms.Common.Request.GetQueryInt("Id") != 0)
            {
                GalleryBind(ROYcms.Common.Request.GetQueryInt("Id"));
                AppendixBind(ROYcms.Common.Request.GetQueryInt("Id"));
            }
           DdClass_bind();
           brand_id_bind();
           goods_type.SelectedValue = ROYcms.Common.Request.GetQueryInt("Class").ToString();
           brand_id.SelectedValue = ROYcms.Common.Request.GetQueryInt("Brand").ToString();
           if (ROYcms.Common.Request.GetQueryInt("Id") > 0)//编辑
           {
               Model = BLL.GetModel(ROYcms.Common.Request.GetQueryInt("Id"));
           }
        }
        /// <summary>
        /// 菜单绑定
        /// </summary>
        void DdClass_bind()
        {
            this.goods_type.Items.Clear();
            this.goods_type.Items.Add(new System.Web.UI.WebControls.ListItem("选择分类", "0"));

            DataSet ds = new ROYcms.Sys.BLL.ROYcms_class().GetClassList(888888888);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                int ClassTj = Convert.ToInt32(dr["ClassTj"]);
                string ClassId = dr["Id"].ToString().Trim();
                string ClassName = dr["ClassName"].ToString().Trim() + "[ID:" + dr["Id"].ToString() + "]";

                if (ClassTj == 1)
                {
                    this.goods_type.Items.Add(new ListItem(ClassName, ClassId));
                }
                else
                {
                    ClassName = "├ " + ClassName;
                    ClassName = ROYcms.Common.StringPlus.StringOfChar(ClassTj - 1, "　") + ClassName;
                    this.goods_type.Items.Add(new System.Web.UI.WebControls.ListItem(ClassName, ClassId));
                }
            }

        }
        /// <summary>
        /// 
        /// </summary>
        void brand_id_bind()
        {
            this.brand_id.Items.Add(new ListItem("选择品牌", "0"));
            DataSet ds = new ROYcms.Sys.BLL.ROYcms_Goods_Brand().GetAllList();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                string Id = dr["id"].ToString().Trim();
                string Name = dr["Name"].ToString().Trim();
                this.brand_id.Items.Add(new ListItem(Name, Id));
            }
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
            Repeater_Appendix.DataSource = AppendixBll.GetList(80, "Rid=" + Rid + " AND TYPE=1 ", " TIME");
            Repeater_Appendix.DataBind();
        }
    }
}