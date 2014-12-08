using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ROYcms.DB;
namespace ROYcms.Sys.DAL
{
    /// <summary>
    /// 数据访问类:ROYcms_Goods_Order
    /// </summary>
    public partial class ROYcms_Goods_Order
    {
        public ROYcms_Goods_Order()
        { }
        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ROYcms_Goods_Order");
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
        public int Add(ROYcms.Sys.Model.ROYcms_Goods_Order model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ROYcms_Goods_Order(");
            strSql.Append("order_sn,user_id,order_status,shipping_status,pay_status,consignee,country,province,city,district,address,zipcode,tel,mobile,email,best_time,sign_building,postscript,shipping_id,shipping_name,pay_id,pay_name,how_oos,how_surplus,pack_name,card_name,card_message,inv_payee,inv_content,goods_amount,shipping_fee,insure_fee,pay_fee,pack_fee,card_fee,money_paid,surplus,Integeregral,Integeregral_money,bonus,order_amount,from_ad,referer,add_time,confirm_time,pay_time,shipping_time,pack_id,card_id,bonus_id,invoice_no,extension_code,extension_id,to_buyer,pay_note,agency_id,inv_type,tax,is_separate,parent_id,discount)");
            strSql.Append(" values (");
            strSql.Append("@order_sn,@user_id,@order_status,@shipping_status,@pay_status,@consignee,@country,@province,@city,@district,@address,@zipcode,@tel,@mobile,@email,@best_time,@sign_building,@postscript,@shipping_id,@shipping_name,@pay_id,@pay_name,@how_oos,@how_surplus,@pack_name,@card_name,@card_message,@inv_payee,@inv_content,@goods_amount,@shipping_fee,@insure_fee,@pay_fee,@pack_fee,@card_fee,@money_paid,@surplus,@Integeregral,@Integeregral_money,@bonus,@order_amount,@from_ad,@referer,@add_time,@confirm_time,@pay_time,@shipping_time,@pack_id,@card_id,@bonus_id,@invoice_no,@extension_code,@extension_id,@to_buyer,@pay_note,@agency_id,@inv_type,@tax,@is_separate,@parent_id,@discount)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@order_sn", SqlDbType.VarChar,50),
					new SqlParameter("@user_id", SqlDbType.Int,4),
					new SqlParameter("@order_status", SqlDbType.Int,4),
					new SqlParameter("@shipping_status", SqlDbType.Int,4),
					new SqlParameter("@pay_status", SqlDbType.Int,4),
					new SqlParameter("@consignee", SqlDbType.VarChar,50),
					new SqlParameter("@country", SqlDbType.VarChar,50),
					new SqlParameter("@province", SqlDbType.VarChar,50),
					new SqlParameter("@city", SqlDbType.VarChar,50),
					new SqlParameter("@district", SqlDbType.VarChar,50),
					new SqlParameter("@address", SqlDbType.VarChar,500),
					new SqlParameter("@zipcode", SqlDbType.VarChar,60),
					new SqlParameter("@tel", SqlDbType.VarChar,60),
					new SqlParameter("@mobile", SqlDbType.VarChar,60),
					new SqlParameter("@email", SqlDbType.VarChar,60),
					new SqlParameter("@best_time", SqlDbType.Int,4),
					new SqlParameter("@sign_building", SqlDbType.VarChar,120),
					new SqlParameter("@postscript", SqlDbType.VarChar,500),
					new SqlParameter("@shipping_id", SqlDbType.Int,4),
					new SqlParameter("@shipping_name", SqlDbType.VarChar,120),
					new SqlParameter("@pay_id", SqlDbType.Int,4),
					new SqlParameter("@pay_name", SqlDbType.VarChar,120),
					new SqlParameter("@how_oos", SqlDbType.Int,4),
					new SqlParameter("@how_surplus", SqlDbType.Int,4),
					new SqlParameter("@pack_name", SqlDbType.VarChar,120),
					new SqlParameter("@card_name", SqlDbType.VarChar,120),
					new SqlParameter("@card_message", SqlDbType.VarChar,255),
					new SqlParameter("@inv_payee", SqlDbType.VarChar,120),
					new SqlParameter("@inv_content", SqlDbType.VarChar,120),
					new SqlParameter("@goods_amount", SqlDbType.Int,4),
					new SqlParameter("@shipping_fee", SqlDbType.VarChar,10),
					new SqlParameter("@insure_fee", SqlDbType.Int,4),
					new SqlParameter("@pay_fee", SqlDbType.VarChar,50),
					new SqlParameter("@pack_fee", SqlDbType.VarChar,10),
					new SqlParameter("@card_fee", SqlDbType.VarChar,10),
					new SqlParameter("@money_paid", SqlDbType.Int,4),
					new SqlParameter("@surplus", SqlDbType.VarChar,50),
					new SqlParameter("@Integeregral", SqlDbType.Int,4),
					new SqlParameter("@Integeregral_money", SqlDbType.Int,4),
					new SqlParameter("@bonus", SqlDbType.Int,4),
					new SqlParameter("@order_amount", SqlDbType.Int,4),
					new SqlParameter("@from_ad", SqlDbType.Int,4),
					new SqlParameter("@referer", SqlDbType.VarChar,255),
					new SqlParameter("@add_time", SqlDbType.DateTime),
					new SqlParameter("@confirm_time", SqlDbType.DateTime),
					new SqlParameter("@pay_time", SqlDbType.DateTime),
					new SqlParameter("@shipping_time", SqlDbType.DateTime),
					new SqlParameter("@pack_id", SqlDbType.Int,4),
					new SqlParameter("@card_id", SqlDbType.Int,4),
					new SqlParameter("@bonus_id", SqlDbType.Int,4),
					new SqlParameter("@invoice_no", SqlDbType.VarChar,50),
					new SqlParameter("@extension_code", SqlDbType.Int,4),
					new SqlParameter("@extension_id", SqlDbType.Int,4),
					new SqlParameter("@to_buyer", SqlDbType.VarChar,255),
					new SqlParameter("@pay_note", SqlDbType.VarChar,255),
					new SqlParameter("@agency_id", SqlDbType.Int,4),
					new SqlParameter("@inv_type", SqlDbType.VarChar,60),
					new SqlParameter("@tax", SqlDbType.VarChar,10),
					new SqlParameter("@is_separate", SqlDbType.Int,4),
					new SqlParameter("@parent_id", SqlDbType.Int,4),
					new SqlParameter("@discount", SqlDbType.VarChar,10)};
            parameters[0].Value = model.order_sn;
            parameters[1].Value = model.user_id;
            parameters[2].Value = model.order_status;
            parameters[3].Value = model.shipping_status;
            parameters[4].Value = model.pay_status;
            parameters[5].Value = model.consignee;
            parameters[6].Value = model.country;
            parameters[7].Value = model.province;
            parameters[8].Value = model.city;
            parameters[9].Value = model.district;
            parameters[10].Value = model.address;
            parameters[11].Value = model.zipcode;
            parameters[12].Value = model.tel;
            parameters[13].Value = model.mobile;
            parameters[14].Value = model.email;
            parameters[15].Value = model.best_time;
            parameters[16].Value = model.sign_building;
            parameters[17].Value = model.postscript;
            parameters[18].Value = model.shipping_id;
            parameters[19].Value = model.shipping_name;
            parameters[20].Value = model.pay_id;
            parameters[21].Value = model.pay_name;
            parameters[22].Value = model.how_oos;
            parameters[23].Value = model.how_surplus;
            parameters[24].Value = model.pack_name;
            parameters[25].Value = model.card_name;
            parameters[26].Value = model.card_message;
            parameters[27].Value = model.inv_payee;
            parameters[28].Value = model.inv_content;
            parameters[29].Value = model.goods_amount;
            parameters[30].Value = model.shipping_fee;
            parameters[31].Value = model.insure_fee;
            parameters[32].Value = model.pay_fee;
            parameters[33].Value = model.pack_fee;
            parameters[34].Value = model.card_fee;
            parameters[35].Value = model.money_paid;
            parameters[36].Value = model.surplus;
            parameters[37].Value = model.Integeregral;
            parameters[38].Value = model.Integeregral_money;
            parameters[39].Value = model.bonus;
            parameters[40].Value = model.order_amount;
            parameters[41].Value = model.from_ad;
            parameters[42].Value = model.referer;
            parameters[43].Value = model.add_time;
            parameters[44].Value = model.confirm_time;
            parameters[45].Value = model.pay_time;
            parameters[46].Value = model.shipping_time;
            parameters[47].Value = model.pack_id;
            parameters[48].Value = model.card_id;
            parameters[49].Value = model.bonus_id;
            parameters[50].Value = model.invoice_no;
            parameters[51].Value = model.extension_code;
            parameters[52].Value = model.extension_id;
            parameters[53].Value = model.to_buyer;
            parameters[54].Value = model.pay_note;
            parameters[55].Value = model.agency_id;
            parameters[56].Value = model.inv_type;
            parameters[57].Value = model.tax;
            parameters[58].Value = model.is_separate;
            parameters[59].Value = model.parent_id;
            parameters[60].Value = model.discount;

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
        public bool Update_(ROYcms.Sys.Model.ROYcms_Goods_Order model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ROYcms_Goods_Order set ");
            strSql.Append("order_sn=@order_sn,");
            strSql.Append("user_id=@user_id,");
            strSql.Append("order_status=@order_status,");
            strSql.Append("shipping_status=@shipping_status,");
            strSql.Append("pay_status=@pay_status,");
            strSql.Append("consignee=@consignee,");
            strSql.Append("country=@country,");
            strSql.Append("province=@province,");
            strSql.Append("city=@city,");
            strSql.Append("district=@district,");
            strSql.Append("address=@address,");
            strSql.Append("zipcode=@zipcode,");
            strSql.Append("tel=@tel,");
            strSql.Append("mobile=@mobile,");
            strSql.Append("email=@email,");
            strSql.Append("best_time=@best_time,");
            strSql.Append("sign_building=@sign_building,");
            strSql.Append("postscript=@postscript,");
            strSql.Append("shipping_id=@shipping_id,");
            strSql.Append("shipping_name=@shipping_name,");
            strSql.Append("pay_id=@pay_id,");
            strSql.Append("pay_name=@pay_name,");
            strSql.Append("how_oos=@how_oos,");
            strSql.Append("how_surplus=@how_surplus,");
            strSql.Append("pack_name=@pack_name,");
            strSql.Append("card_name=@card_name,");
            strSql.Append("card_message=@card_message,");
            strSql.Append("inv_payee=@inv_payee,");
            strSql.Append("inv_content=@inv_content,");
            strSql.Append("goods_amount=@goods_amount,");
            strSql.Append("shipping_fee=@shipping_fee,");
            strSql.Append("insure_fee=@insure_fee,");
            strSql.Append("pay_fee=@pay_fee,");
            strSql.Append("pack_fee=@pack_fee,");
            strSql.Append("card_fee=@card_fee,");
            strSql.Append("money_paid=@money_paid,");
            strSql.Append("surplus=@surplus,");
            strSql.Append("Integeregral=@Integeregral,");
            strSql.Append("Integeregral_money=@Integeregral_money,");
            strSql.Append("bonus=@bonus,");
            strSql.Append("order_amount=@order_amount,");
            strSql.Append("from_ad=@from_ad,");
            strSql.Append("referer=@referer,");
            strSql.Append("add_time=@add_time,");
            strSql.Append("confirm_time=@confirm_time,");
            strSql.Append("pay_time=@pay_time,");
            strSql.Append("shipping_time=@shipping_time,");
            strSql.Append("pack_id=@pack_id,");
            strSql.Append("card_id=@card_id,");
            strSql.Append("bonus_id=@bonus_id,");
            strSql.Append("invoice_no=@invoice_no,");
            strSql.Append("extension_code=@extension_code,");
            strSql.Append("extension_id=@extension_id,");
            strSql.Append("to_buyer=@to_buyer,");
            strSql.Append("pay_note=@pay_note,");
            strSql.Append("agency_id=@agency_id,");
            strSql.Append("inv_type=@inv_type,");
            strSql.Append("tax=@tax,");
            strSql.Append("is_separate=@is_separate,");
            strSql.Append("parent_id=@parent_id,");
            strSql.Append("discount=@discount");
            strSql.Append(" where order_sn=@order_sn");
            SqlParameter[] parameters = {
					new SqlParameter("@order_sn", SqlDbType.VarChar,50),
					new SqlParameter("@user_id", SqlDbType.Int,4),
					new SqlParameter("@order_status", SqlDbType.Int,4),
					new SqlParameter("@shipping_status", SqlDbType.Int,4),
					new SqlParameter("@pay_status", SqlDbType.Int,4),
					new SqlParameter("@consignee", SqlDbType.VarChar,50),
					new SqlParameter("@country", SqlDbType.VarChar,50),
					new SqlParameter("@province", SqlDbType.VarChar,50),
					new SqlParameter("@city", SqlDbType.VarChar,50),
					new SqlParameter("@district", SqlDbType.VarChar,50),
					new SqlParameter("@address", SqlDbType.VarChar,500),
					new SqlParameter("@zipcode", SqlDbType.VarChar,60),
					new SqlParameter("@tel", SqlDbType.VarChar,60),
					new SqlParameter("@mobile", SqlDbType.VarChar,60),
					new SqlParameter("@email", SqlDbType.VarChar,60),
					new SqlParameter("@best_time", SqlDbType.Int,4),
					new SqlParameter("@sign_building", SqlDbType.VarChar,120),
					new SqlParameter("@postscript", SqlDbType.VarChar,500),
					new SqlParameter("@shipping_id", SqlDbType.Int,4),
					new SqlParameter("@shipping_name", SqlDbType.VarChar,120),
					new SqlParameter("@pay_id", SqlDbType.Int,4),
					new SqlParameter("@pay_name", SqlDbType.VarChar,120),
					new SqlParameter("@how_oos", SqlDbType.Int,4),
					new SqlParameter("@how_surplus", SqlDbType.Int,4),
					new SqlParameter("@pack_name", SqlDbType.VarChar,120),
					new SqlParameter("@card_name", SqlDbType.VarChar,120),
					new SqlParameter("@card_message", SqlDbType.VarChar,255),
					new SqlParameter("@inv_payee", SqlDbType.VarChar,120),
					new SqlParameter("@inv_content", SqlDbType.VarChar,120),
					new SqlParameter("@goods_amount", SqlDbType.Int,4),
					new SqlParameter("@shipping_fee", SqlDbType.VarChar,10),
					new SqlParameter("@insure_fee", SqlDbType.Int,4),
					new SqlParameter("@pay_fee", SqlDbType.VarChar,50),
					new SqlParameter("@pack_fee", SqlDbType.VarChar,10),
					new SqlParameter("@card_fee", SqlDbType.VarChar,10),
					new SqlParameter("@money_paid", SqlDbType.Int,4),
					new SqlParameter("@surplus", SqlDbType.VarChar,50),
					new SqlParameter("@Integeregral", SqlDbType.Int,4),
					new SqlParameter("@Integeregral_money", SqlDbType.Int,4),
					new SqlParameter("@bonus", SqlDbType.Int,4),
					new SqlParameter("@order_amount", SqlDbType.Int,4),
					new SqlParameter("@from_ad", SqlDbType.Int,4),
					new SqlParameter("@referer", SqlDbType.VarChar,255),
					new SqlParameter("@add_time", SqlDbType.DateTime),
					new SqlParameter("@confirm_time", SqlDbType.DateTime),
					new SqlParameter("@pay_time", SqlDbType.DateTime),
					new SqlParameter("@shipping_time", SqlDbType.DateTime),
					new SqlParameter("@pack_id", SqlDbType.Int,4),
					new SqlParameter("@card_id", SqlDbType.Int,4),
					new SqlParameter("@bonus_id", SqlDbType.Int,4),
					new SqlParameter("@invoice_no", SqlDbType.VarChar,50),
					new SqlParameter("@extension_code", SqlDbType.Int,4),
					new SqlParameter("@extension_id", SqlDbType.Int,4),
					new SqlParameter("@to_buyer", SqlDbType.VarChar,255),
					new SqlParameter("@pay_note", SqlDbType.VarChar,255),
					new SqlParameter("@agency_id", SqlDbType.Int,4),
					new SqlParameter("@inv_type", SqlDbType.VarChar,60),
					new SqlParameter("@tax", SqlDbType.VarChar,10),
					new SqlParameter("@is_separate", SqlDbType.Int,4),
					new SqlParameter("@parent_id", SqlDbType.Int,4),
					new SqlParameter("@discount", SqlDbType.VarChar,10),
					new SqlParameter("@order_sn", SqlDbType.VarChar,50)};
            parameters[0].Value = model.order_sn;
            parameters[1].Value = model.user_id;
            parameters[2].Value = model.order_status;
            parameters[3].Value = model.shipping_status;
            parameters[4].Value = model.pay_status;
            parameters[5].Value = model.consignee;
            parameters[6].Value = model.country;
            parameters[7].Value = model.province;
            parameters[8].Value = model.city;
            parameters[9].Value = model.district;
            parameters[10].Value = model.address;
            parameters[11].Value = model.zipcode;
            parameters[12].Value = model.tel;
            parameters[13].Value = model.mobile;
            parameters[14].Value = model.email;
            parameters[15].Value = model.best_time;
            parameters[16].Value = model.sign_building;
            parameters[17].Value = model.postscript;
            parameters[18].Value = model.shipping_id;
            parameters[19].Value = model.shipping_name;
            parameters[20].Value = model.pay_id;
            parameters[21].Value = model.pay_name;
            parameters[22].Value = model.how_oos;
            parameters[23].Value = model.how_surplus;
            parameters[24].Value = model.pack_name;
            parameters[25].Value = model.card_name;
            parameters[26].Value = model.card_message;
            parameters[27].Value = model.inv_payee;
            parameters[28].Value = model.inv_content;
            parameters[29].Value = model.goods_amount;
            parameters[30].Value = model.shipping_fee;
            parameters[31].Value = model.insure_fee;
            parameters[32].Value = model.pay_fee;
            parameters[33].Value = model.pack_fee;
            parameters[34].Value = model.card_fee;
            parameters[35].Value = model.money_paid;
            parameters[36].Value = model.surplus;
            parameters[37].Value = model.Integeregral;
            parameters[38].Value = model.Integeregral_money;
            parameters[39].Value = model.bonus;
            parameters[40].Value = model.order_amount;
            parameters[41].Value = model.from_ad;
            parameters[42].Value = model.referer;
            parameters[43].Value = model.add_time;
            parameters[44].Value = model.confirm_time;
            parameters[45].Value = model.pay_time;
            parameters[46].Value = model.shipping_time;
            parameters[47].Value = model.pack_id;
            parameters[48].Value = model.card_id;
            parameters[49].Value = model.bonus_id;
            parameters[50].Value = model.invoice_no;
            parameters[51].Value = model.extension_code;
            parameters[52].Value = model.extension_id;
            parameters[53].Value = model.to_buyer;
            parameters[54].Value = model.pay_note;
            parameters[55].Value = model.agency_id;
            parameters[56].Value = model.inv_type;
            parameters[57].Value = model.tax;
            parameters[58].Value = model.is_separate;
            parameters[59].Value = model.parent_id;
            parameters[60].Value = model.discount;
            parameters[61].Value = model.order_sn;

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
        /// 更新一条数据
        /// </summary>
        public bool Update(ROYcms.Sys.Model.ROYcms_Goods_Order model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ROYcms_Goods_Order set ");
            strSql.Append("order_sn=@order_sn,");
            strSql.Append("user_id=@user_id,");
            strSql.Append("order_status=@order_status,");
            strSql.Append("shipping_status=@shipping_status,");
            strSql.Append("pay_status=@pay_status,");
            strSql.Append("consignee=@consignee,");
            strSql.Append("country=@country,");
            strSql.Append("province=@province,");
            strSql.Append("city=@city,");
            strSql.Append("district=@district,");
            strSql.Append("address=@address,");
            strSql.Append("zipcode=@zipcode,");
            strSql.Append("tel=@tel,");
            strSql.Append("mobile=@mobile,");
            strSql.Append("email=@email,");
            strSql.Append("best_time=@best_time,");
            strSql.Append("sign_building=@sign_building,");
            strSql.Append("postscript=@postscript,");
            strSql.Append("shipping_id=@shipping_id,");
            strSql.Append("shipping_name=@shipping_name,");
            strSql.Append("pay_id=@pay_id,");
            strSql.Append("pay_name=@pay_name,");
            strSql.Append("how_oos=@how_oos,");
            strSql.Append("how_surplus=@how_surplus,");
            strSql.Append("pack_name=@pack_name,");
            strSql.Append("card_name=@card_name,");
            strSql.Append("card_message=@card_message,");
            strSql.Append("inv_payee=@inv_payee,");
            strSql.Append("inv_content=@inv_content,");
            strSql.Append("goods_amount=@goods_amount,");
            strSql.Append("shipping_fee=@shipping_fee,");
            strSql.Append("insure_fee=@insure_fee,");
            strSql.Append("pay_fee=@pay_fee,");
            strSql.Append("pack_fee=@pack_fee,");
            strSql.Append("card_fee=@card_fee,");
            strSql.Append("money_paid=@money_paid,");
            strSql.Append("surplus=@surplus,");
            strSql.Append("Integeregral=@Integeregral,");
            strSql.Append("Integeregral_money=@Integeregral_money,");
            strSql.Append("bonus=@bonus,");
            strSql.Append("order_amount=@order_amount,");
            strSql.Append("from_ad=@from_ad,");
            strSql.Append("referer=@referer,");
            strSql.Append("add_time=@add_time,");
            strSql.Append("confirm_time=@confirm_time,");
            strSql.Append("pay_time=@pay_time,");
            strSql.Append("shipping_time=@shipping_time,");
            strSql.Append("pack_id=@pack_id,");
            strSql.Append("card_id=@card_id,");
            strSql.Append("bonus_id=@bonus_id,");
            strSql.Append("invoice_no=@invoice_no,");
            strSql.Append("extension_code=@extension_code,");
            strSql.Append("extension_id=@extension_id,");
            strSql.Append("to_buyer=@to_buyer,");
            strSql.Append("pay_note=@pay_note,");
            strSql.Append("agency_id=@agency_id,");
            strSql.Append("inv_type=@inv_type,");
            strSql.Append("tax=@tax,");
            strSql.Append("is_separate=@is_separate,");
            strSql.Append("parent_id=@parent_id,");
            strSql.Append("discount=@discount");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@order_sn", SqlDbType.VarChar,50),
					new SqlParameter("@user_id", SqlDbType.Int,4),
					new SqlParameter("@order_status", SqlDbType.Int,4),
					new SqlParameter("@shipping_status", SqlDbType.Int,4),
					new SqlParameter("@pay_status", SqlDbType.Int,4),
					new SqlParameter("@consignee", SqlDbType.VarChar,50),
					new SqlParameter("@country", SqlDbType.VarChar,50),
					new SqlParameter("@province", SqlDbType.VarChar,50),
					new SqlParameter("@city", SqlDbType.VarChar,50),
					new SqlParameter("@district", SqlDbType.VarChar,50),
					new SqlParameter("@address", SqlDbType.VarChar,500),
					new SqlParameter("@zipcode", SqlDbType.VarChar,60),
					new SqlParameter("@tel", SqlDbType.VarChar,60),
					new SqlParameter("@mobile", SqlDbType.VarChar,60),
					new SqlParameter("@email", SqlDbType.VarChar,60),
					new SqlParameter("@best_time", SqlDbType.Int,4),
					new SqlParameter("@sign_building", SqlDbType.VarChar,120),
					new SqlParameter("@postscript", SqlDbType.VarChar,500),
					new SqlParameter("@shipping_id", SqlDbType.Int,4),
					new SqlParameter("@shipping_name", SqlDbType.VarChar,120),
					new SqlParameter("@pay_id", SqlDbType.Int,4),
					new SqlParameter("@pay_name", SqlDbType.VarChar,120),
					new SqlParameter("@how_oos", SqlDbType.Int,4),
					new SqlParameter("@how_surplus", SqlDbType.Int,4),
					new SqlParameter("@pack_name", SqlDbType.VarChar,120),
					new SqlParameter("@card_name", SqlDbType.VarChar,120),
					new SqlParameter("@card_message", SqlDbType.VarChar,255),
					new SqlParameter("@inv_payee", SqlDbType.VarChar,120),
					new SqlParameter("@inv_content", SqlDbType.VarChar,120),
					new SqlParameter("@goods_amount", SqlDbType.Int,4),
					new SqlParameter("@shipping_fee", SqlDbType.VarChar,10),
					new SqlParameter("@insure_fee", SqlDbType.Int,4),
					new SqlParameter("@pay_fee", SqlDbType.VarChar,50),
					new SqlParameter("@pack_fee", SqlDbType.VarChar,10),
					new SqlParameter("@card_fee", SqlDbType.VarChar,10),
					new SqlParameter("@money_paid", SqlDbType.Int,4),
					new SqlParameter("@surplus", SqlDbType.VarChar,50),
					new SqlParameter("@Integeregral", SqlDbType.Int,4),
					new SqlParameter("@Integeregral_money", SqlDbType.Int,4),
					new SqlParameter("@bonus", SqlDbType.Int,4),
					new SqlParameter("@order_amount", SqlDbType.Int,4),
					new SqlParameter("@from_ad", SqlDbType.Int,4),
					new SqlParameter("@referer", SqlDbType.VarChar,255),
					new SqlParameter("@add_time", SqlDbType.DateTime),
					new SqlParameter("@confirm_time", SqlDbType.DateTime),
					new SqlParameter("@pay_time", SqlDbType.DateTime),
					new SqlParameter("@shipping_time", SqlDbType.DateTime),
					new SqlParameter("@pack_id", SqlDbType.Int,4),
					new SqlParameter("@card_id", SqlDbType.Int,4),
					new SqlParameter("@bonus_id", SqlDbType.Int,4),
					new SqlParameter("@invoice_no", SqlDbType.VarChar,50),
					new SqlParameter("@extension_code", SqlDbType.Int,4),
					new SqlParameter("@extension_id", SqlDbType.Int,4),
					new SqlParameter("@to_buyer", SqlDbType.VarChar,255),
					new SqlParameter("@pay_note", SqlDbType.VarChar,255),
					new SqlParameter("@agency_id", SqlDbType.Int,4),
					new SqlParameter("@inv_type", SqlDbType.VarChar,60),
					new SqlParameter("@tax", SqlDbType.VarChar,10),
					new SqlParameter("@is_separate", SqlDbType.Int,4),
					new SqlParameter("@parent_id", SqlDbType.Int,4),
					new SqlParameter("@discount", SqlDbType.VarChar,10),
					new SqlParameter("@Id", SqlDbType.Int,4)};
            parameters[0].Value = model.order_sn;
            parameters[1].Value = model.user_id;
            parameters[2].Value = model.order_status;
            parameters[3].Value = model.shipping_status;
            parameters[4].Value = model.pay_status;
            parameters[5].Value = model.consignee;
            parameters[6].Value = model.country;
            parameters[7].Value = model.province;
            parameters[8].Value = model.city;
            parameters[9].Value = model.district;
            parameters[10].Value = model.address;
            parameters[11].Value = model.zipcode;
            parameters[12].Value = model.tel;
            parameters[13].Value = model.mobile;
            parameters[14].Value = model.email;
            parameters[15].Value = model.best_time;
            parameters[16].Value = model.sign_building;
            parameters[17].Value = model.postscript;
            parameters[18].Value = model.shipping_id;
            parameters[19].Value = model.shipping_name;
            parameters[20].Value = model.pay_id;
            parameters[21].Value = model.pay_name;
            parameters[22].Value = model.how_oos;
            parameters[23].Value = model.how_surplus;
            parameters[24].Value = model.pack_name;
            parameters[25].Value = model.card_name;
            parameters[26].Value = model.card_message;
            parameters[27].Value = model.inv_payee;
            parameters[28].Value = model.inv_content;
            parameters[29].Value = model.goods_amount;
            parameters[30].Value = model.shipping_fee;
            parameters[31].Value = model.insure_fee;
            parameters[32].Value = model.pay_fee;
            parameters[33].Value = model.pack_fee;
            parameters[34].Value = model.card_fee;
            parameters[35].Value = model.money_paid;
            parameters[36].Value = model.surplus;
            parameters[37].Value = model.Integeregral;
            parameters[38].Value = model.Integeregral_money;
            parameters[39].Value = model.bonus;
            parameters[40].Value = model.order_amount;
            parameters[41].Value = model.from_ad;
            parameters[42].Value = model.referer;
            parameters[43].Value = model.add_time;
            parameters[44].Value = model.confirm_time;
            parameters[45].Value = model.pay_time;
            parameters[46].Value = model.shipping_time;
            parameters[47].Value = model.pack_id;
            parameters[48].Value = model.card_id;
            parameters[49].Value = model.bonus_id;
            parameters[50].Value = model.invoice_no;
            parameters[51].Value = model.extension_code;
            parameters[52].Value = model.extension_id;
            parameters[53].Value = model.to_buyer;
            parameters[54].Value = model.pay_note;
            parameters[55].Value = model.agency_id;
            parameters[56].Value = model.inv_type;
            parameters[57].Value = model.tax;
            parameters[58].Value = model.is_separate;
            parameters[59].Value = model.parent_id;
            parameters[60].Value = model.discount;
            parameters[61].Value = model.Id;

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
            strSql.Append("delete from ROYcms_Goods_Order ");
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
            strSql.Append("delete from ROYcms_Goods_Order ");
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
        public ROYcms.Sys.Model.ROYcms_Goods_Order GetModel(string OrderId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,order_sn,user_id,order_status,shipping_status,pay_status,consignee,country,province,city,district,address,zipcode,tel,mobile,email,best_time,sign_building,postscript,shipping_id,shipping_name,pay_id,pay_name,how_oos,how_surplus,pack_name,card_name,card_message,inv_payee,inv_content,goods_amount,shipping_fee,insure_fee,pay_fee,pack_fee,card_fee,money_paid,surplus,Integeregral,Integeregral_money,bonus,order_amount,from_ad,referer,add_time,confirm_time,pay_time,shipping_time,pack_id,card_id,bonus_id,invoice_no,extension_code,extension_id,to_buyer,pay_note,agency_id,inv_type,tax,is_separate,parent_id,discount from ROYcms_Goods_Order ");
            strSql.Append(" where order_sn=@OrderId");
            SqlParameter[] parameters = {
					new SqlParameter("@OrderId", SqlDbType.VarChar,50)
};
            parameters[0].Value = OrderId;

            ROYcms.Sys.Model.ROYcms_Goods_Order model = new ROYcms.Sys.Model.ROYcms_Goods_Order();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["Id"] != null && ds.Tables[0].Rows[0]["Id"].ToString() != "")
                {
                    model.Id = int.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["order_sn"] != null && ds.Tables[0].Rows[0]["order_sn"].ToString() != "")
                {
                    model.order_sn = ds.Tables[0].Rows[0]["order_sn"].ToString();
                }
                if (ds.Tables[0].Rows[0]["user_id"] != null && ds.Tables[0].Rows[0]["user_id"].ToString() != "")
                {
                    model.user_id = int.Parse(ds.Tables[0].Rows[0]["user_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["order_status"] != null && ds.Tables[0].Rows[0]["order_status"].ToString() != "")
                {
                    model.order_status = int.Parse(ds.Tables[0].Rows[0]["order_status"].ToString());
                }
                if (ds.Tables[0].Rows[0]["shipping_status"] != null && ds.Tables[0].Rows[0]["shipping_status"].ToString() != "")
                {
                    model.shipping_status = int.Parse(ds.Tables[0].Rows[0]["shipping_status"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pay_status"] != null && ds.Tables[0].Rows[0]["pay_status"].ToString() != "")
                {
                    model.pay_status = int.Parse(ds.Tables[0].Rows[0]["pay_status"].ToString());
                }
                if (ds.Tables[0].Rows[0]["consignee"] != null && ds.Tables[0].Rows[0]["consignee"].ToString() != "")
                {
                    model.consignee = ds.Tables[0].Rows[0]["consignee"].ToString();
                }
                if (ds.Tables[0].Rows[0]["country"] != null && ds.Tables[0].Rows[0]["country"].ToString() != "")
                {
                    model.country = ds.Tables[0].Rows[0]["country"].ToString();
                }
                if (ds.Tables[0].Rows[0]["province"] != null && ds.Tables[0].Rows[0]["province"].ToString() != "")
                {
                    model.province = ds.Tables[0].Rows[0]["province"].ToString();
                }
                if (ds.Tables[0].Rows[0]["city"] != null && ds.Tables[0].Rows[0]["city"].ToString() != "")
                {
                    model.city = ds.Tables[0].Rows[0]["city"].ToString();
                }
                if (ds.Tables[0].Rows[0]["district"] != null && ds.Tables[0].Rows[0]["district"].ToString() != "")
                {
                    model.district = ds.Tables[0].Rows[0]["district"].ToString();
                }
                if (ds.Tables[0].Rows[0]["address"] != null && ds.Tables[0].Rows[0]["address"].ToString() != "")
                {
                    model.address = ds.Tables[0].Rows[0]["address"].ToString();
                }
                if (ds.Tables[0].Rows[0]["zipcode"] != null && ds.Tables[0].Rows[0]["zipcode"].ToString() != "")
                {
                    model.zipcode = ds.Tables[0].Rows[0]["zipcode"].ToString();
                }
                if (ds.Tables[0].Rows[0]["tel"] != null && ds.Tables[0].Rows[0]["tel"].ToString() != "")
                {
                    model.tel = ds.Tables[0].Rows[0]["tel"].ToString();
                }
                if (ds.Tables[0].Rows[0]["mobile"] != null && ds.Tables[0].Rows[0]["mobile"].ToString() != "")
                {
                    model.mobile = ds.Tables[0].Rows[0]["mobile"].ToString();
                }
                if (ds.Tables[0].Rows[0]["email"] != null && ds.Tables[0].Rows[0]["email"].ToString() != "")
                {
                    model.email = ds.Tables[0].Rows[0]["email"].ToString();
                }
                if (ds.Tables[0].Rows[0]["best_time"] != null && ds.Tables[0].Rows[0]["best_time"].ToString() != "")
                {
                    model.best_time = int.Parse(ds.Tables[0].Rows[0]["best_time"].ToString());
                }
                if (ds.Tables[0].Rows[0]["sign_building"] != null && ds.Tables[0].Rows[0]["sign_building"].ToString() != "")
                {
                    model.sign_building = ds.Tables[0].Rows[0]["sign_building"].ToString();
                }
                if (ds.Tables[0].Rows[0]["postscript"] != null && ds.Tables[0].Rows[0]["postscript"].ToString() != "")
                {
                    model.postscript = ds.Tables[0].Rows[0]["postscript"].ToString();
                }
                if (ds.Tables[0].Rows[0]["shipping_id"] != null && ds.Tables[0].Rows[0]["shipping_id"].ToString() != "")
                {
                    model.shipping_id = int.Parse(ds.Tables[0].Rows[0]["shipping_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["shipping_name"] != null && ds.Tables[0].Rows[0]["shipping_name"].ToString() != "")
                {
                    model.shipping_name = ds.Tables[0].Rows[0]["shipping_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pay_id"] != null && ds.Tables[0].Rows[0]["pay_id"].ToString() != "")
                {
                    model.pay_id = int.Parse(ds.Tables[0].Rows[0]["pay_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pay_name"] != null && ds.Tables[0].Rows[0]["pay_name"].ToString() != "")
                {
                    model.pay_name = ds.Tables[0].Rows[0]["pay_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["how_oos"] != null && ds.Tables[0].Rows[0]["how_oos"].ToString() != "")
                {
                    model.how_oos = int.Parse(ds.Tables[0].Rows[0]["how_oos"].ToString());
                }
                if (ds.Tables[0].Rows[0]["how_surplus"] != null && ds.Tables[0].Rows[0]["how_surplus"].ToString() != "")
                {
                    model.how_surplus = int.Parse(ds.Tables[0].Rows[0]["how_surplus"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pack_name"] != null && ds.Tables[0].Rows[0]["pack_name"].ToString() != "")
                {
                    model.pack_name = ds.Tables[0].Rows[0]["pack_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["card_name"] != null && ds.Tables[0].Rows[0]["card_name"].ToString() != "")
                {
                    model.card_name = ds.Tables[0].Rows[0]["card_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["card_message"] != null && ds.Tables[0].Rows[0]["card_message"].ToString() != "")
                {
                    model.card_message = ds.Tables[0].Rows[0]["card_message"].ToString();
                }
                if (ds.Tables[0].Rows[0]["inv_payee"] != null && ds.Tables[0].Rows[0]["inv_payee"].ToString() != "")
                {
                    model.inv_payee = ds.Tables[0].Rows[0]["inv_payee"].ToString();
                }
                if (ds.Tables[0].Rows[0]["inv_content"] != null && ds.Tables[0].Rows[0]["inv_content"].ToString() != "")
                {
                    model.inv_content = ds.Tables[0].Rows[0]["inv_content"].ToString();
                }
                if (ds.Tables[0].Rows[0]["goods_amount"] != null && ds.Tables[0].Rows[0]["goods_amount"].ToString() != "")
                {
                    model.goods_amount = int.Parse(ds.Tables[0].Rows[0]["goods_amount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["shipping_fee"] != null && ds.Tables[0].Rows[0]["shipping_fee"].ToString() != "")
                {
                    model.shipping_fee = ds.Tables[0].Rows[0]["shipping_fee"].ToString();
                }
                if (ds.Tables[0].Rows[0]["insure_fee"] != null && ds.Tables[0].Rows[0]["insure_fee"].ToString() != "")
                {
                    model.insure_fee = int.Parse(ds.Tables[0].Rows[0]["insure_fee"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pay_fee"] != null && ds.Tables[0].Rows[0]["pay_fee"].ToString() != "")
                {
                    model.pay_fee = ds.Tables[0].Rows[0]["pay_fee"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pack_fee"] != null && ds.Tables[0].Rows[0]["pack_fee"].ToString() != "")
                {
                    model.pack_fee = ds.Tables[0].Rows[0]["pack_fee"].ToString();
                }
                if (ds.Tables[0].Rows[0]["card_fee"] != null && ds.Tables[0].Rows[0]["card_fee"].ToString() != "")
                {
                    model.card_fee = ds.Tables[0].Rows[0]["card_fee"].ToString();
                }
                if (ds.Tables[0].Rows[0]["money_paid"] != null && ds.Tables[0].Rows[0]["money_paid"].ToString() != "")
                {
                    model.money_paid = int.Parse(ds.Tables[0].Rows[0]["money_paid"].ToString());
                }
                if (ds.Tables[0].Rows[0]["surplus"] != null && ds.Tables[0].Rows[0]["surplus"].ToString() != "")
                {
                    model.surplus = ds.Tables[0].Rows[0]["surplus"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Integeregral"] != null && ds.Tables[0].Rows[0]["Integeregral"].ToString() != "")
                {
                    model.Integeregral = int.Parse(ds.Tables[0].Rows[0]["Integeregral"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Integeregral_money"] != null && ds.Tables[0].Rows[0]["Integeregral_money"].ToString() != "")
                {
                    model.Integeregral_money = int.Parse(ds.Tables[0].Rows[0]["Integeregral_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["bonus"] != null && ds.Tables[0].Rows[0]["bonus"].ToString() != "")
                {
                    model.bonus = int.Parse(ds.Tables[0].Rows[0]["bonus"].ToString());
                }
                if (ds.Tables[0].Rows[0]["order_amount"] != null && ds.Tables[0].Rows[0]["order_amount"].ToString() != "")
                {
                    model.order_amount = int.Parse(ds.Tables[0].Rows[0]["order_amount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["from_ad"] != null && ds.Tables[0].Rows[0]["from_ad"].ToString() != "")
                {
                    model.from_ad = int.Parse(ds.Tables[0].Rows[0]["from_ad"].ToString());
                }
                if (ds.Tables[0].Rows[0]["referer"] != null && ds.Tables[0].Rows[0]["referer"].ToString() != "")
                {
                    model.referer = ds.Tables[0].Rows[0]["referer"].ToString();
                }
                if (ds.Tables[0].Rows[0]["add_time"] != null && ds.Tables[0].Rows[0]["add_time"].ToString() != "")
                {
                    model.add_time = DateTime.Parse(ds.Tables[0].Rows[0]["add_time"].ToString());
                }
                if (ds.Tables[0].Rows[0]["confirm_time"] != null && ds.Tables[0].Rows[0]["confirm_time"].ToString() != "")
                {
                    model.confirm_time = DateTime.Parse(ds.Tables[0].Rows[0]["confirm_time"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pay_time"] != null && ds.Tables[0].Rows[0]["pay_time"].ToString() != "")
                {
                    model.pay_time = DateTime.Parse(ds.Tables[0].Rows[0]["pay_time"].ToString());
                }
                if (ds.Tables[0].Rows[0]["shipping_time"] != null && ds.Tables[0].Rows[0]["shipping_time"].ToString() != "")
                {
                    model.shipping_time = DateTime.Parse(ds.Tables[0].Rows[0]["shipping_time"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pack_id"] != null && ds.Tables[0].Rows[0]["pack_id"].ToString() != "")
                {
                    model.pack_id = int.Parse(ds.Tables[0].Rows[0]["pack_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["card_id"] != null && ds.Tables[0].Rows[0]["card_id"].ToString() != "")
                {
                    model.card_id = int.Parse(ds.Tables[0].Rows[0]["card_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["bonus_id"] != null && ds.Tables[0].Rows[0]["bonus_id"].ToString() != "")
                {
                    model.bonus_id = int.Parse(ds.Tables[0].Rows[0]["bonus_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["invoice_no"] != null && ds.Tables[0].Rows[0]["invoice_no"].ToString() != "")
                {
                    model.invoice_no = ds.Tables[0].Rows[0]["invoice_no"].ToString();
                }
                if (ds.Tables[0].Rows[0]["extension_code"] != null && ds.Tables[0].Rows[0]["extension_code"].ToString() != "")
                {
                    model.extension_code = int.Parse(ds.Tables[0].Rows[0]["extension_code"].ToString());
                }
                if (ds.Tables[0].Rows[0]["extension_id"] != null && ds.Tables[0].Rows[0]["extension_id"].ToString() != "")
                {
                    model.extension_id = int.Parse(ds.Tables[0].Rows[0]["extension_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["to_buyer"] != null && ds.Tables[0].Rows[0]["to_buyer"].ToString() != "")
                {
                    model.to_buyer = ds.Tables[0].Rows[0]["to_buyer"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pay_note"] != null && ds.Tables[0].Rows[0]["pay_note"].ToString() != "")
                {
                    model.pay_note = ds.Tables[0].Rows[0]["pay_note"].ToString();
                }
                if (ds.Tables[0].Rows[0]["agency_id"] != null && ds.Tables[0].Rows[0]["agency_id"].ToString() != "")
                {
                    model.agency_id = int.Parse(ds.Tables[0].Rows[0]["agency_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["inv_type"] != null && ds.Tables[0].Rows[0]["inv_type"].ToString() != "")
                {
                    model.inv_type = ds.Tables[0].Rows[0]["inv_type"].ToString();
                }
                if (ds.Tables[0].Rows[0]["tax"] != null && ds.Tables[0].Rows[0]["tax"].ToString() != "")
                {
                    model.tax = ds.Tables[0].Rows[0]["tax"].ToString();
                }
                if (ds.Tables[0].Rows[0]["is_separate"] != null && ds.Tables[0].Rows[0]["is_separate"].ToString() != "")
                {
                    model.is_separate = int.Parse(ds.Tables[0].Rows[0]["is_separate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["parent_id"] != null && ds.Tables[0].Rows[0]["parent_id"].ToString() != "")
                {
                    model.parent_id = int.Parse(ds.Tables[0].Rows[0]["parent_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["discount"] != null && ds.Tables[0].Rows[0]["discount"].ToString() != "")
                {
                    model.discount = ds.Tables[0].Rows[0]["discount"].ToString();
                }
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
        public ROYcms.Sys.Model.ROYcms_Goods_Order GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,order_sn,user_id,order_status,shipping_status,pay_status,consignee,country,province,city,district,address,zipcode,tel,mobile,email,best_time,sign_building,postscript,shipping_id,shipping_name,pay_id,pay_name,how_oos,how_surplus,pack_name,card_name,card_message,inv_payee,inv_content,goods_amount,shipping_fee,insure_fee,pay_fee,pack_fee,card_fee,money_paid,surplus,Integeregral,Integeregral_money,bonus,order_amount,from_ad,referer,add_time,confirm_time,pay_time,shipping_time,pack_id,card_id,bonus_id,invoice_no,extension_code,extension_id,to_buyer,pay_note,agency_id,inv_type,tax,is_separate,parent_id,discount from ROYcms_Goods_Order ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
};
            parameters[0].Value = Id;

            ROYcms.Sys.Model.ROYcms_Goods_Order model = new ROYcms.Sys.Model.ROYcms_Goods_Order();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["Id"] != null && ds.Tables[0].Rows[0]["Id"].ToString() != "")
                {
                    model.Id = int.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["order_sn"] != null && ds.Tables[0].Rows[0]["order_sn"].ToString() != "")
                {
                    model.order_sn = ds.Tables[0].Rows[0]["order_sn"].ToString();
                }
                if (ds.Tables[0].Rows[0]["user_id"] != null && ds.Tables[0].Rows[0]["user_id"].ToString() != "")
                {
                    model.user_id = int.Parse(ds.Tables[0].Rows[0]["user_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["order_status"] != null && ds.Tables[0].Rows[0]["order_status"].ToString() != "")
                {
                    model.order_status = int.Parse(ds.Tables[0].Rows[0]["order_status"].ToString());
                }
                if (ds.Tables[0].Rows[0]["shipping_status"] != null && ds.Tables[0].Rows[0]["shipping_status"].ToString() != "")
                {
                    model.shipping_status = int.Parse(ds.Tables[0].Rows[0]["shipping_status"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pay_status"] != null && ds.Tables[0].Rows[0]["pay_status"].ToString() != "")
                {
                    model.pay_status = int.Parse(ds.Tables[0].Rows[0]["pay_status"].ToString());
                }
                if (ds.Tables[0].Rows[0]["consignee"] != null && ds.Tables[0].Rows[0]["consignee"].ToString() != "")
                {
                    model.consignee = ds.Tables[0].Rows[0]["consignee"].ToString();
                }
                if (ds.Tables[0].Rows[0]["country"] != null && ds.Tables[0].Rows[0]["country"].ToString() != "")
                {
                    model.country = ds.Tables[0].Rows[0]["country"].ToString();
                }
                if (ds.Tables[0].Rows[0]["province"] != null && ds.Tables[0].Rows[0]["province"].ToString() != "")
                {
                    model.province = ds.Tables[0].Rows[0]["province"].ToString();
                }
                if (ds.Tables[0].Rows[0]["city"] != null && ds.Tables[0].Rows[0]["city"].ToString() != "")
                {
                    model.city = ds.Tables[0].Rows[0]["city"].ToString();
                }
                if (ds.Tables[0].Rows[0]["district"] != null && ds.Tables[0].Rows[0]["district"].ToString() != "")
                {
                    model.district = ds.Tables[0].Rows[0]["district"].ToString();
                }
                if (ds.Tables[0].Rows[0]["address"] != null && ds.Tables[0].Rows[0]["address"].ToString() != "")
                {
                    model.address = ds.Tables[0].Rows[0]["address"].ToString();
                }
                if (ds.Tables[0].Rows[0]["zipcode"] != null && ds.Tables[0].Rows[0]["zipcode"].ToString() != "")
                {
                    model.zipcode = ds.Tables[0].Rows[0]["zipcode"].ToString();
                }
                if (ds.Tables[0].Rows[0]["tel"] != null && ds.Tables[0].Rows[0]["tel"].ToString() != "")
                {
                    model.tel = ds.Tables[0].Rows[0]["tel"].ToString();
                }
                if (ds.Tables[0].Rows[0]["mobile"] != null && ds.Tables[0].Rows[0]["mobile"].ToString() != "")
                {
                    model.mobile = ds.Tables[0].Rows[0]["mobile"].ToString();
                }
                if (ds.Tables[0].Rows[0]["email"] != null && ds.Tables[0].Rows[0]["email"].ToString() != "")
                {
                    model.email = ds.Tables[0].Rows[0]["email"].ToString();
                }
                if (ds.Tables[0].Rows[0]["best_time"] != null && ds.Tables[0].Rows[0]["best_time"].ToString() != "")
                {
                    model.best_time = int.Parse(ds.Tables[0].Rows[0]["best_time"].ToString());
                }
                if (ds.Tables[0].Rows[0]["sign_building"] != null && ds.Tables[0].Rows[0]["sign_building"].ToString() != "")
                {
                    model.sign_building = ds.Tables[0].Rows[0]["sign_building"].ToString();
                }
                if (ds.Tables[0].Rows[0]["postscript"] != null && ds.Tables[0].Rows[0]["postscript"].ToString() != "")
                {
                    model.postscript = ds.Tables[0].Rows[0]["postscript"].ToString();
                }
                if (ds.Tables[0].Rows[0]["shipping_id"] != null && ds.Tables[0].Rows[0]["shipping_id"].ToString() != "")
                {
                    model.shipping_id = int.Parse(ds.Tables[0].Rows[0]["shipping_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["shipping_name"] != null && ds.Tables[0].Rows[0]["shipping_name"].ToString() != "")
                {
                    model.shipping_name = ds.Tables[0].Rows[0]["shipping_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pay_id"] != null && ds.Tables[0].Rows[0]["pay_id"].ToString() != "")
                {
                    model.pay_id = int.Parse(ds.Tables[0].Rows[0]["pay_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pay_name"] != null && ds.Tables[0].Rows[0]["pay_name"].ToString() != "")
                {
                    model.pay_name = ds.Tables[0].Rows[0]["pay_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["how_oos"] != null && ds.Tables[0].Rows[0]["how_oos"].ToString() != "")
                {
                    model.how_oos = int.Parse(ds.Tables[0].Rows[0]["how_oos"].ToString());
                }
                if (ds.Tables[0].Rows[0]["how_surplus"] != null && ds.Tables[0].Rows[0]["how_surplus"].ToString() != "")
                {
                    model.how_surplus = int.Parse(ds.Tables[0].Rows[0]["how_surplus"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pack_name"] != null && ds.Tables[0].Rows[0]["pack_name"].ToString() != "")
                {
                    model.pack_name = ds.Tables[0].Rows[0]["pack_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["card_name"] != null && ds.Tables[0].Rows[0]["card_name"].ToString() != "")
                {
                    model.card_name = ds.Tables[0].Rows[0]["card_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["card_message"] != null && ds.Tables[0].Rows[0]["card_message"].ToString() != "")
                {
                    model.card_message = ds.Tables[0].Rows[0]["card_message"].ToString();
                }
                if (ds.Tables[0].Rows[0]["inv_payee"] != null && ds.Tables[0].Rows[0]["inv_payee"].ToString() != "")
                {
                    model.inv_payee = ds.Tables[0].Rows[0]["inv_payee"].ToString();
                }
                if (ds.Tables[0].Rows[0]["inv_content"] != null && ds.Tables[0].Rows[0]["inv_content"].ToString() != "")
                {
                    model.inv_content = ds.Tables[0].Rows[0]["inv_content"].ToString();
                }
                if (ds.Tables[0].Rows[0]["goods_amount"] != null && ds.Tables[0].Rows[0]["goods_amount"].ToString() != "")
                {
                    model.goods_amount = int.Parse(ds.Tables[0].Rows[0]["goods_amount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["shipping_fee"] != null && ds.Tables[0].Rows[0]["shipping_fee"].ToString() != "")
                {
                    model.shipping_fee = ds.Tables[0].Rows[0]["shipping_fee"].ToString();
                }
                if (ds.Tables[0].Rows[0]["insure_fee"] != null && ds.Tables[0].Rows[0]["insure_fee"].ToString() != "")
                {
                    model.insure_fee = int.Parse(ds.Tables[0].Rows[0]["insure_fee"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pay_fee"] != null && ds.Tables[0].Rows[0]["pay_fee"].ToString() != "")
                {
                    model.pay_fee = ds.Tables[0].Rows[0]["pay_fee"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pack_fee"] != null && ds.Tables[0].Rows[0]["pack_fee"].ToString() != "")
                {
                    model.pack_fee = ds.Tables[0].Rows[0]["pack_fee"].ToString();
                }
                if (ds.Tables[0].Rows[0]["card_fee"] != null && ds.Tables[0].Rows[0]["card_fee"].ToString() != "")
                {
                    model.card_fee = ds.Tables[0].Rows[0]["card_fee"].ToString();
                }
                if (ds.Tables[0].Rows[0]["money_paid"] != null && ds.Tables[0].Rows[0]["money_paid"].ToString() != "")
                {
                    model.money_paid = int.Parse(ds.Tables[0].Rows[0]["money_paid"].ToString());
                }
                if (ds.Tables[0].Rows[0]["surplus"] != null && ds.Tables[0].Rows[0]["surplus"].ToString() != "")
                {
                    model.surplus = ds.Tables[0].Rows[0]["surplus"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Integeregral"] != null && ds.Tables[0].Rows[0]["Integeregral"].ToString() != "")
                {
                    model.Integeregral = int.Parse(ds.Tables[0].Rows[0]["Integeregral"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Integeregral_money"] != null && ds.Tables[0].Rows[0]["Integeregral_money"].ToString() != "")
                {
                    model.Integeregral_money = int.Parse(ds.Tables[0].Rows[0]["Integeregral_money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["bonus"] != null && ds.Tables[0].Rows[0]["bonus"].ToString() != "")
                {
                    model.bonus = int.Parse(ds.Tables[0].Rows[0]["bonus"].ToString());
                }
                if (ds.Tables[0].Rows[0]["order_amount"] != null && ds.Tables[0].Rows[0]["order_amount"].ToString() != "")
                {
                    model.order_amount = int.Parse(ds.Tables[0].Rows[0]["order_amount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["from_ad"] != null && ds.Tables[0].Rows[0]["from_ad"].ToString() != "")
                {
                    model.from_ad = int.Parse(ds.Tables[0].Rows[0]["from_ad"].ToString());
                }
                if (ds.Tables[0].Rows[0]["referer"] != null && ds.Tables[0].Rows[0]["referer"].ToString() != "")
                {
                    model.referer = ds.Tables[0].Rows[0]["referer"].ToString();
                }
                if (ds.Tables[0].Rows[0]["add_time"] != null && ds.Tables[0].Rows[0]["add_time"].ToString() != "")
                {
                    model.add_time = DateTime.Parse(ds.Tables[0].Rows[0]["add_time"].ToString());
                }
                if (ds.Tables[0].Rows[0]["confirm_time"] != null && ds.Tables[0].Rows[0]["confirm_time"].ToString() != "")
                {
                    model.confirm_time = DateTime.Parse(ds.Tables[0].Rows[0]["confirm_time"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pay_time"] != null && ds.Tables[0].Rows[0]["pay_time"].ToString() != "")
                {
                    model.pay_time = DateTime.Parse(ds.Tables[0].Rows[0]["pay_time"].ToString());
                }
                if (ds.Tables[0].Rows[0]["shipping_time"] != null && ds.Tables[0].Rows[0]["shipping_time"].ToString() != "")
                {
                    model.shipping_time = DateTime.Parse(ds.Tables[0].Rows[0]["shipping_time"].ToString());
                }
                if (ds.Tables[0].Rows[0]["pack_id"] != null && ds.Tables[0].Rows[0]["pack_id"].ToString() != "")
                {
                    model.pack_id = int.Parse(ds.Tables[0].Rows[0]["pack_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["card_id"] != null && ds.Tables[0].Rows[0]["card_id"].ToString() != "")
                {
                    model.card_id = int.Parse(ds.Tables[0].Rows[0]["card_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["bonus_id"] != null && ds.Tables[0].Rows[0]["bonus_id"].ToString() != "")
                {
                    model.bonus_id = int.Parse(ds.Tables[0].Rows[0]["bonus_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["invoice_no"] != null && ds.Tables[0].Rows[0]["invoice_no"].ToString() != "")
                {
                    model.invoice_no = ds.Tables[0].Rows[0]["invoice_no"].ToString();
                }
                if (ds.Tables[0].Rows[0]["extension_code"] != null && ds.Tables[0].Rows[0]["extension_code"].ToString() != "")
                {
                    model.extension_code = int.Parse(ds.Tables[0].Rows[0]["extension_code"].ToString());
                }
                if (ds.Tables[0].Rows[0]["extension_id"] != null && ds.Tables[0].Rows[0]["extension_id"].ToString() != "")
                {
                    model.extension_id = int.Parse(ds.Tables[0].Rows[0]["extension_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["to_buyer"] != null && ds.Tables[0].Rows[0]["to_buyer"].ToString() != "")
                {
                    model.to_buyer = ds.Tables[0].Rows[0]["to_buyer"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pay_note"] != null && ds.Tables[0].Rows[0]["pay_note"].ToString() != "")
                {
                    model.pay_note = ds.Tables[0].Rows[0]["pay_note"].ToString();
                }
                if (ds.Tables[0].Rows[0]["agency_id"] != null && ds.Tables[0].Rows[0]["agency_id"].ToString() != "")
                {
                    model.agency_id = int.Parse(ds.Tables[0].Rows[0]["agency_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["inv_type"] != null && ds.Tables[0].Rows[0]["inv_type"].ToString() != "")
                {
                    model.inv_type = ds.Tables[0].Rows[0]["inv_type"].ToString();
                }
                if (ds.Tables[0].Rows[0]["tax"] != null && ds.Tables[0].Rows[0]["tax"].ToString() != "")
                {
                    model.tax = ds.Tables[0].Rows[0]["tax"].ToString();
                }
                if (ds.Tables[0].Rows[0]["is_separate"] != null && ds.Tables[0].Rows[0]["is_separate"].ToString() != "")
                {
                    model.is_separate = int.Parse(ds.Tables[0].Rows[0]["is_separate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["parent_id"] != null && ds.Tables[0].Rows[0]["parent_id"].ToString() != "")
                {
                    model.parent_id = int.Parse(ds.Tables[0].Rows[0]["parent_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["discount"] != null && ds.Tables[0].Rows[0]["discount"].ToString() != "")
                {
                    model.discount = ds.Tables[0].Rows[0]["discount"].ToString();
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
            strSql.Append("select Id,order_sn,user_id,order_status,shipping_status,pay_status,consignee,country,province,city,district,address,zipcode,tel,mobile,email,best_time,sign_building,postscript,shipping_id,shipping_name,pay_id,pay_name,how_oos,how_surplus,pack_name,card_name,card_message,inv_payee,inv_content,goods_amount,shipping_fee,insure_fee,pay_fee,pack_fee,card_fee,money_paid,surplus,Integeregral,Integeregral_money,bonus,order_amount,from_ad,referer,add_time,confirm_time,pay_time,shipping_time,pack_id,card_id,bonus_id,invoice_no,extension_code,extension_id,to_buyer,pay_note,agency_id,inv_type,tax,is_separate,parent_id,discount ");
            strSql.Append(" FROM ROYcms_Goods_Order ");
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
            strSql.Append(" Id,order_sn,user_id,order_status,shipping_status,pay_status,consignee,country,province,city,district,address,zipcode,tel,mobile,email,best_time,sign_building,postscript,shipping_id,shipping_name,pay_id,pay_name,how_oos,how_surplus,pack_name,card_name,card_message,inv_payee,inv_content,goods_amount,shipping_fee,insure_fee,pay_fee,pack_fee,card_fee,money_paid,surplus,Integeregral,Integeregral_money,bonus,order_amount,from_ad,referer,add_time,confirm_time,pay_time,shipping_time,pack_id,card_id,bonus_id,invoice_no,extension_code,extension_id,to_buyer,pay_note,agency_id,inv_type,tax,is_separate,parent_id,discount ");
            strSql.Append(" FROM ROYcms_Goods_Order ");
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
            strSql.Append("select count(1) FROM ROYcms_Goods_Order ");
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
            strSql.Append(")AS Row, T.*  from ROYcms_Goods_Order T ");
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
            parameters[0].Value = "ROYcms_Goods_Order";
            parameters[1].Value = "Id";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 1;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }

        #endregion  Method
    }
}

