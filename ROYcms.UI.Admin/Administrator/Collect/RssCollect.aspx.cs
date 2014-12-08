#define Tools
using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Text;
#if (Tools)
namespace ROYcms.UI.Admin.Administrator.App_Api
{
    /// <summary>
    /// 
    /// </summary>
    public partial class RssApi : BasePage
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
                DdClassKing_bind();
                if (ViewState["ClassKind"] != null)
                {
                    this.DdClass.Visible = true;
                    DdClass_bind();
                }
                else
                {
                    this.DdClass.Visible = false;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        void Bind() 
        {
            Repeater_Rss.DataSource = ROYcms.Common.Rss.ReadRss(TextBox_RssPath.Text.Trim());
            Repeater_Rss.DataBind();
          
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button_RssbT_Click(object sender, EventArgs e)
        {
            Bind();   
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button_fabu_Click(object sender, EventArgs e)
        {
            DataTable DT = ROYcms.Common.Rss.ReadRss(TextBox_RssPath.Text.Trim());

            for (int i = DT.Rows.Count-1; i > 0; i--)
            {
                DataRow dataRow = DT.Rows[i];
                string  Title = dataRow["title"].ToString();
                string Link = dataRow["Link"].ToString();
                //判断数据库是否有该信息
                if (!___ROYcms_news_Bll.Exists_title(Title))
                {
                    string Contents = null;
                    try
                    {
                        Contents = GetContent(Link, TextBox_star.Text, TextBox_end.Text, "utf-8");
                    }
                    catch { Contents = " "; }
                    Contents = NoForMat(Contents);

                    //插入数据库数据
                    ___ROYcms_news_Model.pic = null;
                    ___ROYcms_news_Model.title = Title;
                    ___ROYcms_news_Model.keyword = Title;
                    ___ROYcms_news_Model.zhaiyao = Title;
                    ___ROYcms_news_Model.classname = Convert.ToInt32(DdClass.SelectedValue);
                    ___ROYcms_news_Model.contents = Contents;
                    ___ROYcms_news_Model.infor = null;
                    ___ROYcms_news_Model.jumpurl = null;
                    ___ROYcms_news_Model.author = "未知";
                    ___ROYcms_news_Model.url = null;
                    ___ROYcms_news_Model.tag = null;
                    ___ROYcms_news_Model.orders = 0;
                    ___ROYcms_news_Model.ding = 1;
                    ___ROYcms_news_Model.tuijian = 1;
                    ___ROYcms_news_Model.dig = 0;
                    ___ROYcms_news_Model.hits = 0;
                    ___ROYcms_news_Model.switchs = 1;
                    ___ROYcms_news_Model.link = null;
                    ___ROYcms_news_Model.type = ViewState["ClassKind"].ToString();
                    ___ROYcms_news_Model.GUID = null;

                    ___ROYcms_news_Bll.Add(___ROYcms_news_Model);
                }
            }

           
            Response.Write(" 重复条数(" + (DT.Rows.Count).ToString()+")");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="starS"></param>
        /// <param name="endS"></param>
        /// <param name="Enco"></param>
        /// <returns></returns>
        public string GetContent(string url, string starS,string endS, string Enco)
        {
            string Contents = ROYcms.Common.GetUrlText.GetText(url, Enco);
            Contents = ForMat(Contents);//格式化
            int star = Contents.IndexOf(ForMat(starS)) + ForMat(starS).Length;
            int end = Contents.IndexOf(ForMat(endS));
            return Contents.Substring(star, end - star);
        }

        /// <summary>
        /// 把字符转化为文本格式
        /// </summary>
        /// <param name="Input"></param>
        /// <returns></returns>
        public static string ForMat(string Input)
        {
            StringBuilder sb = new StringBuilder(Input);
            
            sb.Replace("\"", "[yh]");
            sb.Replace(" ", "[kg]");
            sb.Replace("'", "[dyh]");
            sb.Replace(".", "[dian]");
            sb.Replace("\\", "[fxg]");
            sb.Replace("/", "[xg]");
            sb.Replace("?", "[wh]");
            return sb.ToString();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Input"></param>
        /// <returns></returns>
        public static string NoForMat(string Input)
        {
            StringBuilder sb = new StringBuilder(Input);

            sb.Replace("[yh]", "\"");
            sb.Replace("[kg]", " ");
            sb.Replace("[dyh]", "'");
            sb.Replace("[dian]", ".");
            sb.Replace("[fxg]", "\\");
            sb.Replace("[xg]", "/");
            sb.Replace("[wh]", "?");
            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void DdClassKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.DdClassKind.SelectedValue != "0")
            {
                ViewState["ClassKind"] = this.DdClassKind.SelectedValue;
                this.DdClass.Visible = true;
                DdClass_bind();
            }
            else
            {
                ViewState["ClassKind"] = null;
            }
        }
        #region 数据绑定
        void DdClassKing_bind()
        {
            this.DdClassKind.Items.Add(new ListItem("所有模块", "0"));
            DataSet ds = new ROYcms.Sys.BLL.ROYcms_Objet().GetAllList();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                string Id = dr["ClassKind"].ToString().Trim();
                string Name = dr["Title"].ToString().Trim();
                this.DdClassKind.Items.Add(new ListItem(Name, Id));
            }
        }
        /// <summary>
        /// 菜单绑定
        /// </summary>
        void DdClass_bind()
        {
            this.DdClass.Items.Clear();
            this.DdClass.Items.Add(new System.Web.UI.WebControls.ListItem("所有频道", "0"));
            DataSet ds = new ROYcms.Sys.BLL.ROYcms_class().GetClassList(Convert.ToInt32(ViewState["ClassKind"]));
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
        #endregion
    }
}
#endif 