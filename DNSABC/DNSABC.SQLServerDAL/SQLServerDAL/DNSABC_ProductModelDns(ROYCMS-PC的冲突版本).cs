using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DNSABC.IDAL;
using ROYcms.DB;//Please add references
namespace DNSABC.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:DNSABC_ProductModelDns
	/// </summary>
	public partial class DNSABC_ProductModelDns:IDNSABC_ProductModelDns
	{
		public DNSABC_ProductModelDns()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "DNSABC_ProductModelDns"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DNSABC_ProductModelDns");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
};
			parameters[0].Value = Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(DNSABC.Model.DNSABC_ProductModelDns model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DNSABC_ProductModelDns(");
			strSql.Append("ProductID,isHost,isTtl,isMonitor,isGroupID,Remark)");
			strSql.Append(" values (");
			strSql.Append("@ProductID,@isHost,@isTtl,@isMonitor,@isGroupID,@Remark)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ProductID", SqlDbType.Int,4),
					new SqlParameter("@isHost", SqlDbType.Int,4),
					new SqlParameter("@isTtl", SqlDbType.Int,4),
					new SqlParameter("@isMonitor", SqlDbType.Int,4),
					new SqlParameter("@isGroupID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.VarChar,500)};
			parameters[0].Value = model.ProductID;
			parameters[1].Value = model.isHost;
			parameters[2].Value = model.isTtl;
			parameters[3].Value = model.isMonitor;
			parameters[4].Value = model.isGroupID;
			parameters[5].Value = model.Remark;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(DNSABC.Model.DNSABC_ProductModelDns model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DNSABC_ProductModelDns set ");
			strSql.Append("ProductID=@ProductID,");
			strSql.Append("isHost=@isHost,");
			strSql.Append("isTtl=@isTtl,");
			strSql.Append("isMonitor=@isMonitor,");
			strSql.Append("isGroupID=@isGroupID,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@ProductID", SqlDbType.Int,4),
					new SqlParameter("@isHost", SqlDbType.Int,4),
					new SqlParameter("@isTtl", SqlDbType.Int,4),
					new SqlParameter("@isMonitor", SqlDbType.Int,4),
					new SqlParameter("@isGroupID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.ProductID;
			parameters[1].Value = model.isHost;
			parameters[2].Value = model.isTtl;
			parameters[3].Value = model.isMonitor;
			parameters[4].Value = model.isGroupID;
			parameters[5].Value = model.Remark;
			parameters[6].Value = model.Id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DNSABC_ProductModelDns ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
};
			parameters[0].Value = Id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DNSABC_ProductModelDns ");
			strSql.Append(" where Id in ("+Idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public DNSABC.Model.DNSABC_ProductModelDns GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,ProductID,isHost,isTtl,isMonitor,isGroupID,Remark from DNSABC_ProductModelDns ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
};
			parameters[0].Value = Id;

			DNSABC.Model.DNSABC_ProductModelDns model=new DNSABC.Model.DNSABC_ProductModelDns();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["Id"]!=null && ds.Tables[0].Rows[0]["Id"].ToString()!="")
				{
					model.Id=int.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ProductID"]!=null && ds.Tables[0].Rows[0]["ProductID"].ToString()!="")
				{
					model.ProductID=int.Parse(ds.Tables[0].Rows[0]["ProductID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["isHost"]!=null && ds.Tables[0].Rows[0]["isHost"].ToString()!="")
				{
					model.isHost=int.Parse(ds.Tables[0].Rows[0]["isHost"].ToString());
				}
				if(ds.Tables[0].Rows[0]["isTtl"]!=null && ds.Tables[0].Rows[0]["isTtl"].ToString()!="")
				{
					model.isTtl=int.Parse(ds.Tables[0].Rows[0]["isTtl"].ToString());
				}
				if(ds.Tables[0].Rows[0]["isMonitor"]!=null && ds.Tables[0].Rows[0]["isMonitor"].ToString()!="")
				{
					model.isMonitor=int.Parse(ds.Tables[0].Rows[0]["isMonitor"].ToString());
				}
				if(ds.Tables[0].Rows[0]["isGroupID"]!=null && ds.Tables[0].Rows[0]["isGroupID"].ToString()!="")
				{
					model.isGroupID=int.Parse(ds.Tables[0].Rows[0]["isGroupID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Remark"]!=null && ds.Tables[0].Rows[0]["Remark"].ToString()!="")
				{
					model.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
				}
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,ProductID,isHost,isTtl,isMonitor,isGroupID,Remark ");
			strSql.Append(" FROM DNSABC_ProductModelDns ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" Id,ProductID,isHost,isTtl,isMonitor,isGroupID,Remark ");
			strSql.Append(" FROM DNSABC_ProductModelDns ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM DNSABC_ProductModelDns ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.Id desc");
			}
			strSql.Append(")AS Row, T.*  from DNSABC_ProductModelDns T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "DNSABC_ProductModelDns";
			parameters[1].Value = "Id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method
	}
}

