using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ROYcms.DB;//Please add references
namespace ROYcms.Sys.DAL
{
    /// <summary>
    /// 数据访问类:ROYcms_Transaction
    /// </summary>
    public partial class ROYcms_Transaction
    {
        public ROYcms_Transaction()
        { }
        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id, int UserId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ROYcms_Transaction");
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
        public int Add(ROYcms.Sys.Model.ROYcms_Transaction model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ROYcms_Transaction(");
            strSql.Append("UserId,TradeType,Price,AccountBalance,PayentMethord,TradeExplaining,PaymentLogo,Remark,CreateTime)");
            strSql.Append(" values (");
            strSql.Append("@UserId,@TradeType,@Price,@AccountBalance,@PayentMethord,@TradeExplaining,@PaymentLogo,@Remark,@CreateTime)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@UserId", SqlDbType.Int,4),
					new SqlParameter("@TradeType", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.Int,4),
					new SqlParameter("@AccountBalance", SqlDbType.Int,4),
					new SqlParameter("@PayentMethord", SqlDbType.VarChar,50),
					new SqlParameter("@TradeExplaining", SqlDbType.VarChar,500),
					new SqlParameter("@PaymentLogo", SqlDbType.VarChar,100),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@CreateTime", SqlDbType.DateTime)};
            parameters[0].Value = model.UserId;
            parameters[1].Value = model.TradeType;
            parameters[2].Value = model.Price;
            parameters[3].Value = model.AccountBalance;
            parameters[4].Value = model.PayentMethord;
            parameters[5].Value = model.TradeExplaining;
            parameters[6].Value = model.PaymentLogo;
            parameters[7].Value = model.Remark;
            parameters[8].Value = model.CreateTime;

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
        public bool Update(ROYcms.Sys.Model.ROYcms_Transaction model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ROYcms_Transaction set ");
            strSql.Append("UserId=@UserId,");
            strSql.Append("TradeType=@TradeType,");
            strSql.Append("Price=@Price,");
            strSql.Append("AccountBalance=@AccountBalance,");
            strSql.Append("PayentMethord=@PayentMethord,");
            strSql.Append("TradeExplaining=@TradeExplaining,");
            strSql.Append("PaymentLogo=@PaymentLogo,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("CreateTime=@CreateTime");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@UserId", SqlDbType.Int,4),
					new SqlParameter("@TradeType", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.Int,4),
					new SqlParameter("@AccountBalance", SqlDbType.Int,4),
					new SqlParameter("@PayentMethord", SqlDbType.VarChar,50),
					new SqlParameter("@TradeExplaining", SqlDbType.VarChar,500),
					new SqlParameter("@PaymentLogo", SqlDbType.VarChar,100),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@Id", SqlDbType.Int,4)};
            parameters[0].Value = model.UserId;
            parameters[1].Value = model.TradeType;
            parameters[2].Value = model.Price;
            parameters[3].Value = model.AccountBalance;
            parameters[4].Value = model.PayentMethord;
            parameters[5].Value = model.TradeExplaining;
            parameters[6].Value = model.PaymentLogo;
            parameters[7].Value = model.Remark;
            parameters[8].Value = model.CreateTime;
            parameters[9].Value = model.Id;

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
            strSql.Append("delete from ROYcms_Transaction ");
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
            strSql.Append("delete from ROYcms_Transaction ");
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
        public ROYcms.Sys.Model.ROYcms_Transaction GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,UserId,TradeType,Price,AccountBalance,PayentMethord,TradeExplaining,PaymentLogo,Remark,CreateTime from ROYcms_Transaction ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
};
            parameters[0].Value = Id;

            ROYcms.Sys.Model.ROYcms_Transaction model = new ROYcms.Sys.Model.ROYcms_Transaction();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["Id"] != null && ds.Tables[0].Rows[0]["Id"].ToString() != "")
                {
                    model.Id = int.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UserId"] != null && ds.Tables[0].Rows[0]["UserId"].ToString() != "")
                {
                    model.UserId = int.Parse(ds.Tables[0].Rows[0]["UserId"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TradeType"] != null && ds.Tables[0].Rows[0]["TradeType"].ToString() != "")
                {
                    model.TradeType = int.Parse(ds.Tables[0].Rows[0]["TradeType"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Price"] != null && ds.Tables[0].Rows[0]["Price"].ToString() != "")
                {
                    model.Price = int.Parse(ds.Tables[0].Rows[0]["Price"].ToString());
                }
                if (ds.Tables[0].Rows[0]["AccountBalance"] != null && ds.Tables[0].Rows[0]["AccountBalance"].ToString() != "")
                {
                    model.AccountBalance = int.Parse(ds.Tables[0].Rows[0]["AccountBalance"].ToString());
                }
                if (ds.Tables[0].Rows[0]["PayentMethord"] != null && ds.Tables[0].Rows[0]["PayentMethord"].ToString() != "")
                {
                    model.PayentMethord = ds.Tables[0].Rows[0]["PayentMethord"].ToString();
                }
                if (ds.Tables[0].Rows[0]["TradeExplaining"] != null && ds.Tables[0].Rows[0]["TradeExplaining"].ToString() != "")
                {
                    model.TradeExplaining = ds.Tables[0].Rows[0]["TradeExplaining"].ToString();
                }
                if (ds.Tables[0].Rows[0]["PaymentLogo"] != null && ds.Tables[0].Rows[0]["PaymentLogo"].ToString() != "")
                {
                    model.PaymentLogo = ds.Tables[0].Rows[0]["PaymentLogo"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Remark"] != null && ds.Tables[0].Rows[0]["Remark"].ToString() != "")
                {
                    model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                }
                if (ds.Tables[0].Rows[0]["CreateTime"] != null && ds.Tables[0].Rows[0]["CreateTime"].ToString() != "")
                {
                    model.CreateTime = DateTime.Parse(ds.Tables[0].Rows[0]["CreateTime"].ToString());
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
            strSql.Append("select Id,UserId,TradeType,Price,AccountBalance,PayentMethord,TradeExplaining,PaymentLogo,Remark,CreateTime ");
            strSql.Append(" FROM ROYcms_Transaction ");
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
            strSql.Append(" Id,UserId,TradeType,Price,AccountBalance,PayentMethord,TradeExplaining,PaymentLogo,Remark,CreateTime ");
            strSql.Append(" FROM ROYcms_Transaction ");
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
            strSql.Append("select count(1) FROM ROYcms_Transaction ");
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
            strSql.Append(")AS Row, T.*  from ROYcms_Transaction T ");
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
            parameters[0].Value = "ROYcms_Transaction";
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

