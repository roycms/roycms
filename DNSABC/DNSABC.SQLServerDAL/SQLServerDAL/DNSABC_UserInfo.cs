using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DNSABC.IDAL;
using ROYcms.DB;//Please add references
namespace DNSABC.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:DNSABC_UserInfo
	/// </summary>
	public partial class DNSABC_UserInfo:IDNSABC_UserInfo
	{
		public DNSABC_UserInfo()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "DNSABC_UserInfo"); 
            
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DNSABC_UserInfo");
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
		public int Add(DNSABC.Model.DNSABC_UserInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DNSABC_UserInfo(");
			strSql.Append("UserId,AccountBalance,AvilableBalance,ConsumedAmount,Money,GradeID,State,RealName,Qq,Mobil,Tel,Address,Postcode,Website,IDcardNum,AccountType,SiteID)");
			strSql.Append(" values (");
			strSql.Append("@UserId,@AccountBalance,@AvilableBalance,@ConsumedAmount,@Money,@GradeID,@State,@RealName,@Qq,@Mobil,@Tel,@Address,@Postcode,@Website,@IDcardNum,@AccountType,@SiteID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@UserId", SqlDbType.Int,4),
					new SqlParameter("@AccountBalance", SqlDbType.Int,4),
					new SqlParameter("@AvilableBalance", SqlDbType.Int,4),
					new SqlParameter("@ConsumedAmount", SqlDbType.Int,4),
					new SqlParameter("@Money", SqlDbType.Int,4),
					new SqlParameter("@GradeID", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@RealName", SqlDbType.VarChar,50),
					new SqlParameter("@Qq", SqlDbType.Int,4),
					new SqlParameter("@Mobil", SqlDbType.VarChar,20),
					new SqlParameter("@Tel", SqlDbType.VarChar,20),
					new SqlParameter("@Address", SqlDbType.VarChar,200),
					new SqlParameter("@Postcode", SqlDbType.VarChar,20),
					new SqlParameter("@Website", SqlDbType.VarChar,200),
					new SqlParameter("@IDcardNum", SqlDbType.VarChar,20),
					new SqlParameter("@AccountType", SqlDbType.Int,4),
					new SqlParameter("@SiteID", SqlDbType.Int,4)};
			parameters[0].Value = model.UserId;
			parameters[1].Value = model.AccountBalance;
			parameters[2].Value = model.AvilableBalance;
			parameters[3].Value = model.ConsumedAmount;
			parameters[4].Value = model.Money;
			parameters[5].Value = model.GradeID;
			parameters[6].Value = model.State;
			parameters[7].Value = model.RealName;
			parameters[8].Value = model.Qq;
			parameters[9].Value = model.Mobil;
			parameters[10].Value = model.Tel;
			parameters[11].Value = model.Address;
			parameters[12].Value = model.Postcode;
			parameters[13].Value = model.Website;
			parameters[14].Value = model.IDcardNum;
			parameters[15].Value = model.AccountType;
			parameters[16].Value = model.SiteID;

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
		public bool Update(DNSABC.Model.DNSABC_UserInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DNSABC_UserInfo set ");
			strSql.Append("UserId=@UserId,");
			strSql.Append("AccountBalance=@AccountBalance,");
			strSql.Append("AvilableBalance=@AvilableBalance,");
			strSql.Append("ConsumedAmount=@ConsumedAmount,");
			strSql.Append("Money=@Money,");
			strSql.Append("GradeID=@GradeID,");
			strSql.Append("State=@State,");
			strSql.Append("RealName=@RealName,");
			strSql.Append("Qq=@Qq,");
			strSql.Append("Mobil=@Mobil,");
			strSql.Append("Tel=@Tel,");
			strSql.Append("Address=@Address,");
			strSql.Append("Postcode=@Postcode,");
			strSql.Append("Website=@Website,");
			strSql.Append("IDcardNum=@IDcardNum,");
			strSql.Append("AccountType=@AccountType,");
			strSql.Append("SiteID=@SiteID");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@UserId", SqlDbType.Int,4),
					new SqlParameter("@AccountBalance", SqlDbType.Int,4),
					new SqlParameter("@AvilableBalance", SqlDbType.Int,4),
					new SqlParameter("@ConsumedAmount", SqlDbType.Int,4),
					new SqlParameter("@Money", SqlDbType.Int,4),
					new SqlParameter("@GradeID", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@RealName", SqlDbType.VarChar,50),
					new SqlParameter("@Qq", SqlDbType.Int,4),
					new SqlParameter("@Mobil", SqlDbType.VarChar,20),
					new SqlParameter("@Tel", SqlDbType.VarChar,20),
					new SqlParameter("@Address", SqlDbType.VarChar,200),
					new SqlParameter("@Postcode", SqlDbType.VarChar,20),
					new SqlParameter("@Website", SqlDbType.VarChar,200),
					new SqlParameter("@IDcardNum", SqlDbType.VarChar,20),
					new SqlParameter("@AccountType", SqlDbType.Int,4),
					new SqlParameter("@SiteID", SqlDbType.Int,4),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.UserId;
			parameters[1].Value = model.AccountBalance;
			parameters[2].Value = model.AvilableBalance;
			parameters[3].Value = model.ConsumedAmount;
			parameters[4].Value = model.Money;
			parameters[5].Value = model.GradeID;
			parameters[6].Value = model.State;
			parameters[7].Value = model.RealName;
			parameters[8].Value = model.Qq;
			parameters[9].Value = model.Mobil;
			parameters[10].Value = model.Tel;
			parameters[11].Value = model.Address;
			parameters[12].Value = model.Postcode;
			parameters[13].Value = model.Website;
			parameters[14].Value = model.IDcardNum;
			parameters[15].Value = model.AccountType;
			parameters[16].Value = model.SiteID;
			parameters[17].Value = model.Id;

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
			strSql.Append("delete from DNSABC_UserInfo ");
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
			strSql.Append("delete from DNSABC_UserInfo ");
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
		public DNSABC.Model.DNSABC_UserInfo GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,UserId,AccountBalance,AvilableBalance,ConsumedAmount,Money,GradeID,State,RealName,Qq,Mobil,Tel,Address,Postcode,Website,IDcardNum,AccountType,SiteID from DNSABC_UserInfo ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
};
			parameters[0].Value = Id;

			DNSABC.Model.DNSABC_UserInfo model=new DNSABC.Model.DNSABC_UserInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["Id"]!=null && ds.Tables[0].Rows[0]["Id"].ToString()!="")
				{
					model.Id=int.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["UserId"]!=null && ds.Tables[0].Rows[0]["UserId"].ToString()!="")
				{
					model.UserId=int.Parse(ds.Tables[0].Rows[0]["UserId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["AccountBalance"]!=null && ds.Tables[0].Rows[0]["AccountBalance"].ToString()!="")
				{
					model.AccountBalance=int.Parse(ds.Tables[0].Rows[0]["AccountBalance"].ToString());
				}
				if(ds.Tables[0].Rows[0]["AvilableBalance"]!=null && ds.Tables[0].Rows[0]["AvilableBalance"].ToString()!="")
				{
					model.AvilableBalance=int.Parse(ds.Tables[0].Rows[0]["AvilableBalance"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ConsumedAmount"]!=null && ds.Tables[0].Rows[0]["ConsumedAmount"].ToString()!="")
				{
					model.ConsumedAmount=int.Parse(ds.Tables[0].Rows[0]["ConsumedAmount"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Money"]!=null && ds.Tables[0].Rows[0]["Money"].ToString()!="")
				{
					model.Money=int.Parse(ds.Tables[0].Rows[0]["Money"].ToString());
				}
				if(ds.Tables[0].Rows[0]["GradeID"]!=null && ds.Tables[0].Rows[0]["GradeID"].ToString()!="")
				{
					model.GradeID=int.Parse(ds.Tables[0].Rows[0]["GradeID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["State"]!=null && ds.Tables[0].Rows[0]["State"].ToString()!="")
				{
					model.State=int.Parse(ds.Tables[0].Rows[0]["State"].ToString());
				}
				if(ds.Tables[0].Rows[0]["RealName"]!=null && ds.Tables[0].Rows[0]["RealName"].ToString()!="")
				{
					model.RealName=ds.Tables[0].Rows[0]["RealName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Qq"]!=null && ds.Tables[0].Rows[0]["Qq"].ToString()!="")
				{
					model.Qq=int.Parse(ds.Tables[0].Rows[0]["Qq"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Mobil"]!=null && ds.Tables[0].Rows[0]["Mobil"].ToString()!="")
				{
					model.Mobil=ds.Tables[0].Rows[0]["Mobil"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Tel"]!=null && ds.Tables[0].Rows[0]["Tel"].ToString()!="")
				{
					model.Tel=ds.Tables[0].Rows[0]["Tel"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Address"]!=null && ds.Tables[0].Rows[0]["Address"].ToString()!="")
				{
					model.Address=ds.Tables[0].Rows[0]["Address"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Postcode"]!=null && ds.Tables[0].Rows[0]["Postcode"].ToString()!="")
				{
					model.Postcode=ds.Tables[0].Rows[0]["Postcode"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Website"]!=null && ds.Tables[0].Rows[0]["Website"].ToString()!="")
				{
					model.Website=ds.Tables[0].Rows[0]["Website"].ToString();
				}
				if(ds.Tables[0].Rows[0]["IDcardNum"]!=null && ds.Tables[0].Rows[0]["IDcardNum"].ToString()!="")
				{
					model.IDcardNum=ds.Tables[0].Rows[0]["IDcardNum"].ToString();
				}
				if(ds.Tables[0].Rows[0]["AccountType"]!=null && ds.Tables[0].Rows[0]["AccountType"].ToString()!="")
				{
					model.AccountType=int.Parse(ds.Tables[0].Rows[0]["AccountType"].ToString());
				}
				if(ds.Tables[0].Rows[0]["SiteID"]!=null && ds.Tables[0].Rows[0]["SiteID"].ToString()!="")
				{
					model.SiteID=int.Parse(ds.Tables[0].Rows[0]["SiteID"].ToString());
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
			strSql.Append("select Id,UserId,AccountBalance,AvilableBalance,ConsumedAmount,Money,GradeID,State,RealName,Qq,Mobil,Tel,Address,Postcode,Website,IDcardNum,AccountType,SiteID ");
			strSql.Append(" FROM DNSABC_UserInfo ");
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
			strSql.Append(" Id,UserId,AccountBalance,AvilableBalance,ConsumedAmount,Money,GradeID,State,RealName,Qq,Mobil,Tel,Address,Postcode,Website,IDcardNum,AccountType,SiteID ");
			strSql.Append(" FROM DNSABC_UserInfo ");
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
			strSql.Append("select count(1) FROM DNSABC_UserInfo ");
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
			strSql.Append(")AS Row, T.*  from DNSABC_UserInfo T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		
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
			parameters[0].Value = "DNSABC_UserInfo";
			parameters[1].Value = "Id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}

		#endregion  Method
	}
}

