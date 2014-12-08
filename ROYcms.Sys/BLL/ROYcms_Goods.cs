using System;
using System.Data;
using System.Collections.Generic;
using ROYcms.Common;
using ROYcms.Sys.Model;
namespace ROYcms.Sys.BLL
{
	/// <summary>
	/// 商品表 商品表
	/// </summary>
	public partial class ROYcms_Goods
	{
		private readonly ROYcms.Sys.DAL.ROYcms_Goods dal=new ROYcms.Sys.DAL.ROYcms_Goods();
		public ROYcms_Goods()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			return dal.Exists(Id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(ROYcms.Sys.Model.ROYcms_Goods model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(ROYcms.Sys.Model.ROYcms_Goods model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Id)
		{
			
			return dal.Delete(Id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string Idlist )
		{
			return dal.DeleteList(Idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ROYcms.Sys.Model.ROYcms_Goods GetModel(int Id)
		{
			
			return dal.GetModel(Id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public ROYcms.Sys.Model.ROYcms_Goods GetModelByCache(int Id)
		{
			
			string CacheKey = "ROYcms_GoodsModel-" + Id;
			object objModel = ROYcms.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(Id);
					if (objModel != null)
					{
						int ModelCache = ROYcms.Common.ConfigHelper.GetConfigInt("ModelCache");
						ROYcms.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (ROYcms.Sys.Model.ROYcms_Goods)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<ROYcms.Sys.Model.ROYcms_Goods> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<ROYcms.Sys.Model.ROYcms_Goods> DataTableToList(DataTable dt)
		{
			List<ROYcms.Sys.Model.ROYcms_Goods> modelList = new List<ROYcms.Sys.Model.ROYcms_Goods>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ROYcms.Sys.Model.ROYcms_Goods model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new ROYcms.Sys.Model.ROYcms_Goods();
					if(dt.Rows[n]["Id"]!=null && dt.Rows[n]["Id"].ToString()!="")
					{
						model.Id=int.Parse(dt.Rows[n]["Id"].ToString());
					}
					if(dt.Rows[n]["goods_type"]!=null && dt.Rows[n]["goods_type"].ToString()!="")
					{
						model.goods_type=int.Parse(dt.Rows[n]["goods_type"].ToString());
					}
					if(dt.Rows[n]["goods_sn"]!=null && dt.Rows[n]["goods_sn"].ToString()!="")
					{
					model.goods_sn=dt.Rows[n]["goods_sn"].ToString();
					}
					if(dt.Rows[n]["goods_name"]!=null && dt.Rows[n]["goods_name"].ToString()!="")
					{
					model.goods_name=dt.Rows[n]["goods_name"].ToString();
					}
					if(dt.Rows[n]["goods_name_style"]!=null && dt.Rows[n]["goods_name_style"].ToString()!="")
					{
					model.goods_name_style=dt.Rows[n]["goods_name_style"].ToString();
					}
					if(dt.Rows[n]["click_count"]!=null && dt.Rows[n]["click_count"].ToString()!="")
					{
						model.click_count=int.Parse(dt.Rows[n]["click_count"].ToString());
					}
					if(dt.Rows[n]["brand_id"]!=null && dt.Rows[n]["brand_id"].ToString()!="")
					{
						model.brand_id=int.Parse(dt.Rows[n]["brand_id"].ToString());
					}
					if(dt.Rows[n]["provider_name"]!=null && dt.Rows[n]["provider_name"].ToString()!="")
					{
					model.provider_name=dt.Rows[n]["provider_name"].ToString();
					}
					if(dt.Rows[n]["goods_number"]!=null && dt.Rows[n]["goods_number"].ToString()!="")
					{
						model.goods_number=int.Parse(dt.Rows[n]["goods_number"].ToString());
					}
					if(dt.Rows[n]["goods_weight"]!=null && dt.Rows[n]["goods_weight"].ToString()!="")
					{
						model.goods_weight=int.Parse(dt.Rows[n]["goods_weight"].ToString());
					}
					if(dt.Rows[n]["market_price"]!=null && dt.Rows[n]["market_price"].ToString()!="")
					{
						model.market_price=int.Parse(dt.Rows[n]["market_price"].ToString());
					}
					if(dt.Rows[n]["shop_price"]!=null && dt.Rows[n]["shop_price"].ToString()!="")
					{
						model.shop_price=int.Parse(dt.Rows[n]["shop_price"].ToString());
					}
					if(dt.Rows[n]["promote_price"]!=null && dt.Rows[n]["promote_price"].ToString()!="")
					{
						model.promote_price=int.Parse(dt.Rows[n]["promote_price"].ToString());
					}
					if(dt.Rows[n]["promote_start_date"]!=null && dt.Rows[n]["promote_start_date"].ToString()!="")
					{
						model.promote_start_date=DateTime.Parse(dt.Rows[n]["promote_start_date"].ToString());
					}
					if(dt.Rows[n]["promote_end_date"]!=null && dt.Rows[n]["promote_end_date"].ToString()!="")
					{
						model.promote_end_date=DateTime.Parse(dt.Rows[n]["promote_end_date"].ToString());
					}
					if(dt.Rows[n]["warn_number"]!=null && dt.Rows[n]["warn_number"].ToString()!="")
					{
						model.warn_number=int.Parse(dt.Rows[n]["warn_number"].ToString());
					}
					if(dt.Rows[n]["keywords"]!=null && dt.Rows[n]["keywords"].ToString()!="")
					{
					model.keywords=dt.Rows[n]["keywords"].ToString();
					}
					if(dt.Rows[n]["goods_brief"]!=null && dt.Rows[n]["goods_brief"].ToString()!="")
					{
					model.goods_brief=dt.Rows[n]["goods_brief"].ToString();
					}
					if(dt.Rows[n]["goods_desc"]!=null && dt.Rows[n]["goods_desc"].ToString()!="")
					{
					model.goods_desc=dt.Rows[n]["goods_desc"].ToString();
					}
					if(dt.Rows[n]["goods_thumb"]!=null && dt.Rows[n]["goods_thumb"].ToString()!="")
					{
					model.goods_thumb=dt.Rows[n]["goods_thumb"].ToString();
					}
					if(dt.Rows[n]["goods_img"]!=null && dt.Rows[n]["goods_img"].ToString()!="")
					{
					model.goods_img=dt.Rows[n]["goods_img"].ToString();
					}
					if(dt.Rows[n]["original_img"]!=null && dt.Rows[n]["original_img"].ToString()!="")
					{
					model.original_img=dt.Rows[n]["original_img"].ToString();
					}
					if(dt.Rows[n]["is_real"]!=null && dt.Rows[n]["is_real"].ToString()!="")
					{
						model.is_real=int.Parse(dt.Rows[n]["is_real"].ToString());
					}
					if(dt.Rows[n]["extension_code"]!=null && dt.Rows[n]["extension_code"].ToString()!="")
					{
					model.extension_code=dt.Rows[n]["extension_code"].ToString();
					}
					if(dt.Rows[n]["is_on_sale"]!=null && dt.Rows[n]["is_on_sale"].ToString()!="")
					{
						model.is_on_sale=int.Parse(dt.Rows[n]["is_on_sale"].ToString());
					}
					if(dt.Rows[n]["is_alone_sale"]!=null && dt.Rows[n]["is_alone_sale"].ToString()!="")
					{
						model.is_alone_sale=int.Parse(dt.Rows[n]["is_alone_sale"].ToString());
					}
					if(dt.Rows[n]["integral"]!=null && dt.Rows[n]["integral"].ToString()!="")
					{
						model.integral=int.Parse(dt.Rows[n]["integral"].ToString());
					}
					if(dt.Rows[n]["add_time"]!=null && dt.Rows[n]["add_time"].ToString()!="")
					{
						model.add_time=DateTime.Parse(dt.Rows[n]["add_time"].ToString());
					}
					if(dt.Rows[n]["is_delete"]!=null && dt.Rows[n]["is_delete"].ToString()!="")
					{
						model.is_delete=int.Parse(dt.Rows[n]["is_delete"].ToString());
					}
					if(dt.Rows[n]["is_best"]!=null && dt.Rows[n]["is_best"].ToString()!="")
					{
						model.is_best=int.Parse(dt.Rows[n]["is_best"].ToString());
					}
					if(dt.Rows[n]["is_hot"]!=null && dt.Rows[n]["is_hot"].ToString()!="")
					{
						model.is_hot=int.Parse(dt.Rows[n]["is_hot"].ToString());
					}
					if(dt.Rows[n]["is_promote"]!=null && dt.Rows[n]["is_promote"].ToString()!="")
					{
						model.is_promote=int.Parse(dt.Rows[n]["is_promote"].ToString());
					}
					if(dt.Rows[n]["last_update"]!=null && dt.Rows[n]["last_update"].ToString()!="")
					{
						model.last_update=DateTime.Parse(dt.Rows[n]["last_update"].ToString());
					}
					if(dt.Rows[n]["give_integral"]!=null && dt.Rows[n]["give_integral"].ToString()!="")
					{
						model.give_integral=int.Parse(dt.Rows[n]["give_integral"].ToString());
					}
                    if (dt.Rows[n]["ClassKind"] != null && dt.Rows[n]["ClassKind"].ToString() != "")
                    {
                        model.classkind = int.Parse(dt.Rows[n]["ClassKind"].ToString());
                    }
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere)
        {
            return dal.GetList(PageSize, PageIndex, strWhere);
        }

		#endregion  Method
	}
}

