using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ROYcms.DB;//请先添加引用
namespace ROYcms.Sys.DAL
{
	/// <summary>
	/// 数据访问类ROYcms_CustomTag。
	/// </summary>
    public class ROYcms_CustomTag
	{
		public ROYcms_CustomTag()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from "+PubConstant.date_prefix+"CustomTag");
			strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

            return ROYcms.DB.DbHelpers.Exists(strSql.ToString(), parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(ROYcms.Sys.Model.ROYcms_CustomTag model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into "+PubConstant.date_prefix+"CustomTag(");
			strSql.Append("TAG,TAG_name,TAG_content)");
			strSql.Append(" values (");
			strSql.Append("@TAG,@TAG_name,@TAG_content)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@TAG", SqlDbType.NChar,50),
					new SqlParameter("@TAG_name", SqlDbType.NChar,50),
					new SqlParameter("@TAG_content", SqlDbType.NChar,500)};
			parameters[0].Value = model.TAG;
			parameters[1].Value = model.TAG_name;
			parameters[2].Value = model.TAG_content;

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
		public void Update(ROYcms.Sys.Model.ROYcms_CustomTag model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update "+PubConstant.date_prefix+"CustomTag set ");
			strSql.Append("TAG=@TAG,");
			strSql.Append("TAG_name=@TAG_name,");
			strSql.Append("TAG_content=@TAG_content");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@TAG", SqlDbType.NChar,50),
					new SqlParameter("@TAG_name", SqlDbType.NChar,50),
					new SqlParameter("@TAG_content", SqlDbType.NChar,500)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.TAG;
			parameters[2].Value = model.TAG_name;
			parameters[3].Value = model.TAG_content;

            ROYcms.DB.DbHelpers.NonQuery(strSql.ToString(), parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete "+PubConstant.date_prefix+"CustomTag ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

            ROYcms.DB.DbHelpers.NonQuery(strSql.ToString(), parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ROYcms.Sys.Model.ROYcms_CustomTag GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,TAG,TAG_name,TAG_content from "+PubConstant.date_prefix+"CustomTag ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			ROYcms.Sys.Model.ROYcms_CustomTag model=new ROYcms.Sys.Model.ROYcms_CustomTag();
            DataSet ds = ROYcms.DB.DbHelpers.GetDataSet(strSql.ToString(), parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				model.TAG=ds.Tables[0].Rows[0]["TAG"].ToString();
				model.TAG_name=ds.Tables[0].Rows[0]["TAG_name"].ToString();
				model.TAG_content=ds.Tables[0].Rows[0]["TAG_content"].ToString();
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
			strSql.Append("select id,TAG,TAG_name,TAG_content ");
			strSql.Append(" FROM "+PubConstant.date_prefix+"CustomTag ");
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
			parameters[0].Value = PubConstant.date_prefix + "CustomTag";
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

