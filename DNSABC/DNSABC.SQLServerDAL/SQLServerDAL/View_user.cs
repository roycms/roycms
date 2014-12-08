using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DNSABC.IDAL;
using ROYcms.DB;
namespace DNSABC.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:View_user
	/// </summary>
	public partial class View_user:IView_user
	{
		public View_user()
		{}
		#region  Method



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(DNSABC.Model.View_user model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into View_user(");
			strSql.Append("Id,UserId,AccountBalance,AvilableBalance,ConsumedAmount,GradeID,State,RealName,Qq,Mobil,Tel,Address,Postcode,Website,IDcardNum,AccountType,SiteID,bh,RoleID,UgroupID,name,PASSWORD,email,age,login_time,sex,pic,quanxian,username,GUID,IP)");
			strSql.Append(" values (");
			strSql.Append("@Id,@UserId,@AccountBalance,@AvilableBalance,@ConsumedAmount,@GradeID,@State,@RealName,@Qq,@Mobil,@Tel,@Address,@Postcode,@Website,@IDcardNum,@AccountType,@SiteID,@bh,@RoleID,@UgroupID,@name,@PASSWORD,@email,@age,@login_time,@sex,@pic,@quanxian,@username,@GUID,@IP)");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@UserId", SqlDbType.Int,4),
					new SqlParameter("@AccountBalance", SqlDbType.Int,4),
					new SqlParameter("@AvilableBalance", SqlDbType.Int,4),
					new SqlParameter("@ConsumedAmount", SqlDbType.Int,4),
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
					new SqlParameter("@bh", SqlDbType.Int,4),
					new SqlParameter("@RoleID", SqlDbType.VarChar,50),
					new SqlParameter("@UgroupID", SqlDbType.VarChar,50),
					new SqlParameter("@name", SqlDbType.VarChar,50),
					new SqlParameter("@PASSWORD", SqlDbType.VarChar,50),
					new SqlParameter("@email", SqlDbType.VarChar,50),
					new SqlParameter("@age", SqlDbType.Int,4),
					new SqlParameter("@login_time", SqlDbType.DateTime),
					new SqlParameter("@sex", SqlDbType.VarChar,10),
					new SqlParameter("@pic", SqlDbType.VarChar,100),
					new SqlParameter("@quanxian", SqlDbType.VarChar,50),
					new SqlParameter("@username", SqlDbType.VarChar,50),
					new SqlParameter("@GUID", SqlDbType.VarChar,50),
					new SqlParameter("@IP", SqlDbType.VarChar,50)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.UserId;
			parameters[2].Value = model.AccountBalance;
			parameters[3].Value = model.AvilableBalance;
			parameters[4].Value = model.ConsumedAmount;
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
			parameters[17].Value = model.bh;
			parameters[18].Value = model.RoleID;
			parameters[19].Value = model.UgroupID;
			parameters[20].Value = model.name;
			parameters[21].Value = model.PASSWORD;
			parameters[22].Value = model.email;
			parameters[23].Value = model.age;
			parameters[24].Value = model.login_time;
			parameters[25].Value = model.sex;
			parameters[26].Value = model.pic;
			parameters[27].Value = model.quanxian;
			parameters[28].Value = model.username;
			parameters[29].Value = model.GUID;
			parameters[30].Value = model.IP;

			int rows=ROYcms.DB.DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		/// 更新一条数据
		/// </summary>
		public bool Update(DNSABC.Model.View_user model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update View_user set ");
			strSql.Append("Id=@Id,");
			strSql.Append("UserId=@UserId,");
			strSql.Append("AccountBalance=@AccountBalance,");
			strSql.Append("AvilableBalance=@AvilableBalance,");
			strSql.Append("ConsumedAmount=@ConsumedAmount,");
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
			strSql.Append("SiteID=@SiteID,");
			strSql.Append("bh=@bh,");
			strSql.Append("RoleID=@RoleID,");
			strSql.Append("UgroupID=@UgroupID,");
			strSql.Append("name=@name,");
			strSql.Append("PASSWORD=@PASSWORD,");
			strSql.Append("email=@email,");
			strSql.Append("age=@age,");
			strSql.Append("login_time=@login_time,");
			strSql.Append("sex=@sex,");
			strSql.Append("pic=@pic,");
			strSql.Append("quanxian=@quanxian,");
			strSql.Append("username=@username,");
			strSql.Append("GUID=@GUID,");
			strSql.Append("IP=@IP");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@UserId", SqlDbType.Int,4),
					new SqlParameter("@AccountBalance", SqlDbType.Int,4),
					new SqlParameter("@AvilableBalance", SqlDbType.Int,4),
					new SqlParameter("@ConsumedAmount", SqlDbType.Int,4),
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
					new SqlParameter("@bh", SqlDbType.Int,4),
					new SqlParameter("@RoleID", SqlDbType.VarChar,50),
					new SqlParameter("@UgroupID", SqlDbType.VarChar,50),
					new SqlParameter("@name", SqlDbType.VarChar,50),
					new SqlParameter("@PASSWORD", SqlDbType.VarChar,50),
					new SqlParameter("@email", SqlDbType.VarChar,50),
					new SqlParameter("@age", SqlDbType.Int,4),
					new SqlParameter("@login_time", SqlDbType.DateTime),
					new SqlParameter("@sex", SqlDbType.VarChar,10),
					new SqlParameter("@pic", SqlDbType.VarChar,100),
					new SqlParameter("@quanxian", SqlDbType.VarChar,50),
					new SqlParameter("@username", SqlDbType.VarChar,50),
					new SqlParameter("@GUID", SqlDbType.VarChar,50),
					new SqlParameter("@IP", SqlDbType.VarChar,50)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.UserId;
			parameters[2].Value = model.AccountBalance;
			parameters[3].Value = model.AvilableBalance;
			parameters[4].Value = model.ConsumedAmount;
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
			parameters[17].Value = model.bh;
			parameters[18].Value = model.RoleID;
			parameters[19].Value = model.UgroupID;
			parameters[20].Value = model.name;
			parameters[21].Value = model.PASSWORD;
			parameters[22].Value = model.email;
			parameters[23].Value = model.age;
			parameters[24].Value = model.login_time;
			parameters[25].Value = model.sex;
			parameters[26].Value = model.pic;
			parameters[27].Value = model.quanxian;
			parameters[28].Value = model.username;
			parameters[29].Value = model.GUID;
			parameters[30].Value = model.IP;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from View_user ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
};

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
		/// 得到一个对象实体
		/// </summary>
		public DNSABC.Model.View_user GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,UserId,AccountBalance,AvilableBalance,ConsumedAmount,GradeID,State,RealName,Qq,Mobil,Tel,Address,Postcode,Website,IDcardNum,AccountType,SiteID,bh,RoleID,UgroupID,name,PASSWORD,email,age,login_time,sex,pic,quanxian,username,GUID,IP from View_user ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
};

			DNSABC.Model.View_user model=new DNSABC.Model.View_user();
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
				if(ds.Tables[0].Rows[0]["bh"]!=null && ds.Tables[0].Rows[0]["bh"].ToString()!="")
				{
					model.bh=int.Parse(ds.Tables[0].Rows[0]["bh"].ToString());
				}
				if(ds.Tables[0].Rows[0]["RoleID"]!=null && ds.Tables[0].Rows[0]["RoleID"].ToString()!="")
				{
					model.RoleID=ds.Tables[0].Rows[0]["RoleID"].ToString();
				}
				if(ds.Tables[0].Rows[0]["UgroupID"]!=null && ds.Tables[0].Rows[0]["UgroupID"].ToString()!="")
				{
					model.UgroupID=ds.Tables[0].Rows[0]["UgroupID"].ToString();
				}
				if(ds.Tables[0].Rows[0]["name"]!=null && ds.Tables[0].Rows[0]["name"].ToString()!="")
				{
					model.name=ds.Tables[0].Rows[0]["name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["PASSWORD"]!=null && ds.Tables[0].Rows[0]["PASSWORD"].ToString()!="")
				{
					model.PASSWORD=ds.Tables[0].Rows[0]["PASSWORD"].ToString();
				}
				if(ds.Tables[0].Rows[0]["email"]!=null && ds.Tables[0].Rows[0]["email"].ToString()!="")
				{
					model.email=ds.Tables[0].Rows[0]["email"].ToString();
				}
				if(ds.Tables[0].Rows[0]["age"]!=null && ds.Tables[0].Rows[0]["age"].ToString()!="")
				{
					model.age=int.Parse(ds.Tables[0].Rows[0]["age"].ToString());
				}
				if(ds.Tables[0].Rows[0]["login_time"]!=null && ds.Tables[0].Rows[0]["login_time"].ToString()!="")
				{
					model.login_time=DateTime.Parse(ds.Tables[0].Rows[0]["login_time"].ToString());
				}
				if(ds.Tables[0].Rows[0]["sex"]!=null && ds.Tables[0].Rows[0]["sex"].ToString()!="")
				{
					model.sex=ds.Tables[0].Rows[0]["sex"].ToString();
				}
				if(ds.Tables[0].Rows[0]["pic"]!=null && ds.Tables[0].Rows[0]["pic"].ToString()!="")
				{
					model.pic=ds.Tables[0].Rows[0]["pic"].ToString();
				}
				if(ds.Tables[0].Rows[0]["quanxian"]!=null && ds.Tables[0].Rows[0]["quanxian"].ToString()!="")
				{
					model.quanxian=ds.Tables[0].Rows[0]["quanxian"].ToString();
				}
				if(ds.Tables[0].Rows[0]["username"]!=null && ds.Tables[0].Rows[0]["username"].ToString()!="")
				{
					model.username=ds.Tables[0].Rows[0]["username"].ToString();
				}
				if(ds.Tables[0].Rows[0]["GUID"]!=null && ds.Tables[0].Rows[0]["GUID"].ToString()!="")
				{
					model.GUID=ds.Tables[0].Rows[0]["GUID"].ToString();
				}
				if(ds.Tables[0].Rows[0]["IP"]!=null && ds.Tables[0].Rows[0]["IP"].ToString()!="")
				{
					model.IP=ds.Tables[0].Rows[0]["IP"].ToString();
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
			strSql.Append("select Id,UserId,AccountBalance,AvilableBalance,ConsumedAmount,GradeID,State,RealName,Qq,Mobil,Tel,Address,Postcode,Website,IDcardNum,AccountType,SiteID,bh,RoleID,UgroupID,name,PASSWORD,email,age,login_time,sex,pic,quanxian,username,GUID,IP ");
			strSql.Append(" FROM View_user ");
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
			strSql.Append(" Id,UserId,AccountBalance,AvilableBalance,ConsumedAmount,GradeID,State,RealName,Qq,Mobil,Tel,Address,Postcode,Website,IDcardNum,AccountType,SiteID,bh,RoleID,UgroupID,name,PASSWORD,email,age,login_time,sex,pic,quanxian,username,GUID,IP ");
			strSql.Append(" FROM View_user ");
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
			strSql.Append("select count(1) FROM View_user ");
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
				strSql.Append("order by T. desc");
			}
			strSql.Append(")AS Row, T.*  from View_user T ");
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
			parameters[0].Value = "View_user";
			parameters[1].Value = "";
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

