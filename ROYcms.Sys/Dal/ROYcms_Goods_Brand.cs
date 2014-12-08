using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ROYcms.DB;
namespace ROYcms.Sys.DAL
{
    /// <summary>
    /// 数据访问类:ROYcms_Goods_Brand
    /// </summary>
    public partial class ROYcms_Goods_Brand
    {
        public ROYcms_Goods_Brand()
        { }
        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ROYcms_Goods_Brand");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
};
            parameters[0].Value = Id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(ROYcms.Sys.Model.ROYcms_Goods_Brand model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ROYcms_Goods_Brand(");
            strSql.Append("Name,Logo,brand_desc,site_url,sort_order,is_show,TIME)");
            strSql.Append(" values (");
            strSql.Append("@Name,@Logo,@brand_desc,@site_url,@sort_order,@is_show,@TIME)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.VarChar,500),
					new SqlParameter("@Logo", SqlDbType.VarChar,500),
					new SqlParameter("@brand_desc", SqlDbType.VarChar,2000),
					new SqlParameter("@site_url", SqlDbType.VarChar,200),
					new SqlParameter("@sort_order", SqlDbType.Int,4),
					new SqlParameter("@is_show", SqlDbType.Int,4),
					new SqlParameter("@TIME", SqlDbType.DateTime)};
            parameters[0].Value = model.Name;
            parameters[1].Value = model.Logo;
            parameters[2].Value = model.brand_desc;
            parameters[3].Value = model.site_url;
            parameters[4].Value = model.sort_order;
            parameters[5].Value = model.is_show;
            parameters[6].Value = model.TIME;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
        public bool Update(ROYcms.Sys.Model.ROYcms_Goods_Brand model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ROYcms_Goods_Brand set ");
            strSql.Append("Name=@Name,");
            strSql.Append("Logo=@Logo,");
            strSql.Append("brand_desc=@brand_desc,");
            strSql.Append("site_url=@site_url,");
            strSql.Append("sort_order=@sort_order,");
            strSql.Append("is_show=@is_show,");
            strSql.Append("TIME=@TIME");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.VarChar,500),
					new SqlParameter("@Logo", SqlDbType.VarChar,500),
					new SqlParameter("@brand_desc", SqlDbType.VarChar,2000),
					new SqlParameter("@site_url", SqlDbType.VarChar,200),
					new SqlParameter("@sort_order", SqlDbType.Int,4),
					new SqlParameter("@is_show", SqlDbType.Int,4),
					new SqlParameter("@TIME", SqlDbType.DateTime),
					new SqlParameter("@Id", SqlDbType.Int,4)};
            parameters[0].Value = model.Name;
            parameters[1].Value = model.Logo;
            parameters[2].Value = model.brand_desc;
            parameters[3].Value = model.site_url;
            parameters[4].Value = model.sort_order;
            parameters[5].Value = model.is_show;
            parameters[6].Value = model.TIME;
            parameters[7].Value = model.Id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ROYcms_Goods_Brand ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
};
            parameters[0].Value = Id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool DeleteList(string Idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ROYcms_Goods_Brand ");
            strSql.Append(" where Id in (" + Idlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
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
        public ROYcms.Sys.Model.ROYcms_Goods_Brand GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,Name,Logo,brand_desc,site_url,sort_order,is_show,TIME from ROYcms_Goods_Brand ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
};
            parameters[0].Value = Id;

            ROYcms.Sys.Model.ROYcms_Goods_Brand model = new ROYcms.Sys.Model.ROYcms_Goods_Brand();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["Id"] != null && ds.Tables[0].Rows[0]["Id"].ToString() != "")
                {
                    model.Id = int.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Name"] != null && ds.Tables[0].Rows[0]["Name"].ToString() != "")
                {
                    model.Name = ds.Tables[0].Rows[0]["Name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Logo"] != null && ds.Tables[0].Rows[0]["Logo"].ToString() != "")
                {
                    model.Logo = ds.Tables[0].Rows[0]["Logo"].ToString();
                }
                if (ds.Tables[0].Rows[0]["brand_desc"] != null && ds.Tables[0].Rows[0]["brand_desc"].ToString() != "")
                {
                    model.brand_desc = ds.Tables[0].Rows[0]["brand_desc"].ToString();
                }
                if (ds.Tables[0].Rows[0]["site_url"] != null && ds.Tables[0].Rows[0]["site_url"].ToString() != "")
                {
                    model.site_url = ds.Tables[0].Rows[0]["site_url"].ToString();
                }
                if (ds.Tables[0].Rows[0]["sort_order"] != null && ds.Tables[0].Rows[0]["sort_order"].ToString() != "")
                {
                    model.sort_order = int.Parse(ds.Tables[0].Rows[0]["sort_order"].ToString());
                }
                if (ds.Tables[0].Rows[0]["is_show"] != null && ds.Tables[0].Rows[0]["is_show"].ToString() != "")
                {
                    model.is_show = int.Parse(ds.Tables[0].Rows[0]["is_show"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TIME"] != null && ds.Tables[0].Rows[0]["TIME"].ToString() != "")
                {
                    model.TIME = DateTime.Parse(ds.Tables[0].Rows[0]["TIME"].ToString());
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,Name,Logo,brand_desc,site_url,sort_order,is_show,TIME ");
            strSql.Append(" FROM ROYcms_Goods_Brand ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" Id,Name,Logo,brand_desc,site_url,sort_order,is_show,TIME ");
            strSql.Append(" FROM ROYcms_Goods_Brand ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
            strSql.Append("select count(1) FROM ROYcms_Goods_Brand ");
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
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.Id desc");
            }
            strSql.Append(")AS Row, T.*  from ROYcms_Goods_Brand T ");
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
            parameters[0].Value = "ROYcms_Goods_Brand";
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

