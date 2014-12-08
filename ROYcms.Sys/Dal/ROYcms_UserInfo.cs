using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ROYcms.DB;
namespace ROYcms.Sys.DAL
{
	/// <summary>
	/// 数据访问类:ROYcms_UserInfo
	/// </summary>
	public partial class ROYcms_UserInfo
	{
		public ROYcms_UserInfo()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "ROYcms_UserInfo"); 
		}


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ROYcms_UserInfo");
			strSql.Append(" where Id="+Id+" ");
			return DbHelperSQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(ROYcms.Sys.Model.ROYcms_UserInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			
				strSql1.Append("UserId,");
				strSql2.Append(""+model.UserId+",");
			
		
				strSql1.Append("AccountBalance,");
				strSql2.Append(""+model.AccountBalance+",");
			
			
				strSql1.Append("AvilableBalance,");
				strSql2.Append(""+model.AvilableBalance+",");
		
			
				strSql1.Append("ConsumedAmount,");
				strSql2.Append(""+model.ConsumedAmount+",");
			
			
				strSql1.Append("Money,");
				strSql2.Append(""+model.Money+",");
			
			
				strSql1.Append("GradeID,");
				strSql2.Append(""+model.GradeID+",");
			
			
				strSql1.Append("State,");
				strSql2.Append(""+model.State+",");
			
			if (model.RealName != null)
			{
				strSql1.Append("RealName,");
				strSql2.Append("'"+model.RealName+"',");
			}
			if (model.Qq != null)
			{
				strSql1.Append("Qq,");
				strSql2.Append(""+model.Qq+",");
			}
			if (model.Mobil != null)
			{
				strSql1.Append("Mobil,");
				strSql2.Append("'"+model.Mobil+"',");
			}
			if (model.Tel != null)
			{
				strSql1.Append("Tel,");
				strSql2.Append("'"+model.Tel+"',");
			}
			if (model.Address != null)
			{
				strSql1.Append("Address,");
				strSql2.Append("'"+model.Address+"',");
			}
			if (model.Postcode != null)
			{
				strSql1.Append("Postcode,");
				strSql2.Append("'"+model.Postcode+"',");
			}
			if (model.Website != null)
			{
				strSql1.Append("Website,");
				strSql2.Append("'"+model.Website+"',");
			}
			if (model.IDcardNum != null)
			{
				strSql1.Append("IDcardNum,");
				strSql2.Append("'"+model.IDcardNum+"',");
			}
			if (model.AccountType != null)
			{
				strSql1.Append("AccountType,");
				strSql2.Append(""+model.AccountType+",");
			}
			
				strSql1.Append("SiteID,");
				strSql2.Append(""+model.SiteID+",");
			
			strSql.Append("insert into ROYcms_UserInfo(");
			strSql.Append(strSql1.ToString().Remove(strSql1.Length - 1));
			strSql.Append(")");
			strSql.Append(" values (");
			strSql.Append(strSql2.ToString().Remove(strSql2.Length - 1));
			strSql.Append(")");
			strSql.Append(";select @@IDENTITY");
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
		/// 更新一条数据
		/// </summary>
		public bool Update(ROYcms.Sys.Model.ROYcms_UserInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ROYcms_UserInfo set ");
			
				strSql.Append("UserId="+model.UserId+",");
			
			
				strSql.Append("AccountBalance="+model.AccountBalance+",");
			
			
				strSql.Append("AvilableBalance="+model.AvilableBalance+",");
			
			
				strSql.Append("ConsumedAmount="+model.ConsumedAmount+",");
			
		
				strSql.Append("Money="+model.Money+",");
			
		
				strSql.Append("GradeID="+model.GradeID+",");
			
			
				strSql.Append("State="+model.State+",");
			
			if (model.RealName != null)
			{
				strSql.Append("RealName='"+model.RealName+"',");
			}
			else
			{
				strSql.Append("RealName= null ,");
			}
			if (model.Qq != null)
			{
				strSql.Append("Qq="+model.Qq+",");
			}
			else
			{
				strSql.Append("Qq= null ,");
			}
			if (model.Mobil != null)
			{
				strSql.Append("Mobil='"+model.Mobil+"',");
			}
			else
			{
				strSql.Append("Mobil= null ,");
			}
			if (model.Tel != null)
			{
				strSql.Append("Tel='"+model.Tel+"',");
			}
			else
			{
				strSql.Append("Tel= null ,");
			}
			if (model.Address != null)
			{
				strSql.Append("Address='"+model.Address+"',");
			}
			else
			{
				strSql.Append("Address= null ,");
			}
			if (model.Postcode != null)
			{
				strSql.Append("Postcode='"+model.Postcode+"',");
			}
			else
			{
				strSql.Append("Postcode= null ,");
			}
			if (model.Website != null)
			{
				strSql.Append("Website='"+model.Website+"',");
			}
			else
			{
				strSql.Append("Website= null ,");
			}
			if (model.IDcardNum != null)
			{
				strSql.Append("IDcardNum='"+model.IDcardNum+"',");
			}
			else
			{
				strSql.Append("IDcardNum= null ,");
			}
			if (model.AccountType != null)
			{
				strSql.Append("AccountType="+model.AccountType+",");
			}
			else
			{
				strSql.Append("AccountType= null ,");
			}
		
				strSql.Append("SiteID="+model.SiteID+",");
			
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where Id="+ model.Id+"");
			int rowsAffected=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rowsAffected > 0)
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
			strSql.Append("delete from ROYcms_UserInfo ");
			strSql.Append(" where Id="+Id+"" );
			int rowsAffected=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ROYcms_UserInfo ");
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
		public ROYcms.Sys.Model.ROYcms_UserInfo GetModel(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" Id,UserId,AccountBalance,AvilableBalance,ConsumedAmount,Money,GradeID,State,RealName,Qq,Mobil,Tel,Address,Postcode,Website,IDcardNum,AccountType,SiteID ");
			strSql.Append(" from ROYcms_UserInfo ");
			strSql.Append(" where Id="+Id+"" );
			ROYcms.Sys.Model.ROYcms_UserInfo model=new ROYcms.Sys.Model.ROYcms_UserInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString());
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
			strSql.Append(" FROM ROYcms_UserInfo ");
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
			strSql.Append(" FROM ROYcms_UserInfo ");
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
			strSql.Append("select count(1) FROM ROYcms_UserInfo ");
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
			strSql.Append(")AS Row, T.*  from ROYcms_UserInfo T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		*/

		#endregion  Method
	}
}

