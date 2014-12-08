using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Sys.Model;
namespace ROYcms.Sys.BLL
{
	/// <summary>
	/// 数据模型表 ROYc
	/// </summary>
	public partial class ROYcms_Model
	{
		private readonly ROYcms.Sys.DAL.ROYcms_Model dal=new ROYcms.Sys.DAL.ROYcms_Model();
		public ROYcms_Model()
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
		/// 增加一条数据
		/// </summary>
		public int  Add(ROYcms.Sys.Model.ROYcms_Model model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(ROYcms.Sys.Model.ROYcms_Model model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Id)
		{
            new BLL.ROYcms_Field().MidDelete(Id); //级联删除所有的模型下的所有字段

            if (GetTableName(Id) != null) { if (new BLL.CMS().Exists(GetTableName(Id))) { new BLL.CMS().DelTable(GetTableName(Id)); } } //级联删除表格

            new BLL.ROYcms_Class_Model().MidDelete(Id);   //级联删除关联的分类的关系表 Model_Class

			return dal.Delete(Id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string Idlist )
		{
			return dal.DeleteList(Idlist );
		}
        /// <summary>
        /// 得到表格名称
        /// </summary>
        public string GetTableName(int Id)
        {
            if (dal.GetModel(Id) != null) { return dal.GetModel(Id).TableName; }
            else { return null; }
            
        }
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ROYcms.Sys.Model.ROYcms_Model GetModel(int Id)
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
		public List<ROYcms.Sys.Model.ROYcms_Model> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<ROYcms.Sys.Model.ROYcms_Model> DataTableToList(DataTable dt)
		{
			List<ROYcms.Sys.Model.ROYcms_Model> modelList = new List<ROYcms.Sys.Model.ROYcms_Model>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ROYcms.Sys.Model.ROYcms_Model model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new ROYcms.Sys.Model.ROYcms_Model();
					if(dt.Rows[n]["Id"]!=null && dt.Rows[n]["Id"].ToString()!="")
					{
						model.Id=int.Parse(dt.Rows[n]["Id"].ToString());
					}
					if(dt.Rows[n]["ModelType"]!=null && dt.Rows[n]["ModelType"].ToString()!="")
					{
						model.ModelType=int.Parse(dt.Rows[n]["ModelType"].ToString());
					}
					if(dt.Rows[n]["Name"]!=null && dt.Rows[n]["Name"].ToString()!="")
					{
					model.Name=dt.Rows[n]["Name"].ToString();
					}
					if(dt.Rows[n]["TableName"]!=null && dt.Rows[n]["TableName"].ToString()!="")
					{
					model.TableName=dt.Rows[n]["TableName"].ToString();
					}
					if(dt.Rows[n]["ModelDescription"]!=null && dt.Rows[n]["ModelDescription"].ToString()!="")
					{
					model.ModelDescription=dt.Rows[n]["ModelDescription"].ToString();
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
        public DataSet GetList(int PageSize, int PageIndex, string strWhere)
        {
            return dal.GetList(PageSize, PageIndex, strWhere);
        }

		#endregion  Method
	}
}

