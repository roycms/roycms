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

namespace ROYcms.UI.Admin
{
    /// <summary>
    /// 
    /// </summary>
	public partial class Tree : System.Web.UI.Page
    {    /// <summary>
        /// XML help?
        /// </summary>
		protected void Page_Load(object sender, EventArgs e)
		{
           
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

                string Id = dr["ClassId"].ToString().Trim();    //标识
                string ClassName = dr["ClassName"].ToString().Trim(); //名称
                bool issub = false;
                //判断是否有子类开始
                DataSet DS = new ROYcms.Sys.BLL.ROYcms_class().GetSubClassList(Id);
                DataTable dt = DS.Tables[0];
                //遍历行
                if (dt.Rows.Count > 0) { issub = true; }
                //判断是否有子类结束


                if (issub)
                {
                    Text += "{id:\"" + Id + "\",text:\"" + ClassName + "\",cls1:\"r_t\",cls2:\"r_t\",items:[";
                }
                else
                {
                    if (ClassTj < Div)//上一层和当前层深度和层级相同
                    {
                        Text += "]},";
                        Text += "{id:\"" + Id + "\",text:\"" + ClassName + "\"},";

                    }
                    else { Text += "{id:\"" + Id + "\",text:\"" + ClassName + "\"},"; }
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
