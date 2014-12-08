using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DNSABC.IDAL;
using ROYcms.DB;//Please add references
namespace DNSABC.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:DNSABC_ProductInfo
	/// </summary>
	public partial class DNSABC_ProductInfo:IDNSABC_ProductInfo
	{
		public DNSABC_ProductInfo()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "DNSABC_ProductInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DNSABC_ProductInfo");
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
		public int Add(DNSABC.Model.DNSABC_ProductInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DNSABC_ProductInfo(");
			strSql.Append("ProductType,ProductName,ProductPic,ProductDescription,ProductTableName,MONTH,State,isOrder,Remark,UpdateTime,CreateTime)");
			strSql.Append(" values (");
			strSql.Append("@ProductType,@ProductName,@ProductPic,@ProductDescription,@ProductTableName,@MONTH,@State,@isOrder,@Remark,@UpdateTime,@CreateTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ProductType", SqlDbType.Int,4),
					new SqlParameter("@ProductName", SqlDbType.VarChar,100),
					new SqlParameter("@ProductPic", SqlDbType.VarChar,4000),
					new SqlParameter("@ProductDescription", SqlDbType.VarChar,8000),
					new SqlParameter("@ProductTableName", SqlDbType.VarChar,100),
					new SqlParameter("@MONTH", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@isOrder", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@UpdateTime", SqlDbType.DateTime),
					new SqlParameter("@CreateTime", SqlDbType.DateTime)};
			parameters[0].Value = model.ProductType;
			parameters[1].Value = model.ProductName;
			parameters[2].Value = model.ProductPic;
			parameters[3].Value = model.ProductDescription;
			parameters[4].Value = model.ProductTableName;
			parameters[5].Value = model.MONTH;
			parameters[6].Value = model.State;
			parameters[7].Value = model.isOrder;
			parameters[8].Value = model.Remark;
			parameters[9].Value = model.UpdateTime;
			parameters[10].Value = model.CreateTime;

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
		public bool Update(DNSABC.Model.DNSABC_ProductInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DNSABC_ProductInfo set ");
			strSql.Append("ProductType=@ProductType,");
			strSql.Append("ProductName=@ProductName,");
			strSql.Append("ProductPic=@ProductPic,");
			strSql.Append("ProductDescription=@ProductDescription,");
			strSql.Append("ProductTableName=@ProductTableName,");
			strSql.Append("MONTH=@MONTH,");
			strSql.Append("State=@State,");
			strSql.Append("isOrder=@isOrder,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("UpdateTime=@UpdateTime,");
			strSql.Append("CreateTime=@CreateTime");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@ProductType", SqlDbType.Int,4),
					new SqlParameter("@ProductName", SqlDbType.VarChar,100),
					new SqlParameter("@ProductPic", SqlDbType.VarChar,4000),
					new SqlParameter("@ProductDescription", SqlDbType.VarChar,8000),
					new SqlParameter("@ProductTableName", SqlDbType.VarChar,100),
					new SqlParameter("@MONTH", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@isOrder", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@UpdateTime", SqlDbType.DateTime),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.ProductType;
			parameters[1].Value = model.ProductName;
			parameters[2].Value = model.ProductPic;
			parameters[3].Value = model.ProductDescription;
			parameters[4].Value = model.ProductTableName;
			parameters[5].Value = model.MONTH;
			parameters[6].Value = model.State;
			parameters[7].Value = model.isOrder;
			parameters[8].Value = model.Remark;
			parameters[9].Value = model.UpdateTime;
			parameters[10].Value = model.CreateTime;
			parameters[11].Value = model.Id;

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
			strSql.Append("delete from DNSABC_ProductInfo ");
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
			strSql.Append("delete from DNSABC_ProductInfo ");
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
		public DNSABC.Model.DNSABC_ProductInfo GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,ProductType,ProductName,ProductPic,ProductDescription,ProductTableName,MONTH,State,isOrder,Remark,UpdateTime,CreateTime from DNSABC_ProductInfo ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
};
			parameters[0].Value = Id;

			DNSABC.Model.DNSABC_ProductInfo model=new DNSABC.Model.DNSABC_ProductInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["Id"]!=null && ds.Tables[0].Rows[0]["Id"].ToString()!="")
				{
					model.Id=int.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ProductType"]!=null && ds.Tables[0].Rows[0]["ProductType"].ToString()!="")
				{
					model.ProductType=int.Parse(ds.Tables[0].Rows[0]["ProductType"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ProductName"]!=null && ds.Tables[0].Rows[0]["ProductName"].ToString()!="")
				{
					model.ProductName=ds.Tables[0].Rows[0]["ProductName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ProductPic"]!=null && ds.Tables[0].Rows[0]["ProductPic"].ToString()!="")
				{
					model.ProductPic=ds.Tables[0].Rows[0]["ProductPic"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ProductDescription"]!=null && ds.Tables[0].Rows[0]["ProductDescription"].ToString()!="")
				{
					model.ProductDescription=ds.Tables[0].Rows[0]["ProductDescription"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ProductTableName"]!=null && ds.Tables[0].Rows[0]["ProductTableName"].ToString()!="")
				{
					model.ProductTableName=ds.Tables[0].Rows[0]["ProductTableName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["MONTH"]!=null && ds.Tables[0].Rows[0]["MONTH"].ToString()!="")
				{
					model.MONTH=int.Parse(ds.Tables[0].Rows[0]["MONTH"].ToString());
				}
				if(ds.Tables[0].Rows[0]["State"]!=null && ds.Tables[0].Rows[0]["State"].ToString()!="")
				{
					model.State=int.Parse(ds.Tables[0].Rows[0]["State"].ToString());
				}
				if(ds.Tables[0].Rows[0]["isOrder"]!=null && ds.Tables[0].Rows[0]["isOrder"].ToString()!="")
				{
					model.isOrder=int.Parse(ds.Tables[0].Rows[0]["isOrder"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Remark"]!=null && ds.Tables[0].Rows[0]["Remark"].ToString()!="")
				{
					model.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
				}
				if(ds.Tables[0].Rows[0]["UpdateTime"]!=null && ds.Tables[0].Rows[0]["UpdateTime"].ToString()!="")
				{
					model.UpdateTime=DateTime.Parse(ds.Tables[0].Rows[0]["UpdateTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["CreateTime"]!=null && ds.Tables[0].Rows[0]["CreateTime"].ToString()!="")
				{
					model.CreateTime=DateTime.Parse(ds.Tables[0].Rows[0]["CreateTime"].ToString());
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
			strSql.Append("select Id,ProductType,ProductName,ProductPic,ProductDescription,ProductTableName,MONTH,State,isOrder,Remark,UpdateTime,CreateTime ");
			strSql.Append(" FROM DNSABC_ProductInfo ");
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
			strSql.Append(" Id,ProductType,ProductName,ProductPic,ProductDescription,ProductTableName,MONTH,State,isOrder,Remark,UpdateTime,CreateTime ");
			strSql.Append(" FROM DNSABC_ProductInfo ");
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
			strSql.Append("select count(1) FROM DNSABC_ProductInfo ");
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
			strSql.Append(")AS Row, T.*  from DNSABC_ProductInfo T ");
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
			parameters[0].Value = "DNSABC_ProductInfo";
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

