using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ROYcms.DB;
namespace ROYcms.Sys.DAL
{
	/// <summary>
	/// 数据访问类ROYcms_remark。
	/// </summary>
	public class ROYcms_remark
	{
		public ROYcms_remark()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int bh)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from " + PubConstant.date_prefix + "remark");
			strSql.Append(" where bh=@bh ");
			SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4)};
			parameters[0].Value = bh;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(ROYcms.Sys.Model.ROYcms_remark model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into "+ PubConstant.date_prefix + "remark(");
			strSql.Append("NewID,userID,userName,contents,Ip,Time)");
			strSql.Append(" values (");
			strSql.Append("@NewID,@userID,@userName,@contents,@Ip,@Time)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@NewID", SqlDbType.Int,4),
					new SqlParameter("@userID", SqlDbType.Int,4),
					new SqlParameter("@userName", SqlDbType.NChar,10),
					new SqlParameter("@contents", SqlDbType.NChar,1000),
					new SqlParameter("@Ip", SqlDbType.NChar,50),
					new SqlParameter("@Time", SqlDbType.DateTime)};
			parameters[0].Value = model.NewID;
			parameters[1].Value = model.userID;
			parameters[2].Value = model.userName;
			parameters[3].Value = model.contents;
			parameters[4].Value = model.Ip;
			parameters[5].Value = model.Time;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 1;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(ROYcms.Sys.Model.ROYcms_remark model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update "+ PubConstant.date_prefix + "remark set ");
			strSql.Append("NewID=@NewID,");
			strSql.Append("userID=@userID,");
			strSql.Append("userName=@userName,");
			strSql.Append("contents=@contents,");
			strSql.Append("Ip=@Ip,");
			strSql.Append("Time=@Time");
			strSql.Append(" where bh=@bh ");
			SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4),
					new SqlParameter("@NewID", SqlDbType.Int,4),
					new SqlParameter("@userID", SqlDbType.Int,4),
					new SqlParameter("@userName", SqlDbType.NChar,10),
					new SqlParameter("@contents", SqlDbType.NChar,1000),
					new SqlParameter("@Ip", SqlDbType.NChar,50),
					new SqlParameter("@Time", SqlDbType.DateTime)};
			parameters[0].Value = model.bh;
			parameters[1].Value = model.NewID;
			parameters[2].Value = model.userID;
			parameters[3].Value = model.userName;
			parameters[4].Value = model.contents;
			parameters[5].Value = model.Ip;
			parameters[6].Value = model.Time;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int bh)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from " + PubConstant.date_prefix + "remark ");
			strSql.Append(" where bh=@bh ");
			SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4)};
			parameters[0].Value = bh;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ROYcms.Sys.Model.ROYcms_remark GetModel(int bh)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 bh,NewID,userID,userName,contents,Ip,Time from " + PubConstant.date_prefix + "remark ");
			strSql.Append(" where bh=@bh ");
			SqlParameter[] parameters = {
					new SqlParameter("@bh", SqlDbType.Int,4)};
			parameters[0].Value = bh;

			ROYcms.Sys.Model.ROYcms_remark model=new ROYcms.Sys.Model.ROYcms_remark();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["bh"].ToString()!="")
				{
					model.bh=int.Parse(ds.Tables[0].Rows[0]["bh"].ToString());
				}
				if(ds.Tables[0].Rows[0]["NewID"].ToString()!="")
				{
					model.NewID=int.Parse(ds.Tables[0].Rows[0]["NewID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["userID"].ToString()!="")
				{
					model.userID=int.Parse(ds.Tables[0].Rows[0]["userID"].ToString());
				}
				model.userName=ds.Tables[0].Rows[0]["userName"].ToString();
				model.contents=ds.Tables[0].Rows[0]["contents"].ToString();
				model.Ip=ds.Tables[0].Rows[0]["Ip"].ToString();
				if(ds.Tables[0].Rows[0]["Time"].ToString()!="")
				{
					model.Time=DateTime.Parse(ds.Tables[0].Rows[0]["Time"].ToString());
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
			strSql.Append("select bh,NewID,userID,userName,contents,Ip,Time ");
			strSql.Append(" from " + PubConstant.date_prefix + "remark ");
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
			strSql.Append(" bh,NewID,userID,userName,contents,Ip,Time ");
			strSql.Append(" from " + PubConstant.date_prefix + "remark ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}
        /// <summary>
        /// 返回长查询数据总数 （分页用到）
        /// </summary>
        public int GetCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) as H ");
            strSql.Append(" FROM [" + PubConstant.date_prefix + "remark] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return Convert.ToInt32(ROYcms.DB.DbHelpers.GetSingle(strSql.ToString()));
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
			parameters[0].Value = PubConstant.date_prefix + "remark";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  成员方法
	}
}

