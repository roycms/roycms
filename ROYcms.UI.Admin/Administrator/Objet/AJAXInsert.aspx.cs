using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;

namespace ROYcms.UI.Admin.Administrator.Objet
{
    /// <summary>
    /// AJAXInsert
    /// </summary>
    public partial class AJAXInsert : ROYcms.AdminPage
    {
        /// <summary>
        /// ROYcms_news Bll
        /// </summary>
        public ROYcms.Sys.BLL.ROYcms_news Bll = new ROYcms.Sys.BLL.ROYcms_news();
        /// <summary>
        /// ROYcms_news Model
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_news Model = new ROYcms.Sys.Model.ROYcms_news();
        /// <summary>
        /// ROYcms_Custom 逻辑处理类
        /// </summary>
        ROYcms.Sys.BLL.ROYcms_Custom CustomBLL = new ROYcms.Sys.BLL.ROYcms_Custom();
        ROYcms.Sys.Model.ROYcms_Custom CustomModel = new ROYcms.Sys.Model.ROYcms_Custom();
        ROYcms.Sys.BLL.ROYcms_Class_Model Class_ModelBLL = new ROYcms.Sys.BLL.ROYcms_Class_Model();
        ROYcms.Sys.BLL.ROYcms_Model ModelBLL = new ROYcms.Sys.BLL.ROYcms_Model();
        /// <summary>
        /// Page_Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            int PER = 0;
            int PER2 = 0;

            Model.bh = Convert.ToInt32(Request["Id"] == null ? "0" : Request["Id"]);//编辑时用到


            Model.title = Request["ROYcms__RTitle"];
            Model.contents = Request["ROYcms__RContent"];

            Model.classname = Convert.ToInt32(Request["DdClass"]); //分类ID
            Model.type = Request["ClassKind"]; //全局标识

            Model.keyword = Request["keyword"];
            Model.zhaiyao = Request["zhaiyao"];

            Model.jumpurl = Request["jumpurl"];
            Model.infor = Request["infor"];
            Model.author = Request["author"];
            Model.url = Request["urls"];
            Model.link = Request["link"];

            Model.pic = Request["pic"];
            Model.tag = Request["tag"];

            Model.dig = Convert.ToInt32(Request["dig"]) + 1;
            Model.hits = Convert.ToInt32(Request["hits"]) + 1;
            Model.orders = Convert.ToInt32(Request["orders"]) + 1;

            //Model.ding = Convert.ToInt32(Request["ding"]);
            //Model.tuijian = Convert.ToInt32(Request["tuijian"]);
            //Model.switchs = Convert.ToInt32(Request["switchs"]);

            Model.ding = 1;
            Model.tuijian = 1;
            Model.switchs = 0;

            Model.GUID = ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("guid");//获取CMS.config 的GUID
            Model.time =Convert.ToDateTime(Request["Times"]); ;
            //执行
            if (Model.bh == 0)//添加一条数据
            {
                PER = Bll.Add(Model);
                PER2 = AdminCustom(PER, Convert.ToInt32(Model.classname), 0);//自定义模型数据添加或编辑一条数据
                
                try //将相册的图片数据关联到文章来
                {
                    new ROYcms.Sys.BLL.ROYcms_Gallery().ZUpdate(PER, Convert.ToInt32(Application["GalleryInt"] == null ? 0 : Application["GalleryInt"]));
                }
                catch
                {
                    new ROYcms.Sys.BLL.ROYcms_Log().InsertSystemLog("3", "将相册的图片数据关联到文章失败", "将相册的图片数据关联到文章失败");//写入日志
                }
            }
            else //编辑一条数据
            {
                
                Bll.Update(Model);

                PER = AdminCustom(Model.bh, Convert.ToInt32(Model.classname), 1);//自定义模型数据添加或编辑一条数据
            }

            Response.ContentType = "text/plain";
            Response.Write(PER);

        }
        /// <summary>
        /// 自定义模型数据添加或编辑一条数据
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Class"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public int AdminCustom(int Id, int Class, int r)
        {
            int PER = 0;
            string TableName = CustomBLL.GetTableName(Class);
            if (TableName != null)
            {
                CustomModel = CustomBLL.SetVal(this, Id, Class);
                CustomModel.TableName = TableName;
                if (CustomBLL.Exists(Id, TableName))//判断自定义模型内是否存在该记录 存在则编辑 不存在则删除
                {
                    if (r == 0) //添加
                    {
                        PER = CustomBLL.Add(CustomModel);
                    }
                    else //编辑
                    {
                        PER = CustomBLL.Update(CustomModel);
                    }
                }
                else { PER = CustomBLL.Add(CustomModel); }
            }
            else
            {
                PER = 1;
            }
            return PER;
        }
    }
}
