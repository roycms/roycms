using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ROYcms.DB;//请先添加引用
namespace ROYcms.Sys.DAL
{
	/// <summary>
	/// 数据访问类ROYcms_CaiRss。
	/// </summary>
	public class ROYcms_CaiRss
	{
		public ROYcms_CaiRss()
		{}
		#region  成员方法
        /// <summary>
        /// 返回长查询数据总数 （分页用到）
        /// </summary>
        public int GetCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) as H ");
            strSql.Append(" from " + PubConstant.date_prefix + "CaiRss ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return Convert.ToInt32(ROYcms.DB.DbHelpers.GetSingle(strSql.ToString()));
        }
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from " + PubConstant.date_prefix + "CaiRss");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string RssUrl)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from " + PubConstant.date_prefix + "CaiRss");
            strSql.Append(" where RssUrl=@RssUrl ");
            SqlParameter[] parameters = {
					new SqlParameter("@RssUrl", SqlDbType.NVarChar,500)};
            parameters[0].Value = RssUrl;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(ROYcms.Sys.Model.ROYcms_CaiRss model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into "+ PubConstant.date_prefix + "CaiRss(");
			strSql.Append("RssUrl,Encode,HtmlStar,HtmlEnd,Path,Time)");
			strSql.Append(" values (");
			strSql.Append("@RssUrl,@Encode,@HtmlStar,@HtmlEnd,@Path,@Time)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@RssUrl", SqlDbType.NVarChar,500),
					new SqlParameter("@Encode", SqlDbType.NVarChar,10),
					new SqlParameter("@HtmlStar", SqlDbType.NVarChar,1000),
					new SqlParameter("@HtmlEnd", SqlDbType.NVarChar,1000),
					new SqlParameter("@Path", SqlDbType.NVarChar,500),
					new SqlParameter("@Time", SqlDbType.DateTime)};
			parameters[0].Value = model.RssUrl;
			parameters[1].Value = model.Encode;
			parameters[2].Value = model.HtmlStar;
			parameters[3].Value = model.HtmlEnd;
			parameters[4].Value = model.Path;
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
		public void Update(ROYcms.Sys.Model.ROYcms_CaiRss model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update "+ PubConstant.date_prefix + "CaiRss set ");
			strSql.Append("RssUrl=@RssUrl,");
			strSql.Append("Encode=@Encode,");
			strSql.Append("HtmlStar=@HtmlStar,");
			strSql.Append("HtmlEnd=@HtmlEnd,");
			strSql.Append("Path=@Path,");
			strSql.Append("Time=@Time");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@RssUrl", SqlDbType.NVarChar,500),
					new SqlParameter("@Encode", SqlDbType.NVarChar,10),
					new SqlParameter("@HtmlStar", SqlDbType.NVarChar,1000),
					new SqlParameter("@HtmlEnd", SqlDbType.NVarChar,1000),
					new SqlParameter("@Path", SqlDbType.NVarChar,500),
					new SqlParameter("@Time", SqlDbType.DateTime)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.RssUrl;
			parameters[2].Value = model.Encode;
			parameters[3].Value = model.HtmlStar;
			parameters[4].Value = model.HtmlEnd;
			parameters[5].Value = model.Path;
			parameters[6].Value = model.Time;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from " + PubConstant.date_prefix + "CaiRss ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ROYcms.Sys.Model.ROYcms_CaiRss GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,RssUrl,Encode,HtmlStar,HtmlEnd,Path,Time from " + PubConstant.date_prefix + "CaiRss ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			ROYcms.Sys.Model.ROYcms_CaiRss model=new ROYcms.Sys.Model.ROYcms_CaiRss();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				model.RssUrl=ds.Tables[0].Rows[0]["RssUrl"].ToString();
				model.Encode=ds.Tables[0].Rows[0]["Encode"].ToString();
				model.HtmlStar=ds.Tables[0].Rows[0]["HtmlStar"].ToString();
				model.HtmlEnd=ds.Tables[0].Rows[0]["HtmlEnd"].ToString();
				model.Path=ds.Tables[0].Rows[0]["Path"].ToString();
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
			strSql.Append("select id,RssUrl,Encode,HtmlStar,HtmlEnd,Path,Time ");
			strSql.Append(" from " + PubConstant.date_prefix + "CaiRss ");
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
			strSql.Append(" id,RssUrl,Encode,HtmlStar,HtmlEnd,Path,Time ");
			strSql.Append(" from " + PubConstant.date_prefix + "CaiRss ");
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM " + PubConstant.date_prefix + "CaiRss ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
			parameters[0].Value = PubConstant.date_prefix + "CaiRss";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}

		#endregion  成员方法
	}
}

