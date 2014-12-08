using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Common;
using ROYcms.Sys.Model;
using System.Web.UI.WebControls;
using ROYcms.Sys.DAL;
namespace ROYcms.Sys.BLL
{
	/// <summary>
	/// 业务逻辑类ROYcms_product 的摘要说明。
	/// </summary>
	public class ROYcms_product
	{
		private readonly ROYcms.Sys.DAL.ROYcms_product dal=new ROYcms.Sys.DAL.ROYcms_product();
		public ROYcms_product()
		{}
		#region  成员方法
        /// <summary>
        /// 分类下信息批量转移
        /// </summary>
        public void GoToClass(int go, int to)
        {
            dal.GoToClass(go,to);
        }
        /// <summary>
        /// 信息批量转移 根据BH
        /// </summary>
        public void ToClass(int to_class, int bh)
        {
            dal.ToClass(to_class, bh);
        }
        /// <summary>
        /// 是否存在该记录 根据标题
        /// </summary>
        public bool Exists_title(string title)
        {
            return dal.Exists_title(title);
        }
        /// <summary>
        /// 自定义SQL语句返回DATESET
        /// </summary>
        public DataSet GetDataSet(string SQL)
        {
            return dal._GetDataSet(SQL);
        }
        /// <summary>
        /// 获取一条信息 条件 Tops the product.
        /// </summary>
        /// <returns></returns>
        public ROYcms.Sys.Model.ROYcms_product TopProduct(string where)
        {
            return dal.TopProduct(where);
        }
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int bh)
		{
			return dal.Exists(bh);
		}
          /// <summary>
        /// 获得文章标题
        /// </summary>
        public string GetTitle(int bh)
        {
            return dal.GetTitle(bh);
        }
        /// <summary>
        /// 获取 单个值  单个字段
        /// </summary>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public string GetField(int Id, string Field)
        {
            return dal.GetField(Id, Field);
        }
        /// <summary>
        /// 获得ClassKind
        /// </summary>
        public string GetClassKind(int bh)
        {
            return dal.GetClassKind(bh);
        }
        /// <summary>
        /// 获得文章分类
        /// </summary>
        public string GetClassName(int bh)
        {
            return dal.GetClassName(bh);
        }
        /// <summary>
        /// 浏览一次 增加一次浏览记录
        /// </summary>
        public void Hits_product(int bh)
        {
            dal.Hits_product(bh);
        }
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(ROYcms.Sys.Model.ROYcms_product model)
		{
            int news_id = dal.Add(model);

            //
            //级联添加
            //
            if (news_id != 1) 
            {
                ROYcms.Sys.BLL.ROYcms_Class_News ROYcms_Class_product_bll = new ROYcms.Sys.BLL.ROYcms_Class_News();
                ROYcms.Sys.Model.ROYcms_Class_News ROYcms_Class_product_model = new ROYcms.Sys.Model.ROYcms_Class_News();
                ROYcms.Sys.BLL.ROYcms_class ROYcms_Class_bll = new ROYcms.Sys.BLL.ROYcms_class();
                ROYcms.Sys.Model.ROYcms_class ROYcms_Class_model = ROYcms_Class_bll._GetModel(model.classname.ToString());

                ROYcms_Class_product_model.news_id = news_id;
                ROYcms_Class_product_model.Class = Convert.ToInt32(model.classname);
                ROYcms_Class_product_model.class_id = ROYcms_Class_model.ClassId;
                ROYcms_Class_product_model.class_list = ROYcms_Class_model.ClassList;
                ROYcms_Class_product_model.Time = DateTime.Now;
                ROYcms_Class_product_model.GUID = model.GUID;
                ROYcms_Class_product_bll.Add(ROYcms_Class_product_model);

            }
			return news_id;
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
        public void Update(ROYcms.Sys.Model.ROYcms_product model)
        {


            //
            //级联更新  删除以前的分类关联  新建一个分类关联
            //

            ROYcms.Sys.BLL.ROYcms_Class_News ROYcms_Class_product_bll = new ROYcms.Sys.BLL.ROYcms_Class_News();
            ROYcms.Sys.Model.ROYcms_Class_News ROYcms_Class_product_model = new ROYcms.Sys.Model.ROYcms_Class_News();
            ROYcms.Sys.BLL.ROYcms_class ROYcms_Class_bll = new ROYcms.Sys.BLL.ROYcms_class();
            ROYcms.Sys.Model.ROYcms_class ROYcms_Class_model = ROYcms_Class_bll._GetModel(model.classname.ToString());

            //删除
            ROYcms_Class_product_bll.Delete(" (news_id=" + model.bh + ") AND (Class=" + GetClassName(model.bh) + ") ");
            //添加
            ROYcms_Class_product_model.news_id = model.bh;
            ROYcms_Class_product_model.Class = Convert.ToInt32(model.classname);
            ROYcms_Class_product_model.class_id = ROYcms_Class_model.ClassId;
            ROYcms_Class_product_model.class_list = ROYcms_Class_model.ClassList;
            ROYcms_Class_product_model.Time = DateTime.Now;
            ROYcms_Class_product_model.GUID = model.GUID;
            ROYcms_Class_product_bll.Add(ROYcms_Class_product_model);

            dal.Update(model);

        }

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int bh)
		{
			dal.Delete(bh);

            //级联删除分类关联
            ROYcms.Sys.BLL.ROYcms_Class_News ROYcms_Class_product_bll = new ROYcms.Sys.BLL.ROYcms_Class_News();
            ROYcms.Sys.BLL.ROYcms_New_User ROYcms_New_User_bll = new ROYcms.Sys.BLL.ROYcms_New_User();
            //删除
            ROYcms_Class_product_bll.Delete(" news_id=" + bh);
            ROYcms_New_User_bll.Delete(" new_id=" + bh);
		}
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public int Delete(string strWhere)
        {
            int bh = dal.Delete(strWhere);
            return bh;
        }
        /// <summary>
        /// 修改一条数据是否置顶
        /// </summary>
        public void Ding_product(int bh,int ding)
        {

            dal.Ding_product(bh,ding);
        }
        /// <summary>
        /// 修改一条数据是否推荐
        /// </summary>
        public void Tuijian_product(int bh, int tuijian)
        {

            dal.Tuijian_product(bh, tuijian);
        }
        /// <summary>
        /// 控制开关 打开 和关闭一条数据
        /// </summary>
        public void K_product(int bh,int switchs)
        {

            dal.K_product(bh, switchs);
        }
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ROYcms.Sys.Model.ROYcms_product GetModel(int bh)
		{
			
			return dal.GetModel(bh);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中。
		/// </summary>
		public ROYcms.Sys.Model.ROYcms_product GetModelByCache(int bh)
		{
			
			string CacheKey = PubConstant.date_prefix + "productModel-" + bh;
			object objModel = ROYcms.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(bh);
					if (objModel != null)
					{
						int ModelCache = ROYcms.Common.ConfigHelper.GetConfigInt("ModelCache");
						ROYcms.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (ROYcms.Sys.Model.ROYcms_product)objModel;
		}

        /// <summary>
        /// 上一页信息
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="classname">The classname.</param>
        /// <returns>id,标题,时间</returns>
        public string PgUp(int id, string classname)
        {
            ROYcms.Sys.Model.ROYcms_product Model = dal.TopProduct(" bh<" + id + " and classname='" + classname + "' order by bh ");
            if (Model != null)
            {
                return Model.bh.ToString() + "," + Model.title + "," + Model.time;
            }
            else { return ""; }
        }
        /// <summary>
        /// 下一页信息
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="classname">The classname.</param>
        /// <returns>id,标题,时间</returns>
        public string PgDn(int id,string classname)
        {
            ROYcms.Sys.Model.ROYcms_product Model = dal.TopProduct(" bh>" + id + " and classname='" + classname + "' order by bh desc ");
            if (Model != null)
            {
                return Model.bh.ToString() + "," + Model.title + "," + Model.time;
            }
            else { return ""; }
        }

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
        /// <summary>
        /// 获得数据列表 SQL语句地定义
        /// </summary>
        public DataSet GetList_(string strSql)
        {
            return dal.GetList_(strSql);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
       
        /// <summary>
        /// 获得数据列表 + 分页 存储过程
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere)
        {
            return dal.GetList(PageSize,PageIndex,strWhere);
        }
        /// <summary>
        /// 获得数据列表 + 分页 存储过程
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, int OrderType)
        {
            return dal.GetList(PageSize, PageIndex, strWhere, OrderType);
        }
        /// <summary>
        /// 获得数据总数
        /// </summary>
        public int GetCount(string strWhere)
        {
            return dal.GetCount(strWhere);
        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  成员方法
	}
}

