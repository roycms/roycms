using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ROYcms.DB;//请先添加引用
namespace ROYcms.Sys.DAL
{
	/// <summary>
	/// 数据访问类ROYcms_Dissertation。
	/// </summary>
    public class ROYcms_Dissertation
	{
		public ROYcms_Dissertation()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from "+PubConstant.date_prefix+"Dissertation");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

            return ROYcms.DB.DbHelpers.Exists(strSql.ToString(), parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(ROYcms.Sys.Model.ROYcms_Dissertation model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into "+PubConstant.date_prefix+"Dissertation(");
			strSql.Append("dissertation_name,dissertation_content,templet_url)");
			strSql.Append(" values (");
			strSql.Append("@dissertation_name,@dissertation_content,@templet_url)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@dissertation_name", SqlDbType.NChar,10),
					new SqlParameter("@dissertation_content", SqlDbType.Char,5000),
					new SqlParameter("@templet_url", SqlDbType.NChar,100)};
			parameters[0].Value = model.dissertation_name;
			parameters[1].Value = model.dissertation_content;
			parameters[2].Value = model.templet_url;

            object obj = ROYcms.DB.DbHelpers.GetSingle(strSql.ToString(), parameters);
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
		public void Update(ROYcms.Sys.Model.ROYcms_Dissertation model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update "+PubConstant.date_prefix+"Dissertation set ");
			strSql.Append("dissertation_name=@dissertation_name,");
			strSql.Append("dissertation_content=@dissertation_content,");
			strSql.Append("templet_url=@templet_url");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@dissertation_name", SqlDbType.NChar,10),
					new SqlParameter("@dissertation_content", SqlDbType.Char,5000),
					new SqlParameter("@templet_url", SqlDbType.NChar,100)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.dissertation_name;
			parameters[2].Value = model.dissertation_content;
			parameters[3].Value = model.templet_url;

            ROYcms.DB.DbHelpers.NonQuery(strSql.ToString(), parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete "+PubConstant.date_prefix+"Dissertation ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

            ROYcms.DB.DbHelpers.NonQuery(strSql.ToString(), parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ROYcms.Sys.Model.ROYcms_Dissertation GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,dissertation_name,dissertation_content,templet_url from "+PubConstant.date_prefix+"Dissertation ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			ROYcms.Sys.Model.ROYcms_Dissertation model=new ROYcms.Sys.Model.ROYcms_Dissertation();
            DataSet ds = ROYcms.DB.DbHelpers.GetDataSet(strSql.ToString(), parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				model.dissertation_name=ds.Tables[0].Rows[0]["dissertation_name"].ToString();
				model.dissertation_content=ds.Tables[0].Rows[0]["dissertation_content"].ToString();
				model.templet_url=ds.Tables[0].Rows[0]["templet_url"].ToString();
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
			strSql.Append("select id,dissertation_name,dissertation_content,templet_url ");
			strSql.Append(" FROM "+PubConstant.date_prefix+"Dissertation ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
            return ROYcms.DB.DbHelpers.GetDataSet(strSql.ToString());
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
			parameters[0].Value = PubConstant.date_prefix + "Dissertation";
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

