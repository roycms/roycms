using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ROYcms.DB;
namespace ROYcms.Sys.DAL
{
	/// <summary>
	/// 数据访问类:ROYcms_Goods
	/// </summary>
	public partial class ROYcms_Goods
	{
		public ROYcms_Goods()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "ROYcms_Goods"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ROYcms_Goods");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
};
			parameters[0].Value = Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(ROYcms.Sys.Model.ROYcms_Goods model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ROYcms_Goods(");
            strSql.Append("goods_type,goods_sn,goods_name,goods_name_style,click_count,brand_id,provider_name,goods_number,goods_weight,market_price,shop_price,promote_price,promote_start_date,promote_end_date,warn_number,keywords,goods_brief,goods_desc,goods_thumb,goods_img,original_img,is_real,extension_code,is_on_sale,is_alone_sale,integral,add_time,is_delete,is_best,is_hot,is_promote,last_update,give_integral,ClassKind)");
			strSql.Append(" values (");
            strSql.Append("@goods_type,@goods_sn,@goods_name,@goods_name_style,@click_count,@brand_id,@provider_name,@goods_number,@goods_weight,@market_price,@shop_price,@promote_price,@promote_start_date,@promote_end_date,@warn_number,@keywords,@goods_brief,@goods_desc,@goods_thumb,@goods_img,@original_img,@is_real,@extension_code,@is_on_sale,@is_alone_sale,@integral,@add_time,@is_delete,@is_best,@is_hot,@is_promote,@last_update,@give_integral,@ClassKind)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@goods_type", SqlDbType.Int,4),
					new SqlParameter("@goods_sn", SqlDbType.VarChar,100),
					new SqlParameter("@goods_name", SqlDbType.VarChar,500),
					new SqlParameter("@goods_name_style", SqlDbType.VarChar,100),
					new SqlParameter("@click_count", SqlDbType.Int,4),
					new SqlParameter("@brand_id", SqlDbType.Int,4),
					new SqlParameter("@provider_name", SqlDbType.VarChar,100),
					new SqlParameter("@goods_number", SqlDbType.Int,4),
					new SqlParameter("@goods_weight", SqlDbType.Int,4),
					new SqlParameter("@market_price", SqlDbType.Int,4),
					new SqlParameter("@shop_price", SqlDbType.Int,4),
					new SqlParameter("@promote_price", SqlDbType.Int,4),
					new SqlParameter("@promote_start_date", SqlDbType.DateTime),
					new SqlParameter("@promote_end_date", SqlDbType.DateTime),
					new SqlParameter("@warn_number", SqlDbType.Int,4),
					new SqlParameter("@keywords", SqlDbType.VarChar,500),
					new SqlParameter("@goods_brief", SqlDbType.VarChar,500),
					new SqlParameter("@goods_desc", SqlDbType.Text),
					new SqlParameter("@goods_thumb", SqlDbType.VarChar,500),
					new SqlParameter("@goods_img", SqlDbType.VarChar,500),
					new SqlParameter("@original_img", SqlDbType.VarChar,500),
					new SqlParameter("@is_real", SqlDbType.Int,4),
					new SqlParameter("@extension_code", SqlDbType.VarChar,100),
					new SqlParameter("@is_on_sale", SqlDbType.Int,4),
					new SqlParameter("@is_alone_sale", SqlDbType.Int,4),
					new SqlParameter("@integral", SqlDbType.Int,4),
					new SqlParameter("@add_time", SqlDbType.DateTime),
					new SqlParameter("@is_delete", SqlDbType.Int,4),
					new SqlParameter("@is_best", SqlDbType.Int,4),
					new SqlParameter("@is_hot", SqlDbType.Int,4),
					new SqlParameter("@is_promote", SqlDbType.Int,4),
					new SqlParameter("@last_update", SqlDbType.DateTime),
                    new SqlParameter("@give_integral", SqlDbType.Int,4),
					new SqlParameter("@ClassKind", SqlDbType.Int,4)};
			parameters[0].Value = model.goods_type;
			parameters[1].Value = model.goods_sn;
			parameters[2].Value = model.goods_name;
			parameters[3].Value = model.goods_name_style;
			parameters[4].Value = model.click_count;
			parameters[5].Value = model.brand_id;
			parameters[6].Value = model.provider_name;
			parameters[7].Value = model.goods_number;
			parameters[8].Value = model.goods_weight;
			parameters[9].Value = model.market_price;
			parameters[10].Value = model.shop_price;
			parameters[11].Value = model.promote_price;
			parameters[12].Value = model.promote_start_date;
			parameters[13].Value = model.promote_end_date;
			parameters[14].Value = model.warn_number;
			parameters[15].Value = model.keywords;
			parameters[16].Value = model.goods_brief;
			parameters[17].Value = model.goods_desc;
			parameters[18].Value = model.goods_thumb;
			parameters[19].Value = model.goods_img;
			parameters[20].Value = model.original_img;
			parameters[21].Value = model.is_real;
			parameters[22].Value = model.extension_code;
			parameters[23].Value = model.is_on_sale;
			parameters[24].Value = model.is_alone_sale;
			parameters[25].Value = model.integral;
			parameters[26].Value = model.add_time;
			parameters[27].Value = model.is_delete;
			parameters[28].Value = model.is_best;
			parameters[29].Value = model.is_hot;
			parameters[30].Value = model.is_promote;
			parameters[31].Value = model.last_update;
			parameters[32].Value = model.give_integral;
            parameters[33].Value = model.classkind;
            
			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		public bool Update(ROYcms.Sys.Model.ROYcms_Goods model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ROYcms_Goods set ");
			strSql.Append("goods_type=@goods_type,");
			strSql.Append("goods_sn=@goods_sn,");
			strSql.Append("goods_name=@goods_name,");
			strSql.Append("goods_name_style=@goods_name_style,");
			strSql.Append("click_count=@click_count,");
			strSql.Append("brand_id=@brand_id,");
			strSql.Append("provider_name=@provider_name,");
			strSql.Append("goods_number=@goods_number,");
			strSql.Append("goods_weight=@goods_weight,");
			strSql.Append("market_price=@market_price,");
			strSql.Append("shop_price=@shop_price,");
			strSql.Append("promote_price=@promote_price,");
			strSql.Append("promote_start_date=@promote_start_date,");
			strSql.Append("promote_end_date=@promote_end_date,");
			strSql.Append("warn_number=@warn_number,");
			strSql.Append("keywords=@keywords,");
			strSql.Append("goods_brief=@goods_brief,");
			strSql.Append("goods_desc=@goods_desc,");
			strSql.Append("goods_thumb=@goods_thumb,");
			strSql.Append("goods_img=@goods_img,");
			strSql.Append("original_img=@original_img,");
			strSql.Append("is_real=@is_real,");
			strSql.Append("extension_code=@extension_code,");
			strSql.Append("is_on_sale=@is_on_sale,");
			strSql.Append("is_alone_sale=@is_alone_sale,");
			strSql.Append("integral=@integral,");
			strSql.Append("add_time=@add_time,");
			strSql.Append("is_delete=@is_delete,");
			strSql.Append("is_best=@is_best,");
			strSql.Append("is_hot=@is_hot,");
			strSql.Append("is_promote=@is_promote,");
			strSql.Append("last_update=@last_update,");
            strSql.Append("ClassKind=@ClassKind,");
			strSql.Append("give_integral=@give_integral");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@goods_type", SqlDbType.Int,4),
					new SqlParameter("@goods_sn", SqlDbType.VarChar,100),
					new SqlParameter("@goods_name", SqlDbType.VarChar,500),
					new SqlParameter("@goods_name_style", SqlDbType.VarChar,100),
					new SqlParameter("@click_count", SqlDbType.Int,4),
					new SqlParameter("@brand_id", SqlDbType.Int,4),
					new SqlParameter("@provider_name", SqlDbType.VarChar,100),
					new SqlParameter("@goods_number", SqlDbType.Int,4),
					new SqlParameter("@goods_weight", SqlDbType.Int,4),
					new SqlParameter("@market_price", SqlDbType.Int,4),
					new SqlParameter("@shop_price", SqlDbType.Int,4),
					new SqlParameter("@promote_price", SqlDbType.Int,4),
					new SqlParameter("@promote_start_date", SqlDbType.DateTime),
					new SqlParameter("@promote_end_date", SqlDbType.DateTime),
					new SqlParameter("@warn_number", SqlDbType.Int,4),
					new SqlParameter("@keywords", SqlDbType.VarChar,500),
					new SqlParameter("@goods_brief", SqlDbType.VarChar,500),
					new SqlParameter("@goods_desc", SqlDbType.Text),
					new SqlParameter("@goods_thumb", SqlDbType.VarChar,500),
					new SqlParameter("@goods_img", SqlDbType.VarChar,500),
					new SqlParameter("@original_img", SqlDbType.VarChar,500),
					new SqlParameter("@is_real", SqlDbType.Int,4),
					new SqlParameter("@extension_code", SqlDbType.VarChar,100),
					new SqlParameter("@is_on_sale", SqlDbType.Int,4),
					new SqlParameter("@is_alone_sale", SqlDbType.Int,4),
					new SqlParameter("@integral", SqlDbType.Int,4),
					new SqlParameter("@add_time", SqlDbType.DateTime),
					new SqlParameter("@is_delete", SqlDbType.Int,4),
					new SqlParameter("@is_best", SqlDbType.Int,4),
					new SqlParameter("@is_hot", SqlDbType.Int,4),
					new SqlParameter("@is_promote", SqlDbType.Int,4),
					new SqlParameter("@last_update", SqlDbType.DateTime),
                    new SqlParameter("@ClassKind", SqlDbType.Int,4),
					new SqlParameter("@give_integral", SqlDbType.Int,4),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.goods_type;
			parameters[1].Value = model.goods_sn;
			parameters[2].Value = model.goods_name;
			parameters[3].Value = model.goods_name_style;
			parameters[4].Value = model.click_count;
			parameters[5].Value = model.brand_id;
			parameters[6].Value = model.provider_name;
			parameters[7].Value = model.goods_number;
			parameters[8].Value = model.goods_weight;
			parameters[9].Value = model.market_price;
			parameters[10].Value = model.shop_price;
			parameters[11].Value = model.promote_price;
			parameters[12].Value = model.promote_start_date;
			parameters[13].Value = model.promote_end_date;
			parameters[14].Value = model.warn_number;
			parameters[15].Value = model.keywords;
			parameters[16].Value = model.goods_brief;
			parameters[17].Value = model.goods_desc;
			parameters[18].Value = model.goods_thumb;
			parameters[19].Value = model.goods_img;
			parameters[20].Value = model.original_img;
			parameters[21].Value = model.is_real;
			parameters[22].Value = model.extension_code;
			parameters[23].Value = model.is_on_sale;
			parameters[24].Value = model.is_alone_sale;
			parameters[25].Value = model.integral;
			parameters[26].Value = model.add_time;
			parameters[27].Value = model.is_delete;
			parameters[28].Value = model.is_best;
			parameters[29].Value = model.is_hot;
			parameters[30].Value = model.is_promote;
			parameters[31].Value = model.last_update;
            parameters[32].Value = model.classkind;
			parameters[33].Value = model.give_integral;
			parameters[34].Value = model.Id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ROYcms_Goods ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
};
			parameters[0].Value = Id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ROYcms_Goods ");
			strSql.Append(" where Id in ("+Idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public ROYcms.Sys.Model.ROYcms_Goods GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select  top 1 Id,goods_type,goods_sn,goods_name,goods_name_style,click_count,brand_id,provider_name,goods_number,goods_weight,market_price,shop_price,promote_price,promote_start_date,promote_end_date,warn_number,keywords,goods_brief,goods_desc,goods_thumb,goods_img,original_img,is_real,extension_code,is_on_sale,is_alone_sale,integral,add_time,is_delete,is_best,is_hot,is_promote,last_update,give_integral,ClassKind from ROYcms_Goods ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
};
			parameters[0].Value = Id;

			ROYcms.Sys.Model.ROYcms_Goods model=new ROYcms.Sys.Model.ROYcms_Goods();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["Id"]!=null && ds.Tables[0].Rows[0]["Id"].ToString()!="")
				{
					model.Id=int.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["goods_type"]!=null && ds.Tables[0].Rows[0]["goods_type"].ToString()!="")
				{
					model.goods_type=int.Parse(ds.Tables[0].Rows[0]["goods_type"].ToString());
				}
				if(ds.Tables[0].Rows[0]["goods_sn"]!=null && ds.Tables[0].Rows[0]["goods_sn"].ToString()!="")
				{
					model.goods_sn=ds.Tables[0].Rows[0]["goods_sn"].ToString();
				}
				if(ds.Tables[0].Rows[0]["goods_name"]!=null && ds.Tables[0].Rows[0]["goods_name"].ToString()!="")
				{
					model.goods_name=ds.Tables[0].Rows[0]["goods_name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["goods_name_style"]!=null && ds.Tables[0].Rows[0]["goods_name_style"].ToString()!="")
				{
					model.goods_name_style=ds.Tables[0].Rows[0]["goods_name_style"].ToString();
				}
				if(ds.Tables[0].Rows[0]["click_count"]!=null && ds.Tables[0].Rows[0]["click_count"].ToString()!="")
				{
					model.click_count=int.Parse(ds.Tables[0].Rows[0]["click_count"].ToString());
				}
				if(ds.Tables[0].Rows[0]["brand_id"]!=null && ds.Tables[0].Rows[0]["brand_id"].ToString()!="")
				{
					model.brand_id=int.Parse(ds.Tables[0].Rows[0]["brand_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["provider_name"]!=null && ds.Tables[0].Rows[0]["provider_name"].ToString()!="")
				{
					model.provider_name=ds.Tables[0].Rows[0]["provider_name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["goods_number"]!=null && ds.Tables[0].Rows[0]["goods_number"].ToString()!="")
				{
					model.goods_number=int.Parse(ds.Tables[0].Rows[0]["goods_number"].ToString());
				}
				if(ds.Tables[0].Rows[0]["goods_weight"]!=null && ds.Tables[0].Rows[0]["goods_weight"].ToString()!="")
				{
					model.goods_weight=int.Parse(ds.Tables[0].Rows[0]["goods_weight"].ToString());
				}
				if(ds.Tables[0].Rows[0]["market_price"]!=null && ds.Tables[0].Rows[0]["market_price"].ToString()!="")
				{
					model.market_price=int.Parse(ds.Tables[0].Rows[0]["market_price"].ToString());
				}
				if(ds.Tables[0].Rows[0]["shop_price"]!=null && ds.Tables[0].Rows[0]["shop_price"].ToString()!="")
				{
					model.shop_price=int.Parse(ds.Tables[0].Rows[0]["shop_price"].ToString());
				}
				if(ds.Tables[0].Rows[0]["promote_price"]!=null && ds.Tables[0].Rows[0]["promote_price"].ToString()!="")
				{
					model.promote_price=int.Parse(ds.Tables[0].Rows[0]["promote_price"].ToString());
				}
				if(ds.Tables[0].Rows[0]["promote_start_date"]!=null && ds.Tables[0].Rows[0]["promote_start_date"].ToString()!="")
				{
					model.promote_start_date=DateTime.Parse(ds.Tables[0].Rows[0]["promote_start_date"].ToString());
				}
				if(ds.Tables[0].Rows[0]["promote_end_date"]!=null && ds.Tables[0].Rows[0]["promote_end_date"].ToString()!="")
				{
					model.promote_end_date=DateTime.Parse(ds.Tables[0].Rows[0]["promote_end_date"].ToString());
				}
				if(ds.Tables[0].Rows[0]["warn_number"]!=null && ds.Tables[0].Rows[0]["warn_number"].ToString()!="")
				{
					model.warn_number=int.Parse(ds.Tables[0].Rows[0]["warn_number"].ToString());
				}
				if(ds.Tables[0].Rows[0]["keywords"]!=null && ds.Tables[0].Rows[0]["keywords"].ToString()!="")
				{
					model.keywords=ds.Tables[0].Rows[0]["keywords"].ToString();
				}
				if(ds.Tables[0].Rows[0]["goods_brief"]!=null && ds.Tables[0].Rows[0]["goods_brief"].ToString()!="")
				{
					model.goods_brief=ds.Tables[0].Rows[0]["goods_brief"].ToString();
				}
				if(ds.Tables[0].Rows[0]["goods_desc"]!=null && ds.Tables[0].Rows[0]["goods_desc"].ToString()!="")
				{
					model.goods_desc=ds.Tables[0].Rows[0]["goods_desc"].ToString();
				}
				if(ds.Tables[0].Rows[0]["goods_thumb"]!=null && ds.Tables[0].Rows[0]["goods_thumb"].ToString()!="")
				{
					model.goods_thumb=ds.Tables[0].Rows[0]["goods_thumb"].ToString();
				}
				if(ds.Tables[0].Rows[0]["goods_img"]!=null && ds.Tables[0].Rows[0]["goods_img"].ToString()!="")
				{
					model.goods_img=ds.Tables[0].Rows[0]["goods_img"].ToString();
				}
				if(ds.Tables[0].Rows[0]["original_img"]!=null && ds.Tables[0].Rows[0]["original_img"].ToString()!="")
				{
					model.original_img=ds.Tables[0].Rows[0]["original_img"].ToString();
				}
				if(ds.Tables[0].Rows[0]["is_real"]!=null && ds.Tables[0].Rows[0]["is_real"].ToString()!="")
				{
					model.is_real=int.Parse(ds.Tables[0].Rows[0]["is_real"].ToString());
				}
				if(ds.Tables[0].Rows[0]["extension_code"]!=null && ds.Tables[0].Rows[0]["extension_code"].ToString()!="")
				{
					model.extension_code=ds.Tables[0].Rows[0]["extension_code"].ToString();
				}
				if(ds.Tables[0].Rows[0]["is_on_sale"]!=null && ds.Tables[0].Rows[0]["is_on_sale"].ToString()!="")
				{
					model.is_on_sale=int.Parse(ds.Tables[0].Rows[0]["is_on_sale"].ToString());
				}
				if(ds.Tables[0].Rows[0]["is_alone_sale"]!=null && ds.Tables[0].Rows[0]["is_alone_sale"].ToString()!="")
				{
					model.is_alone_sale=int.Parse(ds.Tables[0].Rows[0]["is_alone_sale"].ToString());
				}
				if(ds.Tables[0].Rows[0]["integral"]!=null && ds.Tables[0].Rows[0]["integral"].ToString()!="")
				{
					model.integral=int.Parse(ds.Tables[0].Rows[0]["integral"].ToString());
				}
				if(ds.Tables[0].Rows[0]["add_time"]!=null && ds.Tables[0].Rows[0]["add_time"].ToString()!="")
				{
					model.add_time=DateTime.Parse(ds.Tables[0].Rows[0]["add_time"].ToString());
				}
				if(ds.Tables[0].Rows[0]["is_delete"]!=null && ds.Tables[0].Rows[0]["is_delete"].ToString()!="")
				{
					model.is_delete=int.Parse(ds.Tables[0].Rows[0]["is_delete"].ToString());
				}
				if(ds.Tables[0].Rows[0]["is_best"]!=null && ds.Tables[0].Rows[0]["is_best"].ToString()!="")
				{
					model.is_best=int.Parse(ds.Tables[0].Rows[0]["is_best"].ToString());
				}
				if(ds.Tables[0].Rows[0]["is_hot"]!=null && ds.Tables[0].Rows[0]["is_hot"].ToString()!="")
				{
					model.is_hot=int.Parse(ds.Tables[0].Rows[0]["is_hot"].ToString());
				}
				if(ds.Tables[0].Rows[0]["is_promote"]!=null && ds.Tables[0].Rows[0]["is_promote"].ToString()!="")
				{
					model.is_promote=int.Parse(ds.Tables[0].Rows[0]["is_promote"].ToString());
				}
				if(ds.Tables[0].Rows[0]["last_update"]!=null && ds.Tables[0].Rows[0]["last_update"].ToString()!="")
				{
					model.last_update=DateTime.Parse(ds.Tables[0].Rows[0]["last_update"].ToString());
				}
				if(ds.Tables[0].Rows[0]["give_integral"]!=null && ds.Tables[0].Rows[0]["give_integral"].ToString()!="")
				{
					model.give_integral=int.Parse(ds.Tables[0].Rows[0]["give_integral"].ToString());
				}
                if (ds.Tables[0].Rows[0]["ClassKind"] != null && ds.Tables[0].Rows[0]["ClassKind"].ToString() != "")
                {
                    model.classkind = int.Parse(ds.Tables[0].Rows[0]["ClassKind"].ToString());
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
            strSql.Append("select Id,goods_type,goods_sn,goods_name,goods_name_style,click_count,brand_id,provider_name,goods_number,goods_weight,market_price,shop_price,promote_price,promote_start_date,promote_end_date,warn_number,keywords,goods_brief,goods_desc,goods_thumb,goods_img,original_img,is_real,extension_code,is_on_sale,is_alone_sale,integral,add_time,is_delete,is_best,is_hot,is_promote,last_update,give_integral,ClassKind ");
			strSql.Append(" FROM ROYcms_Goods ");
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
            strSql.Append(" Id,goods_type,goods_sn,goods_name,goods_name_style,click_count,brand_id,provider_name,goods_number,goods_weight,market_price,shop_price,promote_price,promote_start_date,promote_end_date,warn_number,keywords,goods_brief,goods_desc,goods_thumb,goods_img,original_img,is_real,extension_code,is_on_sale,is_alone_sale,integral,add_time,is_delete,is_best,is_hot,is_promote,last_update,give_integral,ClassKind ");
			strSql.Append(" FROM ROYcms_Goods ");
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM ROYcms_Goods ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.Id desc");
			}
			strSql.Append(")AS Row, T.*  from ROYcms_Goods T ");
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
			parameters[0].Value = "ROYcms_Goods";
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

