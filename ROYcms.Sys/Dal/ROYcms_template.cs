using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ROYcms.DB;//请先添加引用
namespace ROYcms.Sys.DAL
{
	/// <summary>
	/// 数据访问类ROYcms_template。
	/// </summary>
    public class ROYcms_template
	{
		public ROYcms_template()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int bh)
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from " + PubConstant.date_prefix + "template");
            strSql.Append(" where bh=" + bh + " ");
            return ROYcms.DB.DbHelpers.Exists(strSql.ToString());
		}
        /// <summary>
        /// 是否存在del记录
        /// 0不存在  大于0 则存在切为存在的Id
        /// </summary>
        public int del_Exists()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select bh from "+PubConstant.date_prefix+"template");
            strSql.Append(" where y=2 ");
            object obj = ROYcms.DB.DbHelpers.GetSingle(strSql.ToString());
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
		/// 增加一条数据
		/// </summary>
		public int Add(ROYcms.Sys.Model.ROYcms_template model)
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into " + PubConstant.date_prefix + "template(");
            strSql.Append("z_id,name,tag,htmlcontent,htmltimes,class_name,y");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("" + model.z_id + ",");
            strSql.Append("'" + model.name + "',");
            strSql.Append("'" + model.tag + "',");
            strSql.Append("'" + model.htmlcontent + "',");
            strSql.Append("'" + model.htmltimes + "',");
            strSql.Append("'" + model.class_name + "',");
            strSql.Append("" + model.y + "");
            strSql.Append(")");
            strSql.Append(";select @@IDENTITY");
            object obj = ROYcms.DB.DbHelpers.GetSingle(strSql.ToString());
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
		public void Update(ROYcms.Sys.Model.ROYcms_template model)
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update " + PubConstant.date_prefix + "template set ");
            strSql.Append("z_id=" + model.z_id + ",");
            strSql.Append("name='" + model.name + "',");
            strSql.Append("tag='" + model.tag + "',");
            strSql.Append("htmlcontent='" + model.htmlcontent + "',");
            strSql.Append("htmltimes='" + model.htmltimes + "',");
            strSql.Append("class_name='" + model.class_name + "',");
            strSql.Append("y=" + model.y + "");
            strSql.Append(" where bh=" + model.bh + " ");
            ROYcms.DB.DbHelpers.NonQuery(strSql.ToString());

		
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int bh)
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update " + PubConstant.date_prefix + "template set y = '2'");
            strSql.Append(" where bh=" + bh + " ");
            ROYcms.DB.DbHelpers.NonQuery(strSql.ToString());

			
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ROYcms.Sys.Model.ROYcms_template GetModel(int bh)
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" bh,z_id,name,tag,htmlcontent,htmltimes,class_name,y ");
            strSql.Append(" from " + PubConstant.date_prefix + "template ");
            strSql.Append(" where bh=" + bh + " and  y = '0'");
            ROYcms.Sys.Model.ROYcms_template model = new ROYcms.Sys.Model.ROYcms_template();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["bh"].ToString() != "")
                {
                    model.bh = int.Parse(ds.Tables[0].Rows[0]["bh"].ToString());
                }
                if (ds.Tables[0].Rows[0]["z_id"].ToString() != "")
                {
                    model.z_id = int.Parse(ds.Tables[0].Rows[0]["z_id"].ToString());
                }
                model.name = ds.Tables[0].Rows[0]["name"].ToString();
                model.tag = ds.Tables[0].Rows[0]["tag"].ToString();
                model.htmlcontent = ds.Tables[0].Rows[0]["htmlcontent"].ToString();
                if (ds.Tables[0].Rows[0]["htmltimes"].ToString() != "")
                {
                    model.htmltimes = DateTime.Parse(ds.Tables[0].Rows[0]["htmltimes"].ToString());
                }
                model.class_name = ds.Tables[0].Rows[0]["class_name"].ToString();
                if (ds.Tables[0].Rows[0]["y"].ToString() != "")
                {
                    model.y = int.Parse(ds.Tables[0].Rows[0]["y"].ToString());
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
			strSql.Append("select * ");
			strSql.Append(" FROM "+PubConstant.date_prefix+"template ");
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
			parameters[0].Value = ""+PubConstant.date_prefix+"template";
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

