using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ROYcms.DB;
namespace ROYcms.Sys.DAL
{
    /// <summary>
    /// 数据访问类:ROYcms_Goods_Order_Detail
    /// </summary>
    public partial class ROYcms_Goods_Order_Detail
    {
        public ROYcms_Goods_Order_Detail()
        { }
        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ROYcms_Goods_Order_Detail");
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
        public int Add(ROYcms.Sys.Model.ROYcms_Goods_Order_Detail model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ROYcms_Goods_Order_Detail(");
            strSql.Append("order_id,goods_id,goods_name,goods_sn,goods_number,market_price,goods_price,goods_attr,send_number,is_real,extension_code,parent_id,is_gift)");
            strSql.Append(" values (");
            strSql.Append("@order_id,@goods_id,@goods_name,@goods_sn,@goods_number,@market_price,@goods_price,@goods_attr,@send_number,@is_real,@extension_code,@parent_id,@is_gift)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@order_id", SqlDbType.VarChar,50),
					new SqlParameter("@goods_id", SqlDbType.Int,4),
					new SqlParameter("@goods_name", SqlDbType.VarChar,500),
					new SqlParameter("@goods_sn", SqlDbType.VarChar,100),
					new SqlParameter("@goods_number", SqlDbType.Int,4),
					new SqlParameter("@market_price", SqlDbType.Int,4),
					new SqlParameter("@goods_price", SqlDbType.Int,4),
					new SqlParameter("@goods_attr", SqlDbType.VarChar,100),
					new SqlParameter("@send_number", SqlDbType.Int,4),
					new SqlParameter("@is_real", SqlDbType.Int,4),
					new SqlParameter("@extension_code", SqlDbType.VarChar,100),
					new SqlParameter("@parent_id", SqlDbType.Int,4),
					new SqlParameter("@is_gift", SqlDbType.Int,4)};
            parameters[0].Value = model.order_id;
            parameters[1].Value = model.goods_id;
            parameters[2].Value = model.goods_name;
            parameters[3].Value = model.goods_sn;
            parameters[4].Value = model.goods_number;
            parameters[5].Value = model.market_price;
            parameters[6].Value = model.goods_price;
            parameters[7].Value = model.goods_attr;
            parameters[8].Value = model.send_number;
            parameters[9].Value = model.is_real;
            parameters[10].Value = model.extension_code;
            parameters[11].Value = model.parent_id;
            parameters[12].Value = model.is_gift;

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
        public bool Update(ROYcms.Sys.Model.ROYcms_Goods_Order_Detail model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ROYcms_Goods_Order_Detail set ");
            strSql.Append("order_id=@order_id,");
            strSql.Append("goods_id=@goods_id,");
            strSql.Append("goods_name=@goods_name,");
            strSql.Append("goods_sn=@goods_sn,");
            strSql.Append("goods_number=@goods_number,");
            strSql.Append("market_price=@market_price,");
            strSql.Append("goods_price=@goods_price,");
            strSql.Append("goods_attr=@goods_attr,");
            strSql.Append("send_number=@send_number,");
            strSql.Append("is_real=@is_real,");
            strSql.Append("extension_code=@extension_code,");
            strSql.Append("parent_id=@parent_id,");
            strSql.Append("is_gift=@is_gift");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@order_id", SqlDbType.VarChar,50),
					new SqlParameter("@goods_id", SqlDbType.Int,4),
					new SqlParameter("@goods_name", SqlDbType.VarChar,500),
					new SqlParameter("@goods_sn", SqlDbType.VarChar,100),
					new SqlParameter("@goods_number", SqlDbType.Int,4),
					new SqlParameter("@market_price", SqlDbType.Int,4),
					new SqlParameter("@goods_price", SqlDbType.Int,4),
					new SqlParameter("@goods_attr", SqlDbType.VarChar,100),
					new SqlParameter("@send_number", SqlDbType.Int,4),
					new SqlParameter("@is_real", SqlDbType.Int,4),
					new SqlParameter("@extension_code", SqlDbType.VarChar,100),
					new SqlParameter("@parent_id", SqlDbType.Int,4),
					new SqlParameter("@is_gift", SqlDbType.Int,4),
					new SqlParameter("@Id", SqlDbType.Int,4)};
            parameters[0].Value = model.order_id;
            parameters[1].Value = model.goods_id;
            parameters[2].Value = model.goods_name;
            parameters[3].Value = model.goods_sn;
            parameters[4].Value = model.goods_number;
            parameters[5].Value = model.market_price;
            parameters[6].Value = model.goods_price;
            parameters[7].Value = model.goods_attr;
            parameters[8].Value = model.send_number;
            parameters[9].Value = model.is_real;
            parameters[10].Value = model.extension_code;
            parameters[11].Value = model.parent_id;
            parameters[12].Value = model.is_gift;
            parameters[13].Value = model.Id;

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
            strSql.Append("delete from ROYcms_Goods_Order_Detail ");
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
            strSql.Append("delete from ROYcms_Goods_Order_Detail ");
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
        public ROYcms.Sys.Model.ROYcms_Goods_Order_Detail GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,order_id,goods_id,goods_name,goods_sn,goods_number,market_price,goods_price,goods_attr,send_number,is_real,extension_code,parent_id,is_gift from ROYcms_Goods_Order_Detail ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
};
            parameters[0].Value = Id;

            ROYcms.Sys.Model.ROYcms_Goods_Order_Detail model = new ROYcms.Sys.Model.ROYcms_Goods_Order_Detail();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["Id"] != null && ds.Tables[0].Rows[0]["Id"].ToString() != "")
                {
                    model.Id = int.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["order_id"] != null && ds.Tables[0].Rows[0]["order_id"].ToString() != "")
                {
                    model.order_id = ds.Tables[0].Rows[0]["order_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["goods_id"] != null && ds.Tables[0].Rows[0]["goods_id"].ToString() != "")
                {
                    model.goods_id = int.Parse(ds.Tables[0].Rows[0]["goods_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["goods_name"] != null && ds.Tables[0].Rows[0]["goods_name"].ToString() != "")
                {
                    model.goods_name = ds.Tables[0].Rows[0]["goods_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["goods_sn"] != null && ds.Tables[0].Rows[0]["goods_sn"].ToString() != "")
                {
                    model.goods_sn = ds.Tables[0].Rows[0]["goods_sn"].ToString();
                }
                if (ds.Tables[0].Rows[0]["goods_number"] != null && ds.Tables[0].Rows[0]["goods_number"].ToString() != "")
                {
                    model.goods_number = int.Parse(ds.Tables[0].Rows[0]["goods_number"].ToString());
                }
                if (ds.Tables[0].Rows[0]["market_price"] != null && ds.Tables[0].Rows[0]["market_price"].ToString() != "")
                {
                    model.market_price = int.Parse(ds.Tables[0].Rows[0]["market_price"].ToString());
                }
                if (ds.Tables[0].Rows[0]["goods_price"] != null && ds.Tables[0].Rows[0]["goods_price"].ToString() != "")
                {
                    model.goods_price = int.Parse(ds.Tables[0].Rows[0]["goods_price"].ToString());
                }
                if (ds.Tables[0].Rows[0]["goods_attr"] != null && ds.Tables[0].Rows[0]["goods_attr"].ToString() != "")
                {
                    model.goods_attr = ds.Tables[0].Rows[0]["goods_attr"].ToString();
                }
                if (ds.Tables[0].Rows[0]["send_number"] != null && ds.Tables[0].Rows[0]["send_number"].ToString() != "")
                {
                    model.send_number = int.Parse(ds.Tables[0].Rows[0]["send_number"].ToString());
                }
                if (ds.Tables[0].Rows[0]["is_real"] != null && ds.Tables[0].Rows[0]["is_real"].ToString() != "")
                {
                    model.is_real = int.Parse(ds.Tables[0].Rows[0]["is_real"].ToString());
                }
                if (ds.Tables[0].Rows[0]["extension_code"] != null && ds.Tables[0].Rows[0]["extension_code"].ToString() != "")
                {
                    model.extension_code = ds.Tables[0].Rows[0]["extension_code"].ToString();
                }
                if (ds.Tables[0].Rows[0]["parent_id"] != null && ds.Tables[0].Rows[0]["parent_id"].ToString() != "")
                {
                    model.parent_id = int.Parse(ds.Tables[0].Rows[0]["parent_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["is_gift"] != null && ds.Tables[0].Rows[0]["is_gift"].ToString() != "")
                {
                    model.is_gift = int.Parse(ds.Tables[0].Rows[0]["is_gift"].ToString());
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
            strSql.Append("select Id,order_id,goods_id,goods_name,goods_sn,goods_number,market_price,goods_price,goods_attr,send_number,is_real,extension_code,parent_id,is_gift ");
            strSql.Append(" FROM ROYcms_Goods_Order_Detail ");
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
            strSql.Append(" Id,order_id,goods_id,goods_name,goods_sn,goods_number,market_price,goods_price,goods_attr,send_number,is_real,extension_code,parent_id,is_gift ");
            strSql.Append(" FROM ROYcms_Goods_Order_Detail ");
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
            strSql.Append("select count(1) FROM ROYcms_Goods_Order_Detail ");
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
            strSql.Append(")AS Row, T.*  from ROYcms_Goods_Order_Detail T ");
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
            parameters[0].Value = "ROYcms_Goods_Order_Detail";
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

