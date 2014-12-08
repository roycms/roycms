using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DNSABC.IDAL;
using ROYcms.DB;//Please add references
namespace DNSABC.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:DNSABC_Invoice
	/// </summary>
	public partial class DNSABC_Invoice:IDNSABC_Invoice
	{
		public DNSABC_Invoice()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "DNSABC_Invoice"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DNSABC_Invoice");
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
		public int Add(DNSABC.Model.DNSABC_Invoice model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DNSABC_Invoice(");
			strSql.Append("UserID,InvoiceName,Price,PostType,RealName,Tel,Mobil,Address,PostCode,Remark,State,AdminRemark,CreateTime)");
			strSql.Append(" values (");
			strSql.Append("@UserID,@InvoiceName,@Price,@PostType,@RealName,@Tel,@Mobil,@Address,@PostCode,@Remark,@State,@AdminRemark,@CreateTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@InvoiceName", SqlDbType.VarChar,200),
					new SqlParameter("@Price", SqlDbType.Int,4),
					new SqlParameter("@PostType", SqlDbType.Int,4),
					new SqlParameter("@RealName", SqlDbType.VarChar,50),
					new SqlParameter("@Tel", SqlDbType.VarChar,20),
					new SqlParameter("@Mobil", SqlDbType.VarChar,20),
					new SqlParameter("@Address", SqlDbType.VarChar,500),
					new SqlParameter("@PostCode", SqlDbType.VarChar,20),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@AdminRemark", SqlDbType.VarChar,500),
					new SqlParameter("@CreateTime", SqlDbType.DateTime)};
			parameters[0].Value = model.UserID;
			parameters[1].Value = model.InvoiceName;
			parameters[2].Value = model.Price;
			parameters[3].Value = model.PostType;
			parameters[4].Value = model.RealName;
			parameters[5].Value = model.Tel;
			parameters[6].Value = model.Mobil;
			parameters[7].Value = model.Address;
			parameters[8].Value = model.PostCode;
			parameters[9].Value = model.Remark;
			parameters[10].Value = model.State;
			parameters[11].Value = model.AdminRemark;
			parameters[12].Value = model.CreateTime;

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
		public bool Update(DNSABC.Model.DNSABC_Invoice model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DNSABC_Invoice set ");
			strSql.Append("UserID=@UserID,");
			strSql.Append("InvoiceName=@InvoiceName,");
			strSql.Append("Price=@Price,");
			strSql.Append("PostType=@PostType,");
			strSql.Append("RealName=@RealName,");
			strSql.Append("Tel=@Tel,");
			strSql.Append("Mobil=@Mobil,");
			strSql.Append("Address=@Address,");
			strSql.Append("PostCode=@PostCode,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("State=@State,");
			strSql.Append("AdminRemark=@AdminRemark,");
			strSql.Append("CreateTime=@CreateTime");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@InvoiceName", SqlDbType.VarChar,200),
					new SqlParameter("@Price", SqlDbType.Int,4),
					new SqlParameter("@PostType", SqlDbType.Int,4),
					new SqlParameter("@RealName", SqlDbType.VarChar,50),
					new SqlParameter("@Tel", SqlDbType.VarChar,20),
					new SqlParameter("@Mobil", SqlDbType.VarChar,20),
					new SqlParameter("@Address", SqlDbType.VarChar,500),
					new SqlParameter("@PostCode", SqlDbType.VarChar,20),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@AdminRemark", SqlDbType.VarChar,500),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.UserID;
			parameters[1].Value = model.InvoiceName;
			parameters[2].Value = model.Price;
			parameters[3].Value = model.PostType;
			parameters[4].Value = model.RealName;
			parameters[5].Value = model.Tel;
			parameters[6].Value = model.Mobil;
			parameters[7].Value = model.Address;
			parameters[8].Value = model.PostCode;
			parameters[9].Value = model.Remark;
			parameters[10].Value = model.State;
			parameters[11].Value = model.AdminRemark;
			parameters[12].Value = model.CreateTime;
			parameters[13].Value = model.Id;

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
			strSql.Append("delete from DNSABC_Invoice ");
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
			strSql.Append("delete from DNSABC_Invoice ");
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
		public DNSABC.Model.DNSABC_Invoice GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,UserID,InvoiceName,Price,PostType,RealName,Tel,Mobil,Address,PostCode,Remark,State,AdminRemark,CreateTime from DNSABC_Invoice ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
};
			parameters[0].Value = Id;

			DNSABC.Model.DNSABC_Invoice model=new DNSABC.Model.DNSABC_Invoice();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["Id"]!=null && ds.Tables[0].Rows[0]["Id"].ToString()!="")
				{
					model.Id=int.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["UserID"]!=null && ds.Tables[0].Rows[0]["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(ds.Tables[0].Rows[0]["UserID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["InvoiceName"]!=null && ds.Tables[0].Rows[0]["InvoiceName"].ToString()!="")
				{
					model.InvoiceName=ds.Tables[0].Rows[0]["InvoiceName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Price"]!=null && ds.Tables[0].Rows[0]["Price"].ToString()!="")
				{
					model.Price=int.Parse(ds.Tables[0].Rows[0]["Price"].ToString());
				}
				if(ds.Tables[0].Rows[0]["PostType"]!=null && ds.Tables[0].Rows[0]["PostType"].ToString()!="")
				{
					model.PostType=int.Parse(ds.Tables[0].Rows[0]["PostType"].ToString());
				}
				if(ds.Tables[0].Rows[0]["RealName"]!=null && ds.Tables[0].Rows[0]["RealName"].ToString()!="")
				{
					model.RealName=ds.Tables[0].Rows[0]["RealName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Tel"]!=null && ds.Tables[0].Rows[0]["Tel"].ToString()!="")
				{
					model.Tel=ds.Tables[0].Rows[0]["Tel"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Mobil"]!=null && ds.Tables[0].Rows[0]["Mobil"].ToString()!="")
				{
					model.Mobil=ds.Tables[0].Rows[0]["Mobil"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Address"]!=null && ds.Tables[0].Rows[0]["Address"].ToString()!="")
				{
					model.Address=ds.Tables[0].Rows[0]["Address"].ToString();
				}
				if(ds.Tables[0].Rows[0]["PostCode"]!=null && ds.Tables[0].Rows[0]["PostCode"].ToString()!="")
				{
					model.PostCode=ds.Tables[0].Rows[0]["PostCode"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Remark"]!=null && ds.Tables[0].Rows[0]["Remark"].ToString()!="")
				{
					model.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
				}
				if(ds.Tables[0].Rows[0]["State"]!=null && ds.Tables[0].Rows[0]["State"].ToString()!="")
				{
					model.State=int.Parse(ds.Tables[0].Rows[0]["State"].ToString());
				}
				if(ds.Tables[0].Rows[0]["AdminRemark"]!=null && ds.Tables[0].Rows[0]["AdminRemark"].ToString()!="")
				{
					model.AdminRemark=ds.Tables[0].Rows[0]["AdminRemark"].ToString();
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
			strSql.Append("select Id,UserID,InvoiceName,Price,PostType,RealName,Tel,Mobil,Address,PostCode,Remark,State,AdminRemark,CreateTime ");
			strSql.Append(" FROM DNSABC_Invoice ");
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
			strSql.Append(" Id,UserID,InvoiceName,Price,PostType,RealName,Tel,Mobil,Address,PostCode,Remark,State,AdminRemark,CreateTime ");
			strSql.Append(" FROM DNSABC_Invoice ");
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
			strSql.Append("select count(1) FROM DNSABC_Invoice ");
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
			strSql.Append(")AS Row, T.*  from DNSABC_Invoice T ");
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
			parameters[0].Value = "DNSABC_Invoice";
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

