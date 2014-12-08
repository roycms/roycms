/**********************************************************************************
 * Description:     
 * MemberVariable:
 * Functions:       
 * Modify information:     
 * 2008-8-5     New           DuYaoHui     Create Class
 * 
 * ********************************************************************************/
using System;
using System.Data;
using System.Web.UI.WebControls;
using ROYcms.Common;
using System.Web.UI;
using System.IO;
using System.Web;
namespace ROYcms.UI.Admin
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Administrator_class_index : AdminPage
    {
        ROYcms.Sys.Model.ROYcms_class model = new ROYcms.Sys.Model.ROYcms_class();

        #region ClassKind属性
        /// <summary>
        /// Gets or sets the kind of the class.
        /// </summary>
        /// <value>The kind of the class.</value>
        protected int ClassKind
        {
            get
            {
                return (int)ViewState["ClassKind"];
            }
            set
            {
                ViewState["ClassKind"] = value;
            }
        }
        #endregion

        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                ViewState["AdminId"] = Request["AdminId"];//selectindex.aspx页面用到
                this.ClassKind = ROYcms.Common.Request.GetQueryInt("ClassKind");
                if (this.ClassKind != 0)
                {
                    if (Request["Del"] != null)
                    {
                        new ROYcms.Sys.BLL.ROYcms_class().DelByClassId(Request["Del"]);
                        BindData();
                    }
                    else {
                        BindData();
                    }
                }
                else { Response.Write("参数不正确"); }
               
            }
        }
        #region 数据绑定
        /// <summary>
        /// BindData
        /// </summary>
        private void BindData()
        {
            DataSet ds = new ROYcms.Sys.BLL.ROYcms_class().GetClassList(this.ClassKind);
            this.rptMenuList.DataSource = ds.Tables[0].DefaultView;
            this.rptMenuList.DataBind();

        }
        #endregion

        #region 显示数据处理
        /// <summary>
        /// Handles the ItemDataBound event of the rptMenuList control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Web.UI.WebControls.RepeaterItemEventArgs"/> instance containing the event data.</param>
        protected void rptMenuList_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            {
                Literal LitFirst = (Literal)e.Item.FindControl("LitFirst");
                //Literal Literal_id = (Literal)e.Item.FindControl("Literal_id");
                //HyperLink LabClassNm = (HyperLink)e.Item.FindControl("LabClassNm");
                Label LabClassNm = (Label)e.Item.FindControl("LabClassNm");

                string LitStyle = "<span style=width:{0}px;text-align:right;display:inline-block;>{1}{2}</span>";
                string LitImg1 = "<img src=/administrator/images/jia.gif ><img src=/administrator/images/openfolder.gif align=absmiddle />";
                string LitImg2 = "<img src=/administrator/images/page_white_star.png align=absmiddle />";
                string LitImg3 = "<img src=/administrator/images/t.gif align=absmiddle />";

                DataRowView drv = (DataRowView)e.Item.DataItem;
                int ClassTj = Convert.ToInt32(drv["ClassTj"]);
                if (ClassTj == 1)
                {
                    LabClassNm.Font.Bold = true;
                    LitFirst.Text = LitImg1;
                    //Literal_id.Text = drv["ClassList"].ToString().Replace(",",""); 
                }
                else
                {
                    LitFirst.Text = string.Format(LitStyle, ClassTj * 20, LitImg3, LitImg2);
                    //Literal_id.Text = drv["ClassList"].ToString().Substring(0, drv["ClassList"].ToString().IndexOf(",")) + "_sub";
                }
            }
        }
        #endregion
        #region 列表顺序保存操作
        /// <summary>
        /// 列表顺序保存操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnSave_Click(object sender, EventArgs e)
        {
            int UpSum = 0;
            bool ReVal = true;
            foreach (RepeaterItem RptItem in this.rptMenuList.Items)
            {
                HiddenField txtClassId = (HiddenField)RptItem.FindControl("txtClassId");
                TextBox txtOrder = (TextBox)RptItem.FindControl("txtOrder");
                try
                {
                    ReVal = new ROYcms.Sys.BLL.ROYcms_class().UpdateClassOrder(txtClassId.Value.Trim(), Convert.ToInt32(txtOrder.Text));
                }
                catch
                {
                    ReVal = false;
                    ROYcms.Common.SystemCms.InsertErrLog("列表操作排序错误！", Request.PhysicalPath);
                }

                if (ReVal == false)
                {
                    ++UpSum;
                }
            }
            if (UpSum == 0)
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "ajaxjs", "alert('所有设定的栏目顺序都已保存成功！')", true);
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "ajaxjs", string.Format("alert('栏目顺序部份保存成功,共有{0}条记录保存失败!')", UpSum), true);
            }
           BindData();
        }
        #endregion
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Btn_add_Click(object sender, EventArgs e)
        {
            Response.Redirect("Insert.aspx?ClassKind=" + this.ClassKind);
        }


        /// <summary>
        /// 商品分类页面加载前类
        /// </summary>
        /// <param name="writer"></param>
        protected override void Render(HtmlTextWriter writer)
        {
           
            string content = string.Empty;
            StringWriter stringWriter = new StringWriter();
            HtmlTextWriter htmlWriter = new HtmlTextWriter(stringWriter);
            try
            {
                // 将当前页面的内容呈现到临时的 HtmlTextWriter 对象中  
                base.Render(htmlWriter);
                htmlWriter.Close();
                // 得到当前页面的全部内容  
                content = stringWriter.ToString();
                // 替换页面中的部分内容  
                string newContent = content;
                if (HttpContext.Current.Request.QueryString["ClassKind"]=="888888888") 
                {
                    newContent = newContent.Replace("频道", "商品分类");
                    newContent = newContent.Replace("/administrator/objet/Insert.aspx", "/administrator/MyShop/InsertGoods.aspx");
                    newContent = newContent.Replace("发布信息", "发布商品");
                    newContent = newContent.Replace("/administrator/objet/admin.aspx", "/administrator/Myshop/AdminGoods.aspx");
                    newContent = newContent.Replace("管理信息", "管理商品");
                }
                else if (HttpContext.Current.Request.QueryString["ClassKind"] == "999999999")
                {
                    newContent = newContent.Replace("频道", "视频分类");
                    newContent = newContent.Replace("/administrator/objet/Insert.aspx", "/administrator/MyShop/InsertGoods.aspx");
                    newContent = newContent.Replace("发布信息", "发布视频");
                    newContent = newContent.Replace("/administrator/objet/admin.aspx", "/administrator/Myshop/AdminGoods.aspx");
                    newContent = newContent.Replace("管理信息", "管理视频");
                }
                // 将新页面的内容显示出来  
                writer.Write(newContent);
            }
            catch { }
            finally
            {
                stringWriter.Dispose();
                htmlWriter.Close();
                htmlWriter.Dispose();
            }
        } 
 

    }
}