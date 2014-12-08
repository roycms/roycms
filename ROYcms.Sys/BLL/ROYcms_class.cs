using System;
using System.Collections.Generic;
using System.Text;
using ROYcms.Sys.DAL;
using System.Data;
namespace ROYcms.Sys.BLL
{
  public  class ROYcms_class
    {
      ROYcms.Sys.DAL.ROYcms_class dal = new ROYcms.Sys.DAL.ROYcms_class();

       /// <summary>
        /// 是否存在该记录
        /// </summary>
      public bool Exists(string FilePath, string DefaultFile)
      { 
          return dal.Exists(FilePath, DefaultFile);
      }
        /// <summary>
        /// 获取ClassId的包含菜单列表
        /// </summary>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public DataSet GetClassListByClassId(string ClassId)
        {
            return dal.GetClassListByClassId(ClassId);
        }
      /// <summary>
        /// 获取ClassTitle
        /// </summary>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public string GetClassTitle(int Id)
        {
            return dal.GetClassTitle(Id);
        }
        /// <summary>
        /// 获取 单个值  单个字段
        /// </summary>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public string GetClassField(int Id, string Field)
        {
            return dal.GetClassField(Id,Field);
        }
        /// <summary>
        /// 获取 单个值  单个字段
        /// </summary>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public string GetClassField(string where, string Field)
        {
            return dal.GetClassField(where, Field);
        }
        /// <summary>
        /// 获取 首页模板地址
        /// </summary>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public string GetIndexTemplate()
        {
            return dal.GetClassField("FilePath='{cmspath}/' and DefaultFile='index.html'", "TemplateIndex");
        }
              /// <summary>
        /// 获取 获取Id
        /// </summary>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public int GetId(string FilePath,string DefaultFile)
        {
            return Convert.ToInt32(dal.GetClassField("FilePath='" + FilePath + "' and DefaultFile='" + DefaultFile + "'", "Id"));
        }
        /// <summary>
        /// 根据路径获取 ID
        /// </summary>
        /// <param name="ClassId"></param>
        /// <returns></returns> 
        public string GetId(string Path)
        {
            return dal.GetId(Path);
        }
        /// <summary>
        /// 获取ClassId  
        /// </summary>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public string GetClassId(int Id)
        {
            return dal.GetClassId(Id);
        }
        /// <summary>
        /// 添加一个菜单项
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool ClassAdd(ROYcms.Sys.Model.ROYcms_class model)
        {
           return dal.ClassAdd(model);
        }
       /// <summary>
        /// 获取GetIdForClassId
        /// </summary>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public int GetIdForClassId(string ClassId)
        {
            return dal.GetIdForClassId(ClassId);
        }
        /// <summary>
        /// 编辑一个菜单项
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool ClassUpdate(ROYcms.Sys.Model.ROYcms_class model)
        {
            return dal.ClassUpdate(model);
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_class GetModel(string ClassId)
        {

            return dal.GetModel(ClassId);
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_class _GetModel(string Id)
        {

            return dal._GetModel(Id);
        }
        /// <summary>
        /// 获取该菜单项的所有子菜单项
        /// </summary>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public DataSet GetSubClassList(string ClassId)
        {
            return dal.GetSubClassList(ClassId);
        }

        /// <summary>
        /// 获取菜单列表
        /// </summary>
        /// <param name="ClassKind"></param>
        /// <returns></returns>
        public DataSet GetClassList(int ClassKind)
        {
            return dal.GetClassList(ClassKind);
        }
        /// <summary>
        /// 获取菜单列表
        /// </summary>
        /// <param name="ClassKind"></param>
        /// <returns></returns>
        public DataSet GetClassList()
        {
            return dal.GetClassList();
        }
       /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetClassList(int Top, string strWhere)
        {
            return dal.GetClassList(Top, strWhere);
        }
        /// <summary>
        /// 获取菜单列表 按层筛选
        /// </summary>
        /// <returns></returns>
        public DataSet GetClassList(int ClassKind, int ClassTj)
        {
            return dal.GetClassList(ClassKind,ClassTj);
        }
        public string GetPreClassId(string ClassId)
        {
            return dal.GetPreClassId(ClassId);
        }

        /// <summary>
        /// 删除一个菜单项
        /// </summary>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public bool DelByClassId(string ClassId)
        {

            //级联删除分类关联
            ROYcms.Sys.BLL.ROYcms_Class_News ROYcms_Class_News_bll = new ROYcms.Sys.BLL.ROYcms_Class_News();
            //删除
            ROYcms_Class_News_bll.Delete(" class_id='" + ClassId + "'");

            //级联删除新闻 
            ROYcms.Sys.BLL.ROYcms_news ROYcms_news_bll = new ROYcms.Sys.BLL.ROYcms_news();
            ROYcms_news_bll.Delete(" classname=" + GetIdForClassId(ClassId));
            //级联删除智能表单模型关联
            ROYcms.Sys.BLL.ROYcms_Class_Model ROYcms_Class_Model_bll = new ROYcms.Sys.BLL.ROYcms_Class_Model();
            ROYcms_Class_Model_bll.CidDelete(GetIdForClassId(ClassId));

            bool err = dal.DelByClassId(ClassId);
            return err;
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public int Delete(string strWhere)
        {
            return dal.Delete(strWhere);
        }
        /// <summary>
        /// 更新排序
        /// </summary>
        /// <param name="ClassId"></param>
        /// <param name="ClassOrder"></param>
        /// <returns></returns>
        public bool UpdateClassOrder(string ClassId, int ClassOrder)
        {
            return dal.UpdateClassOrder(ClassId, ClassOrder);
        }

        public string _GetField(string ClassId, string Field)
        {

            return dal._GetField(ClassId, Field);

        }
    }
}
