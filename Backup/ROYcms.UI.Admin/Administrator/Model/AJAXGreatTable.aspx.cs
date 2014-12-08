using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ROYcms.UI.Admin.Administrator.Model
{
    /// <summary>
    /// 类
    /// </summary>
    public partial class AJAXGreatTable : ROYcms.AdminPage
    {
        /// <summary>
        /// 
        /// </summary>
        public ROYcms.Sys.BLL.CMS CMS = new ROYcms.Sys.BLL.CMS();
        /// <summary>
        /// 加载...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.ContentType = "text/plain";
            Response.Write(GreatTable(int.Parse(Request["ModelId"]), Request["TableName"]));

        }
        /// <summary>
        /// 创建模型
        /// </summary>
        /// <param name="ModelId"></param>
        /// <param name="TableName"></param>
        /// <returns></returns>
        public int GreatTable(int ModelId, string TableName)
        {
            if (CMS.Exists(TableName))//如果表存在
            { CMS.DelTable(TableName); } //则删除表格

            int PRE = 0;
            ___ROYcms_Custom_Model.TableName = TableName;
            ___ROYcms_Custom_Model.Tablelist = "Id INTEGER not null, Cid INTEGER,"; //默认的ID是新闻的ID，和Cid是Class分类ID

            DataSet Ds = ___ROYcms_Field_bll.GetList(80, "Rid=" + ModelId, " OrderBy");
            if (Ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow Dr in Ds.Tables[0].Rows)
                {
                    string Name = Dr["Name"].ToString();//字段名字
                    string FieldType = Dr["FieldType"].ToString();//1数字，0 文本
                    string Len = Dr["Len"].ToString();//长度汉字 *2
                    if (!Name.Contains("_R"))//去除默认的字段进行表的创建
                    {
                        ___ROYcms_Custom_Model.Tablelist += Name + (FieldType == "1" ? " INTEGER," : " VARCHAR(" + (int.Parse(Len) * 2 > 8000 ? 8000 : int.Parse(Len) * 2).ToString() + "),");
                    }
                }

                ___ROYcms_Custom_Model.Tablelist.Substring(0, ___ROYcms_Custom_Model.Tablelist.Length - 1);//去除结尾的的;
                PRE = ___ROYcms_Custom_bll.CreateTable(___ROYcms_Custom_Model); //创建表
                //___ROYcms_Custom_bll.Key(___ROYcms_Custom_Model.TableName, "Id");//创建主键自动增长

            }
            else
            {
                PRE = -3; //该表内无字段
            }

            return PRE == -1 ? 1 : PRE;
        }
    }
}
