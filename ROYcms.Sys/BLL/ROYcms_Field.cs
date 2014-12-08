using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Sys.Model;
namespace ROYcms.Sys.BLL
{
	/// <summary>
	/// 自定义字段的字段表 
	/// </summary>
	public partial class ROYcms_Field
	{
		private readonly ROYcms.Sys.DAL.ROYcms_Field dal=new ROYcms.Sys.DAL.ROYcms_Field();
		public ROYcms_Field()
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
        /// 初始化一模型必有的默认字段
        /// </summary>
        public int FieldInitialization(int Rid)
        {
            return dal.FieldInitialization(Rid);
        }
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(ROYcms.Sys.Model.ROYcms_Field model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(ROYcms.Sys.Model.ROYcms_Field model)
		{
			return dal.Update(model);
		}
         /// <summary>
        /// 修改字段的排列顺序
        /// </summary>
        public bool UpdateOrderBy(int Id, int OrderBy)
        {
            return dal.UpdateOrderBy(Id, OrderBy);
        }
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Id)
		{
			
			return dal.Delete(Id);
		}
        /// <summary>
        /// 删除一条数据 根据模型ID
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
		public ROYcms.Sys.Model.ROYcms_Field GetModel(int Id)
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
		public List<ROYcms.Sys.Model.ROYcms_Field> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<ROYcms.Sys.Model.ROYcms_Field> DataTableToList(DataTable dt)
		{
			List<ROYcms.Sys.Model.ROYcms_Field> modelList = new List<ROYcms.Sys.Model.ROYcms_Field>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ROYcms.Sys.Model.ROYcms_Field model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new ROYcms.Sys.Model.ROYcms_Field();
					if(dt.Rows[n]["Id"]!=null && dt.Rows[n]["Id"].ToString()!="")
					{
						model.Id=int.Parse(dt.Rows[n]["Id"].ToString());
					}
					if(dt.Rows[n]["Rid"]!=null && dt.Rows[n]["Rid"].ToString()!="")
					{
						model.Rid=int.Parse(dt.Rows[n]["Rid"].ToString());
					}
					if(dt.Rows[n]["Name"]!=null && dt.Rows[n]["Name"].ToString()!="")
					{
					model.Name=dt.Rows[n]["Name"].ToString();
					}
					if(dt.Rows[n]["Lable"]!=null && dt.Rows[n]["Lable"].ToString()!="")
					{
					model.Lable=dt.Rows[n]["Lable"].ToString();
					}
					if(dt.Rows[n]["Len"]!=null && dt.Rows[n]["Len"].ToString()!="")
					{
						model.Len=int.Parse(dt.Rows[n]["Len"].ToString());
					}
					if(dt.Rows[n]["FieldType"]!=null && dt.Rows[n]["FieldType"].ToString()!="")
					{
						model.FieldType=int.Parse(dt.Rows[n]["FieldType"].ToString());
					}
					if(dt.Rows[n]["IsNull"]!=null && dt.Rows[n]["IsNull"].ToString()!="")
					{
						model.IsNull=int.Parse(dt.Rows[n]["IsNull"].ToString());
					}
					if(dt.Rows[n]["IsKey"]!=null && dt.Rows[n]["IsKey"].ToString()!="")
					{
						model.IsKey=int.Parse(dt.Rows[n]["IsKey"].ToString());
					}
					if(dt.Rows[n]["DefaultVal"]!=null && dt.Rows[n]["DefaultVal"].ToString()!="")
					{
					model.DefaultVal=dt.Rows[n]["DefaultVal"].ToString();
					}
					if(dt.Rows[n]["Display"]!=null && dt.Rows[n]["Display"].ToString()!="")
					{
						model.Display=int.Parse(dt.Rows[n]["Display"].ToString());
					}
					if(dt.Rows[n]["Expression"]!=null && dt.Rows[n]["Expression"].ToString()!="")
					{
					model.Expression=dt.Rows[n]["Expression"].ToString();
					}
					if(dt.Rows[n]["InputType"]!=null && dt.Rows[n]["InputType"].ToString()!="")
					{
					model.InputType=dt.Rows[n]["InputType"].ToString();
					}
					if(dt.Rows[n]["InputLen"]!=null && dt.Rows[n]["InputLen"].ToString()!="")
					{
						model.InputLen=int.Parse(dt.Rows[n]["InputLen"].ToString());
					}
					if(dt.Rows[n]["OrderBy"]!=null && dt.Rows[n]["OrderBy"].ToString()!="")
					{
						model.OrderBy=int.Parse(dt.Rows[n]["OrderBy"].ToString());
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
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  Method
	}
}

