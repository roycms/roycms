using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Sys.Model;
namespace ROYcms.Sys.BLL
{
	/// <summary>
	/// 分类和模型表关系表 
	/// </summary>
	public partial class ROYcms_Class_Model
	{
		private readonly ROYcms.Sys.DAL.ROYcms_Class_Model dal=new ROYcms.Sys.DAL.ROYcms_Class_Model();
		public ROYcms_Class_Model()
		{}
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			return dal.Exists(Id);
		}
        /// <summary>
        /// 是否存在该记录 根据ClassID
        /// </summary>
        public bool CidExists(int Cid)
        {
            return dal.CidExists(Cid);
        }
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(ROYcms.Sys.Model.ROYcms_Class_Model model)
		{
			return dal.Add(model);
		}
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool CidUpdate(ROYcms.Sys.Model.ROYcms_Class_Model model)
        {
            return dal.CidUpdate(model);
        }
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(ROYcms.Sys.Model.ROYcms_Class_Model model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Id)
		{
			
			return dal.Delete(Id);
		}
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool CidDelete(int Cid)
        {

            return dal.CidDelete(Cid);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool MidDelete(int Mid)
        {

            return dal.MidDelete(Mid);
        }
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string Idlist )
		{
			return dal.DeleteList(Idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ROYcms.Sys.Model.ROYcms_Class_Model GetModel(int Id)
		{
			
			return dal.GetModel(Id);
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<ROYcms.Sys.Model.ROYcms_Class_Model> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<ROYcms.Sys.Model.ROYcms_Class_Model> DataTableToList(DataTable dt)
		{
			List<ROYcms.Sys.Model.ROYcms_Class_Model> modelList = new List<ROYcms.Sys.Model.ROYcms_Class_Model>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ROYcms.Sys.Model.ROYcms_Class_Model model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new ROYcms.Sys.Model.ROYcms_Class_Model();
					if(dt.Rows[n]["Id"]!=null && dt.Rows[n]["Id"].ToString()!="")
					{
						model.Id=int.Parse(dt.Rows[n]["Id"].ToString());
					}
					if(dt.Rows[n]["Mid"]!=null && dt.Rows[n]["Mid"].ToString()!="")
					{
						model.Mid=int.Parse(dt.Rows[n]["Mid"].ToString());
					}
					if(dt.Rows[n]["Cid"]!=null && dt.Rows[n]["Cid"].ToString()!="")
					{
						model.Cid=int.Parse(dt.Rows[n]["Cid"].ToString());
					}
					if(dt.Rows[n]["Uid"]!=null && dt.Rows[n]["Uid"].ToString()!="")
					{
						model.Uid=int.Parse(dt.Rows[n]["Uid"].ToString());
					}
					if(dt.Rows[n]["ClassID"]!=null && dt.Rows[n]["ClassID"].ToString()!="")
					{
						model.ClassID=int.Parse(dt.Rows[n]["ClassID"].ToString());
					}
					if(dt.Rows[n]["TIME"]!=null && dt.Rows[n]["TIME"].ToString()!="")
					{
						model.TIME=DateTime.Parse(dt.Rows[n]["TIME"].ToString());
					}
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}
      /// <summary>
        /// 获取单个值
      /// </summary>
      /// <param name="name"></param>
      /// <param name="strWhere"></param>
      /// <returns></returns>
        public string CidGetP(string name, string strWhere)
        {
            return dal.CidGetP(name,strWhere);
        }
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  Method
	}
}

