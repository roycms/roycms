using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ROYcms.DB;
namespace ROYcms.Sys.DAL
{
	/// <summary>
	/// 数据访问类ROYcms_Organization。
	/// </summary>
	public class ROYcms_Organization
	{
		public ROYcms_Organization()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from " + PubConstant.date_prefix + "Organization");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
        /// <summary>
        /// 是否存在该记录 查询条件 USERID
        /// </summary>
        public bool U_Exists(int userid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from " + PubConstant.date_prefix + "Organization");
            strSql.Append(" where userid=@userid ");
            SqlParameter[] parameters = {
					new SqlParameter("@userid", SqlDbType.Int,4)};
            parameters[0].Value = userid;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(ROYcms.Sys.Model.ROYcms_Organization model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into "+ PubConstant.date_prefix + "Organization(");
			strSql.Append("userID,name,classname,keyword,zhaiyao,contents,tag,hits,orders,tuijian,switchs,type,Time,GUID)");
			strSql.Append(" values (");
			strSql.Append("@userID,@name,@classname,@keyword,@zhaiyao,@contents,@tag,@hits,@orders,@tuijian,@switchs,@type,@Time,@GUID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@userID", SqlDbType.Int,4),
					new SqlParameter("@name", SqlDbType.VarChar,50),
					new SqlParameter("@classname", SqlDbType.Int,4),
					new SqlParameter("@keyword", SqlDbType.VarChar,100),
					new SqlParameter("@zhaiyao", SqlDbType.VarChar,1000),
					new SqlParameter("@contents", SqlDbType.Text),
					new SqlParameter("@tag", SqlDbType.VarChar,100),
					new SqlParameter("@hits", SqlDbType.Int,4),
					new SqlParameter("@orders", SqlDbType.Int,4),
					new SqlParameter("@tuijian", SqlDbType.Int,4),
					new SqlParameter("@switchs", SqlDbType.Int,4),
					new SqlParameter("@type", SqlDbType.VarChar,50),
					new SqlParameter("@Time", SqlDbType.NChar,10),
					new SqlParameter("@GUID", SqlDbType.VarChar,50)};
			parameters[0].Value = model.userID;
			parameters[1].Value = model.name;
			parameters[2].Value = model.classname;
			parameters[3].Value = model.keyword;
			parameters[4].Value = model.zhaiyao;
			parameters[5].Value = model.contents;
			parameters[6].Value = model.tag;
			parameters[7].Value = model.hits;
			parameters[8].Value = model.orders;
			parameters[9].Value = model.tuijian;
			parameters[10].Value = model.switchs;
			parameters[11].Value = model.type;
			parameters[12].Value = model.Time;
			parameters[13].Value = model.GUID;

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
        /// 更新一条数据 条件 userid
        /// </summary>
        public void U_Update(ROYcms.Sys.Model.ROYcms_Organization model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update "+ PubConstant.date_prefix + "Organization set ");
            //strSql.Append("userID=@userID,");
            strSql.Append("name=@name,");
            strSql.Append("classname=@classname,");
            strSql.Append("keyword=@keyword,");
            strSql.Append("zhaiyao=@zhaiyao,");
            strSql.Append("contents=@contents,");
            strSql.Append("tag=@tag,");
            strSql.Append("hits=@hits,");
            strSql.Append("orders=@orders,");
            strSql.Append("tuijian=@tuijian,");
            strSql.Append("switchs=@switchs,");
            strSql.Append("type=@type,");
            strSql.Append("Time=@Time,");
            strSql.Append("GUID=@GUID");
            strSql.Append(" where userID=@userID ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@userID", SqlDbType.Int,4),
					new SqlParameter("@name", SqlDbType.VarChar,50),
					new SqlParameter("@classname", SqlDbType.Int,4),
					new SqlParameter("@keyword", SqlDbType.VarChar,100),
					new SqlParameter("@zhaiyao", SqlDbType.VarChar,1000),
					new SqlParameter("@contents", SqlDbType.Text),
					new SqlParameter("@tag", SqlDbType.VarChar,100),
					new SqlParameter("@hits", SqlDbType.Int,4),
					new SqlParameter("@orders", SqlDbType.Int,4),
					new SqlParameter("@tuijian", SqlDbType.Int,4),
					new SqlParameter("@switchs", SqlDbType.Int,4),
					new SqlParameter("@type", SqlDbType.VarChar,50),
					new SqlParameter("@Time", SqlDbType.NChar,10),
					new SqlParameter("@GUID", SqlDbType.VarChar,50)};
            parameters[0].Value = model.id;
            parameters[1].Value = model.userID;
            parameters[2].Value = model.name;
            parameters[3].Value = model.classname;
            parameters[4].Value = model.keyword;
            parameters[5].Value = model.zhaiyao;
            parameters[6].Value = model.contents;
            parameters[7].Value = model.tag;
            parameters[8].Value = model.hits;
            parameters[9].Value = model.orders;
            parameters[10].Value = model.tuijian;
            parameters[11].Value = model.switchs;
            parameters[12].Value = model.type;
            parameters[13].Value = model.Time;
            parameters[14].Value = model.GUID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(ROYcms.Sys.Model.ROYcms_Organization model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update "+ PubConstant.date_prefix + "Organization set ");
			strSql.Append("userID=@userID,");
			strSql.Append("name=@name,");
			strSql.Append("classname=@classname,");
			strSql.Append("keyword=@keyword,");
			strSql.Append("zhaiyao=@zhaiyao,");
			strSql.Append("contents=@contents,");
			strSql.Append("tag=@tag,");
			strSql.Append("hits=@hits,");
			strSql.Append("orders=@orders,");
			strSql.Append("tuijian=@tuijian,");
			strSql.Append("switchs=@switchs,");
			strSql.Append("type=@type,");
			strSql.Append("Time=@Time,");
			strSql.Append("GUID=@GUID");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@userID", SqlDbType.Int,4),
					new SqlParameter("@name", SqlDbType.VarChar,50),
					new SqlParameter("@classname", SqlDbType.Int,4),
					new SqlParameter("@keyword", SqlDbType.VarChar,100),
					new SqlParameter("@zhaiyao", SqlDbType.VarChar,1000),
					new SqlParameter("@contents", SqlDbType.Text),
					new SqlParameter("@tag", SqlDbType.VarChar,100),
					new SqlParameter("@hits", SqlDbType.Int,4),
					new SqlParameter("@orders", SqlDbType.Int,4),
					new SqlParameter("@tuijian", SqlDbType.Int,4),
					new SqlParameter("@switchs", SqlDbType.Int,4),
					new SqlParameter("@type", SqlDbType.VarChar,50),
					new SqlParameter("@Time", SqlDbType.NChar,10),
					new SqlParameter("@GUID", SqlDbType.VarChar,50)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.userID;
			parameters[2].Value = model.name;
			parameters[3].Value = model.classname;
			parameters[4].Value = model.keyword;
			parameters[5].Value = model.zhaiyao;
			parameters[6].Value = model.contents;
			parameters[7].Value = model.tag;
			parameters[8].Value = model.hits;
			parameters[9].Value = model.orders;
			parameters[10].Value = model.tuijian;
			parameters[11].Value = model.switchs;
			parameters[12].Value = model.type;
			parameters[13].Value = model.Time;
			parameters[14].Value = model.GUID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from " + PubConstant.date_prefix + "Organization ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}
        /// <summary>
        /// 得到一个对象实体 条件是USER id
        /// </summary>
        public ROYcms.Sys.Model.ROYcms_Organization U_GetModel(int userid)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,userID,name,classname,keyword,zhaiyao,contents,tag,hits,orders,tuijian,switchs,type,Time,GUID from " + PubConstant.date_prefix + "Organization ");
            strSql.Append(" where userid=@userid ");
            SqlParameter[] parameters = {
					new SqlParameter("@userid", SqlDbType.Int,4)};
            parameters[0].Value = userid;

            ROYcms.Sys.Model.ROYcms_Organization model = new ROYcms.Sys.Model.ROYcms_Organization();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["userID"].ToString() != "")
                {
                    model.userID = int.Parse(ds.Tables[0].Rows[0]["userID"].ToString());
                }
                model.name = ds.Tables[0].Rows[0]["name"].ToString();
                if (ds.Tables[0].Rows[0]["classname"].ToString() != "")
                {
                    model.classname = int.Parse(ds.Tables[0].Rows[0]["classname"].ToString());
                }
                model.keyword = ds.Tables[0].Rows[0]["keyword"].ToString();
                model.zhaiyao = ds.Tables[0].Rows[0]["zhaiyao"].ToString();
                model.contents = ds.Tables[0].Rows[0]["contents"].ToString();
                model.tag = ds.Tables[0].Rows[0]["tag"].ToString();
                if (ds.Tables[0].Rows[0]["hits"].ToString() != "")
                {
                    model.hits = int.Parse(ds.Tables[0].Rows[0]["hits"].ToString());
                }
                if (ds.Tables[0].Rows[0]["orders"].ToString() != "")
                {
                    model.orders = int.Parse(ds.Tables[0].Rows[0]["orders"].ToString());
                }
                if (ds.Tables[0].Rows[0]["tuijian"].ToString() != "")
                {
                    model.tuijian = int.Parse(ds.Tables[0].Rows[0]["tuijian"].ToString());
                }
                if (ds.Tables[0].Rows[0]["switchs"].ToString() != "")
                {
                    model.switchs = int.Parse(ds.Tables[0].Rows[0]["switchs"].ToString());
                }
                model.type = ds.Tables[0].Rows[0]["type"].ToString();
                model.Time = ds.Tables[0].Rows[0]["Time"].ToString();
                model.GUID = ds.Tables[0].Rows[0]["GUID"].ToString();
                return model;
            }
            else
            {
                return null;
            }
        }

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ROYcms.Sys.Model.ROYcms_Organization GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,userID,name,classname,keyword,zhaiyao,contents,tag,hits,orders,tuijian,switchs,type,Time,GUID from " + PubConstant.date_prefix + "Organization ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			ROYcms.Sys.Model.ROYcms_Organization model=new ROYcms.Sys.Model.ROYcms_Organization();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["userID"].ToString()!="")
				{
					model.userID=int.Parse(ds.Tables[0].Rows[0]["userID"].ToString());
				}
				model.name=ds.Tables[0].Rows[0]["name"].ToString();
				if(ds.Tables[0].Rows[0]["classname"].ToString()!="")
				{
					model.classname=int.Parse(ds.Tables[0].Rows[0]["classname"].ToString());
				}
				model.keyword=ds.Tables[0].Rows[0]["keyword"].ToString();
				model.zhaiyao=ds.Tables[0].Rows[0]["zhaiyao"].ToString();
				model.contents=ds.Tables[0].Rows[0]["contents"].ToString();
				model.tag=ds.Tables[0].Rows[0]["tag"].ToString();
				if(ds.Tables[0].Rows[0]["hits"].ToString()!="")
				{
					model.hits=int.Parse(ds.Tables[0].Rows[0]["hits"].ToString());
				}
				if(ds.Tables[0].Rows[0]["orders"].ToString()!="")
				{
					model.orders=int.Parse(ds.Tables[0].Rows[0]["orders"].ToString());
				}
				if(ds.Tables[0].Rows[0]["tuijian"].ToString()!="")
				{
					model.tuijian=int.Parse(ds.Tables[0].Rows[0]["tuijian"].ToString());
				}
				if(ds.Tables[0].Rows[0]["switchs"].ToString()!="")
				{
					model.switchs=int.Parse(ds.Tables[0].Rows[0]["switchs"].ToString());
				}
				model.type=ds.Tables[0].Rows[0]["type"].ToString();
				model.Time=ds.Tables[0].Rows[0]["Time"].ToString();
				model.GUID=ds.Tables[0].Rows[0]["GUID"].ToString();
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
			strSql.Append("select id,userID,name,classname,keyword,zhaiyao,contents,tag,hits,orders,tuijian,switchs,type,Time,GUID ");
			strSql.Append(" from " + PubConstant.date_prefix + "Organization ");
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
			strSql.Append(" id,userID,name,classname,keyword,zhaiyao,contents,tag,hits,orders,tuijian,switchs,type,Time,GUID ");
			strSql.Append(" from " + PubConstant.date_prefix + "Organization ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
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
			parameters[0].Value = PubConstant.date_prefix + "Organization";
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

