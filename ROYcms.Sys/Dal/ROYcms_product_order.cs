using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ROYcms.DB;
//using System.Web.UI.WebControls;//请先添加引用
namespace ROYcms.Sys.DAL
{
    /// <summary>
    /// 数据访问类ROYcms_news。
    /// </summary>
    public class ROYcms_product_order
    {
        public ROYcms_product_order()
        { }
        #region  成员方法
      
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int bh)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from "+PubConstant.date_prefix+"product_order");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = bh;

            return ROYcms.DB.DbHelpers.Exists(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 获得数据列表 SQL语句地定义
        /// </summary>
        public DataSet GetList_(string strSql)
        {
            return ROYcms.DB.DbHelpers.GetDataSet(strSql);
        }
      
        /// <summary>
        /// 获取 单个值  单个字段 通过订单号
        /// </summary>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        public string GetField(string Id, string Field)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select " + Field + " from " + PubConstant.date_prefix + "product_order");
            strSql.Append(" where order_id='" + Id + "' ");
            //GetDataSet(strSql.ToString());
            return Convert.ToString(ROYcms.DB.DbHelpers.GetSingle(strSql.ToString()));

        }
     
     
        /// <summary>
        /// 返回长查询数据总数 （分页用到）
        /// </summary>
        public int GetCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) as H ");
            strSql.Append(" FROM [" + PubConstant.date_prefix + "product_order] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return Convert.ToInt32(ROYcms.DB.DbHelpers.GetSingle(strSql.ToString()));
        }
        /// <summary>
        /// 修改订单状态
        /// </summary>
        public void order_status(string order_id, string order_status)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update " + PubConstant.date_prefix + "product_order set ");
            strSql.Append("order_status=@order_status");
            strSql.Append(" where order_id=@order_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@order_id", SqlDbType.Char,16),
					new SqlParameter("@order_status", SqlDbType.Char,4)
                                        };
            parameters[0].Value = order_id;
            parameters[1].Value = order_status;
            ROYcms.DB.DbHelpers.NonQuery(strSql.ToString(), parameters);
        }
   
      
       
        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        public int Add(ROYcms.Sys.Model.ROYcms_product_order model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into "+ PubConstant.date_prefix + "product_order(");
            strSql.Append("order_id,user_id,order_status,order_price,order_payment,order_rec_name,order_rec_address,order_rec_code,order_rec_phone,order_rec_tel,order_shipping,order_freight,order_deliveryTime,create_time,ifdefault)");
            strSql.Append(" values (");
            strSql.Append("@order_id,@user_id,@order_status,@order_price,@order_payment,@order_rec_name,@order_rec_address,@order_rec_code,@order_rec_phone,@order_rec_tel,@order_shipping,@order_freight,@order_deliveryTime,@create_time,@ifdefault)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@order_id", SqlDbType.Char,16),
					new SqlParameter("@user_id", SqlDbType.Char,10),
					new SqlParameter("@order_status", SqlDbType.Char,4),
					new SqlParameter("@order_price", SqlDbType.Decimal,9),
					new SqlParameter("@order_payment", SqlDbType.NVarChar,20),
					new SqlParameter("@order_rec_name", SqlDbType.NVarChar,10),
					new SqlParameter("@order_rec_address", SqlDbType.NVarChar,50),
					new SqlParameter("@order_rec_code", SqlDbType.Char,6),
					new SqlParameter("@order_rec_phone", SqlDbType.Char,11),
					new SqlParameter("@order_rec_tel", SqlDbType.VarChar,15),
					new SqlParameter("@order_shipping", SqlDbType.NVarChar,50),
					new SqlParameter("@order_freight", SqlDbType.Decimal,9),
					new SqlParameter("@order_deliveryTime", SqlDbType.NVarChar,20),
					new SqlParameter("@create_time", SqlDbType.DateTime),
					new SqlParameter("@ifdefault", SqlDbType.Bit,1)};
            parameters[0].Value = model.order_id;
            parameters[1].Value = model.user_id;
            parameters[2].Value = model.order_status;
            parameters[3].Value = model.order_price;
            parameters[4].Value = model.order_payment;
            parameters[5].Value = model.order_rec_name;
            parameters[6].Value = model.order_rec_address;
            parameters[7].Value = model.order_rec_code;
            parameters[8].Value = model.order_rec_phone;
            parameters[9].Value = model.order_rec_tel;
            parameters[10].Value = model.order_shipping;
            parameters[11].Value = model.order_freight;
            parameters[12].Value = model.order_deliveryTime;
            parameters[13].Value = model.create_time;
            parameters[14].Value = model.ifdefault;

            object obj = ROYcms.DB.DbHelpers.GetSingle(strSql.ToString(), parameters);
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
        public bool Update(ROYcms.Sys.Model.ROYcms_product_order model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update "+ PubConstant.date_prefix + "product_order set ");
            strSql.Append("order_id=@order_id,");
            strSql.Append("user_id=@user_id,");
            strSql.Append("order_status=@order_status,");
            strSql.Append("order_price=@order_price,");
            strSql.Append("order_payment=@order_payment,");
            strSql.Append("order_rec_name=@order_rec_name,");
            strSql.Append("order_rec_address=@order_rec_address,");
            strSql.Append("order_rec_code=@order_rec_code,");
            strSql.Append("order_rec_phone=@order_rec_phone,");
            strSql.Append("order_rec_tel=@order_rec_tel,");
            strSql.Append("order_shipping=@order_shipping,");
            strSql.Append("order_freight=@order_freight,");
            strSql.Append("order_deliveryTime=@order_deliveryTime,");
            strSql.Append("create_time=@create_time,");
            strSql.Append("ifdefault=@ifdefault");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@order_id", SqlDbType.Char,16),
					new SqlParameter("@user_id", SqlDbType.Char,10),
					new SqlParameter("@order_status", SqlDbType.Char,4),
					new SqlParameter("@order_price", SqlDbType.Decimal,9),
					new SqlParameter("@order_payment", SqlDbType.NVarChar,20),
					new SqlParameter("@order_rec_name", SqlDbType.NVarChar,10),
					new SqlParameter("@order_rec_address", SqlDbType.NVarChar,50),
					new SqlParameter("@order_rec_code", SqlDbType.Char,6),
					new SqlParameter("@order_rec_phone", SqlDbType.Char,11),
					new SqlParameter("@order_rec_tel", SqlDbType.VarChar,15),
					new SqlParameter("@order_shipping", SqlDbType.NVarChar,50),
					new SqlParameter("@order_freight", SqlDbType.Decimal,9),
					new SqlParameter("@order_deliveryTime", SqlDbType.NVarChar,20),
					new SqlParameter("@create_time", SqlDbType.DateTime),
					new SqlParameter("@ifdefault", SqlDbType.Bit,1),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = model.order_id;
            parameters[1].Value = model.user_id;
            parameters[2].Value = model.order_status;
            parameters[3].Value = model.order_price;
            parameters[4].Value = model.order_payment;
            parameters[5].Value = model.order_rec_name;
            parameters[6].Value = model.order_rec_address;
            parameters[7].Value = model.order_rec_code;
            parameters[8].Value = model.order_rec_phone;
            parameters[9].Value = model.order_rec_tel;
            parameters[10].Value = model.order_shipping;
            parameters[11].Value = model.order_freight;
            parameters[12].Value = model.order_deliveryTime;
            parameters[13].Value = model.create_time;
            parameters[14].Value = model.ifdefault;
            parameters[15].Value = model.id;

            int rows = ROYcms.DB.DbHelpers.NonQuery(strSql.ToString(), parameters);
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
        public void Delete(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete " + PubConstant.date_prefix + "product_order ");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = id;

            ROYcms.DB.DbHelpers.NonQuery(strSql.ToString(), parameters);
        }
      


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM " + PubConstant.date_prefix + "product_order ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return ROYcms.DB.DbHelpers.GetDataSet(strSql.ToString());
        }

        /// <summary>
        /// 自定义SQL语句返回DataSet
        /// </summary>
        public DataSet _GetDataSet(string SQL)
        {
            return ROYcms.DB.DbHelpers.GetDataSet(SQL);
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
            strSql.Append(" * ");
            strSql.Append(" from " + PubConstant.date_prefix + "product_order ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return ROYcms.DB.DbHelpers.GetDataSet(strSql.ToString());
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        /// <param name="PageSize">Size of the page.</param>
        /// <param name="PageIndex">Index of the page.</param>
        /// <param name="strWhere">The STR where.</param>
        /// <returns></returns>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, int OrderType)
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
            parameters[0].Value = ""+PubConstant.date_prefix+"product_order";
            parameters[1].Value = "id";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = OrderType;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        /// <param name="PageSize">Size of the page.</param>
        /// <param name="PageIndex">Index of the page.</param>
        /// <param name="strWhere">The STR where.</param>
        /// <returns></returns>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere)
        {
         return  GetList(PageSize, PageIndex, strWhere, 0);
        }

        #endregion  成员方法
    }


}

