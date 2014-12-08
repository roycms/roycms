using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Sys.Model;
using System.Web;
namespace ROYcms.Sys.BLL
{
	/// <summary>
	/// ROYcms_Log
	/// </summary>
	public partial class ROYcms_Log
	{
		private readonly ROYcms.Sys.DAL.ROYcms_Log dal=new ROYcms.Sys.DAL.ROYcms_Log();
		public ROYcms_Log()
		{}
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			return dal.Exists(id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ROYcms.Sys.Model.ROYcms_Log model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(ROYcms.Sys.Model.ROYcms_Log model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			return dal.Delete(id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			return dal.DeleteList(idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ROYcms.Sys.Model.ROYcms_Log GetModel(int id)
		{
			
			return dal.GetModel(id);
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
        /// <summary>
        /// 日志写入
        /// </summary>
        /// <param name="Err_id">标识 1管理员登录 2普通会员登录 3管理员操作日志 4普通会员操作日志 5错误日志 </param>
        /// <param name="Event">日志事件名称</param>
        /// <param name="Content">日志内容</param>
        public void InsertSystemLog(string Err_id, string Event, string Content)
        {
            ROYcms.Sys.Model.ROYcms_Log model = new Model.ROYcms_Log();
            try
            {
                model.Err_id = Err_id;
                model.Event = Event;
                model.Content = Content + "[" + HttpContext.Current.Request.Url.ToString() + "]";
                if (ROYcms.Common.Session.Get("administrator_id") != null)
                {
                    model.Admin_id = Convert.ToInt32(ROYcms.Common.Session.Get("administrator_id"));
                }
                if (ROYcms.Common.Session.Get("user_id") != null)
                {
                    model.User_id = Convert.ToInt32(ROYcms.Common.Session.Get("user_id"));
                }
                model.Ip = ROYcms.Common.SystemCms.GetClientIPv4(); //IP地址
                model.Time = DateTime.Now;
                dal.Add(model);
            }
            catch
            {
                ROYcms.Common.SystemCms.InsertErrLog("写入错误日志失败", HttpContext.Current.Request.Url.ToString());
            }
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
		public List<ROYcms.Sys.Model.ROYcms_Log> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<ROYcms.Sys.Model.ROYcms_Log> DataTableToList(DataTable dt)
		{
			List<ROYcms.Sys.Model.ROYcms_Log> modelList = new List<ROYcms.Sys.Model.ROYcms_Log>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ROYcms.Sys.Model.ROYcms_Log model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new ROYcms.Sys.Model.ROYcms_Log();
					if(dt.Rows[n]["id"]!=null && dt.Rows[n]["id"].ToString()!="")
					{
						model.id=int.Parse(dt.Rows[n]["id"].ToString());
					}
					if(dt.Rows[n]["User_id"]!=null && dt.Rows[n]["User_id"].ToString()!="")
					{
						model.User_id=int.Parse(dt.Rows[n]["User_id"].ToString());
					}
					if(dt.Rows[n]["Admin_id"]!=null && dt.Rows[n]["Admin_id"].ToString()!="")
					{
						model.Admin_id=int.Parse(dt.Rows[n]["Admin_id"].ToString());
					}
					if(dt.Rows[n]["Err_id"]!=null && dt.Rows[n]["Err_id"].ToString()!="")
					{
					model.Err_id=dt.Rows[n]["Err_id"].ToString();
					}
					if(dt.Rows[n]["Event"]!=null && dt.Rows[n]["Event"].ToString()!="")
					{
					model.Event=dt.Rows[n]["Event"].ToString();
					}
					if(dt.Rows[n]["Content"]!=null && dt.Rows[n]["Content"].ToString()!="")
					{
					model.Content=dt.Rows[n]["Content"].ToString();
					}
					if(dt.Rows[n]["Time"]!=null && dt.Rows[n]["Time"].ToString()!="")
					{
						model.Time=DateTime.Parse(dt.Rows[n]["Time"].ToString());
					}
					if(dt.Rows[n]["Ip"]!=null && dt.Rows[n]["Ip"].ToString()!="")
					{
					model.Ip=dt.Rows[n]["Ip"].ToString();
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public int GetCount(string where)
        {
            return dal.GetCount(where);
        }
    }
}

