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

namespace ROYcms.UI.Admin.Administrator.tree
{
    /// <summary>
    /// 
    /// </summary>
    public partial class TreeDate : System.Web.UI.Page
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
                Response.Write("[" + Trees() + "]");
            }
		}


        #region 数据绑定
        /// <summary>
        /// DDLs the menu_bind.
        /// </summary>
        public string Trees()
        {
            DataSet ds = new ROYcms.Sys.BLL.ROYcms_class().GetClassList(10);
            string Text = null;
            int Div = 1;          //当前层
            foreach (DataRow dr in ds.Tables[0].Rows)
            {

                int ClassTj = Convert.ToInt32(dr["ClassTj"]);   //层次 
                string Id = dr["Id"].ToString().Trim();    //标识
                string ClassKind = dr["ClassKind"].ToString().Trim();    //标识
                string ClassId = dr["ClassId"].ToString().Trim();    //标识
                string ClassName = dr["ClassName"].ToString().Trim(); //名称
                string href = "/administrator/objet/send.aspx?classkind=" + ClassKind + "&class=" + Id; //地址
                bool issub = false;
                //判断是否有子类开始
                DataSet DS = new ROYcms.Sys.BLL.ROYcms_class().GetSubClassList(ClassId);
                DataTable dt = DS.Tables[0];
                //遍历行
                if (dt.Rows.Count > 0) { issub = true; }
                //判断是否有子类结束


                if (issub)
                {
                    Text += "{href:'" + href + "',id:'" + Id + "',text:'" + ClassName + "',hrefTarget:'_blank',cls:'folder',checked:false, children:[";
                }
                else
                {
                    if (ClassTj < Div)//上一层和当前层深度和层级相同
                    {
                        Text += "]},";
                        Text += "{href:'" + href + "',id:'" + Id + "',text:'" + ClassName + "',hrefTarget:'_blank',cls:'folder',leaf:true,checked:false},";

                    }
                    else { Text += "{href:'" + href + "',id:'" + Id + "',text:'" + ClassName + "',hrefTarget:'_blank',cls:'folder',leaf:true,checked:false},"; }
                }

                Div = ClassTj; //当前层
            }

            //去除尾部,
            Text = Text.Replace("},]}", "}]}");
            Text = Text.Substring(0, Text.Length - 1);
            return Text;

        }
        #endregion
	}
}
