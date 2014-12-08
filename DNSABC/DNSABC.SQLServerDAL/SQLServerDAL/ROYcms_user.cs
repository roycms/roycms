using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DNSABC.IDAL;
using ROYcms.DB;//Please add references
namespace DNSABC.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:ROYcms_user
	/// </summary>
	public partial class ROYcms_user:IROYcms_user
	{
		public ROYcms_user()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("bh", "ROYcms_user"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int bh)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ROYcms_user");
			strSql.Append(" where bh=@bh");
			SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4)
};
			parameters[0].Value = bh;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(DNSABC.Model.ROYcms_user model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ROYcms_user(");
			strSql.Append("RoleID,UgroupID,Name,PASSWORD,money,Qq,Email,Age,sex,Pic,Quanxian,Username,Guid,Ip,LoginTime)");
			strSql.Append(" values (");
			strSql.Append("@RoleID,@UgroupID,@Name,@PASSWORD,@money,@Qq,@Email,@Age,@sex,@Pic,@Quanxian,@Username,@Guid,@Ip,@LoginTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@RoleID", SqlDbType.VarChar,50),
					new SqlParameter("@UgroupID", SqlDbType.VarChar,50),
					new SqlParameter("@Name", SqlDbType.VarChar,50),
					new SqlParameter("@PASSWORD", SqlDbType.VarChar,50),
					new SqlParameter("@money", SqlDbType.Int,4),
					new SqlParameter("@Qq", SqlDbType.VarChar,50),
					new SqlParameter("@Email", SqlDbType.VarChar,50),
					new SqlParameter("@Age", SqlDbType.Int,4),
					new SqlParameter("@sex", SqlDbType.VarChar,10),
					new SqlParameter("@Pic", SqlDbType.VarChar,100),
					new SqlParameter("@Quanxian", SqlDbType.VarChar,50),
					new SqlParameter("@Username", SqlDbType.VarChar,50),
					new SqlParameter("@Guid", SqlDbType.VarChar,50),
					new SqlParameter("@Ip", SqlDbType.VarChar,20),
					new SqlParameter("@LoginTime", SqlDbType.DateTime)};
			parameters[0].Value = model.RoleID;
			parameters[1].Value = model.UgroupID;
			parameters[2].Value = model.Name;
			parameters[3].Value = model.PASSWORD;
			parameters[4].Value = model.money;
			parameters[5].Value = model.Qq;
			parameters[6].Value = model.Email;
			parameters[7].Value = model.Age;
			parameters[8].Value = model.sex;
			parameters[9].Value = model.Pic;
			parameters[10].Value = model.Quanxian;
			parameters[11].Value = model.Username;
			parameters[12].Value = model.Guid;
			parameters[13].Value = model.Ip;
			parameters[14].Value = model.LoginTime;

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
		public bool Update(DNSABC.Model.ROYcms_user model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ROYcms_user set ");
			strSql.Append("RoleID=@RoleID,");
			strSql.Append("UgroupID=@UgroupID,");
			strSql.Append("Name=@Name,");
			strSql.Append("PASSWORD=@PASSWORD,");
			strSql.Append("money=@money,");
			strSql.Append("Qq=@Qq,");
			strSql.Append("Email=@Email,");
			strSql.Append("Age=@Age,");
			strSql.Append("sex=@sex,");
			strSql.Append("Pic=@Pic,");
			strSql.Append("Quanxian=@Quanxian,");
			strSql.Append("Username=@Username,");
			strSql.Append("Guid=@Guid,");
			strSql.Append("Ip=@Ip,");
			strSql.Append("LoginTime=@LoginTime");
			strSql.Append(" where bh=@bh");
			SqlParameter[] parameters = {
					new SqlParameter("@RoleID", SqlDbType.VarChar,50),
					new SqlParameter("@UgroupID", SqlDbType.VarChar,50),
					new SqlParameter("@Name", SqlDbType.VarChar,50),
					new SqlParameter("@PASSWORD", SqlDbType.VarChar,50),
					new SqlParameter("@money", SqlDbType.Int,4),
					new SqlParameter("@Qq", SqlDbType.VarChar,50),
					new SqlParameter("@Email", SqlDbType.VarChar,50),
					new SqlParameter("@Age", SqlDbType.Int,4),
					new SqlParameter("@sex", SqlDbType.VarChar,10),
					new SqlParameter("@Pic", SqlDbType.VarChar,100),
					new SqlParameter("@Quanxian", SqlDbType.VarChar,50),
					new SqlParameter("@Username", SqlDbType.VarChar,50),
					new SqlParameter("@Guid", SqlDbType.VarChar,50),
					new SqlParameter("@Ip", SqlDbType.VarChar,20),
					new SqlParameter("@LoginTime", SqlDbType.DateTime),
					new SqlParameter("@bh", SqlDbType.Int,4)};
			parameters[0].Value = model.RoleID;
			parameters[1].Value = model.UgroupID;
			parameters[2].Value = model.Name;
			parameters[3].Value = model.PASSWORD;
			parameters[4].Value = model.money;
			parameters[5].Value = model.Qq;
			parameters[6].Value = model.Email;
			parameters[7].Value = model.Age;
			parameters[8].Value = model.sex;
			parameters[9].Value = model.Pic;
			parameters[10].Value = model.Quanxian;
			parameters[11].Value = model.Username;
			parameters[12].Value = model.Guid;
			parameters[13].Value = model.Ip;
			parameters[14].Value = model.LoginTime;
			parameters[15].Value = model.bh;

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
		public bool Delete(int bh)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ROYcms_user ");
			strSql.Append(" where bh=@bh");
			SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4)
};
			parameters[0].Value = bh;

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
		public bool DeleteList(string bhlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ROYcms_user ");
			strSql.Append(" where bh in ("+bhlist + ")  ");
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
		public DNSABC.Model.ROYcms_user GetModel(int bh)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 bh,RoleID,UgroupID,Name,PASSWORD,money,Qq,Email,Age,sex,Pic,Quanxian,Username,Guid,Ip,LoginTime from ROYcms_user ");
			strSql.Append(" where bh=@bh");
			SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4)
};
			parameters[0].Value = bh;

			DNSABC.Model.ROYcms_user model=new DNSABC.Model.ROYcms_user();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
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
				if(ds.Tables[0].Rows[0]["Name"]!=null && ds.Tables[0].Rows[0]["Name"].ToString()!="")
				{
					model.Name=ds.Tables[0].Rows[0]["Name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["PASSWORD"]!=null && ds.Tables[0].Rows[0]["PASSWORD"].ToString()!="")
				{
					model.PASSWORD=ds.Tables[0].Rows[0]["PASSWORD"].ToString();
				}
				if(ds.Tables[0].Rows[0]["money"]!=null && ds.Tables[0].Rows[0]["money"].ToString()!="")
				{
					model.money=int.Parse(ds.Tables[0].Rows[0]["money"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Qq"]!=null && ds.Tables[0].Rows[0]["Qq"].ToString()!="")
				{
					model.Qq=ds.Tables[0].Rows[0]["Qq"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Email"]!=null && ds.Tables[0].Rows[0]["Email"].ToString()!="")
				{
					model.Email=ds.Tables[0].Rows[0]["Email"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Age"]!=null && ds.Tables[0].Rows[0]["Age"].ToString()!="")
				{
					model.Age=int.Parse(ds.Tables[0].Rows[0]["Age"].ToString());
				}
				if(ds.Tables[0].Rows[0]["sex"]!=null && ds.Tables[0].Rows[0]["sex"].ToString()!="")
				{
					model.sex=ds.Tables[0].Rows[0]["sex"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Pic"]!=null && ds.Tables[0].Rows[0]["Pic"].ToString()!="")
				{
					model.Pic=ds.Tables[0].Rows[0]["Pic"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Quanxian"]!=null && ds.Tables[0].Rows[0]["Quanxian"].ToString()!="")
				{
					model.Quanxian=ds.Tables[0].Rows[0]["Quanxian"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Username"]!=null && ds.Tables[0].Rows[0]["Username"].ToString()!="")
				{
					model.Username=ds.Tables[0].Rows[0]["Username"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Guid"]!=null && ds.Tables[0].Rows[0]["Guid"].ToString()!="")
				{
					model.Guid=ds.Tables[0].Rows[0]["Guid"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Ip"]!=null && ds.Tables[0].Rows[0]["Ip"].ToString()!="")
				{
					model.Ip=ds.Tables[0].Rows[0]["Ip"].ToString();
				}
				if(ds.Tables[0].Rows[0]["LoginTime"]!=null && ds.Tables[0].Rows[0]["LoginTime"].ToString()!="")
				{
					model.LoginTime=DateTime.Parse(ds.Tables[0].Rows[0]["LoginTime"].ToString());
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
			strSql.Append("select bh,RoleID,UgroupID,Name,PASSWORD,money,Qq,Email,Age,sex,Pic,Quanxian,Username,Guid,Ip,LoginTime ");
			strSql.Append(" FROM ROYcms_user ");
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
			strSql.Append(" bh,RoleID,UgroupID,Name,PASSWORD,money,Qq,Email,Age,sex,Pic,Quanxian,Username,Guid,Ip,LoginTime ");
			strSql.Append(" FROM ROYcms_user ");
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
			strSql.Append("select count(1) FROM ROYcms_user ");
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
				strSql.Append("order by T.bh desc");
			}
			strSql.Append(")AS Row, T.*  from ROYcms_user T ");
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
			parameters[0].Value = "ROYcms_user";
			parameters[1].Value = "bh";
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

