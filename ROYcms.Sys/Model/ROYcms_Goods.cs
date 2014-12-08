using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// 商品表 商品表
	/// </summary>
	[Serializable]
	public partial class ROYcms_Goods
	{
		public ROYcms_Goods()
		{}
		#region Model
		private int _id;
		private int? _goods_type;
		private string _goods_sn;
		private string _goods_name;
		private string _goods_name_style;
		private int? _click_count;
		private int? _brand_id;
		private string _provider_name;
		private int? _goods_number;
		private int? _goods_weight;
		private int? _market_price;
		private int? _shop_price;
		private int? _promote_price;
		private DateTime? _promote_start_date;
		private DateTime? _promote_end_date;
		private int? _warn_number;
		private string _keywords;
		private string _goods_brief;
		private string _goods_desc;
		private string _goods_thumb;
		private string _goods_img;
		private string _original_img;
		private int? _is_real;
		private string _extension_code;
		private int? _is_on_sale;
		private int? _is_alone_sale;
		private int? _integral;
		private DateTime? _add_time;
		private int? _is_delete;
		private int? _is_best;
		private int? _is_hot;
		private int? _is_promote;
		private DateTime? _last_update;
		private int? _give_integral;
        private int? _classkind;
		/// <summary>
		/// 编号
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 商品分类ID 商品分类ID
		/// </summary>
		public int? goods_type
		{
			set{ _goods_type=value;}
			get{return _goods_type;}
		}
		/// <summary>
		/// 商品的唯一货号 商品的唯一货号
		/// </summary>
		public string goods_sn
		{
			set{ _goods_sn=value;}
			get{return _goods_sn;}
		}
		/// <summary>
		/// 商品的名称
		/// </summary>
		public string goods_name
		{
			set{ _goods_name=value;}
			get{return _goods_name;}
		}
		/// <summary>
		/// 商品名称显示的样式
		/// </summary>
		public string goods_name_style
		{
			set{ _goods_name_style=value;}
			get{return _goods_name_style;}
		}
		/// <summary>
		/// 商品点击数
		/// </summary>
		public int? click_count
		{
			set{ _click_count=value;}
			get{return _click_count;}
		}
		/// <summary>
		/// 品牌id 品牌id，取值于ecs_brand 的 brand_id
		/// </summary>
		public int? brand_id
		{
			set{ _brand_id=value;}
			get{return _brand_id;}
		}
		/// <summary>
		/// 供货人的名称
		/// </summary>
		public string provider_name
		{
			set{ _provider_name=value;}
			get{return _provider_name;}
		}
		/// <summary>
		/// 商品库存数量
		/// </summary>
		public int? goods_number
		{
			set{ _goods_number=value;}
			get{return _goods_number;}
		}
		/// <summary>
		/// 商品的重量 商品的重量，以千克为单位
		/// </summary>
		public int? goods_weight
		{
			set{ _goods_weight=value;}
			get{return _goods_weight;}
		}
		/// <summary>
		/// 市场售价
		/// </summary>
		public int? market_price
		{
			set{ _market_price=value;}
			get{return _market_price;}
		}
		/// <summary>
		/// 本店售价
		/// </summary>
		public int? shop_price
		{
			set{ _shop_price=value;}
			get{return _shop_price;}
		}
		/// <summary>
		/// 促销价格
		/// </summary>
		public int? promote_price
		{
			set{ _promote_price=value;}
			get{return _promote_price;}
		}
		/// <summary>
		/// 促销价格开始日期
		/// </summary>
		public DateTime? promote_start_date
		{
			set{ _promote_start_date=value;}
			get{return _promote_start_date;}
		}
		/// <summary>
		/// 促销价结束日期
		/// </summary>
		public DateTime? promote_end_date
		{
			set{ _promote_end_date=value;}
			get{return _promote_end_date;}
		}
		/// <summary>
		/// 商品报警数量
		/// </summary>
		public int? warn_number
		{
			set{ _warn_number=value;}
			get{return _warn_number;}
		}
		/// <summary>
		/// 商品关键字 商品关键字，放在商品页的关键字中，为搜索引擎收录用
		/// </summary>
		public string keywords
		{
			set{ _keywords=value;}
			get{return _keywords;}
		}
		/// <summary>
		/// 商品的简短描述 商品的简短描述 
		/// </summary>
		public string goods_brief
		{
			set{ _goods_brief=value;}
			get{return _goods_brief;}
		}
		/// <summary>
		/// 商品的详细描述 商品的详细描述
		/// </summary>
		public string goods_desc
		{
			set{ _goods_desc=value;}
			get{return _goods_desc;}
		}
		/// <summary>
		/// 商品在前台显示的微缩 图片，如在分类筛选时显示的小图片
		/// </summary>
		public string goods_thumb
		{
			set{ _goods_thumb=value;}
			get{return _goods_thumb;}
		}
		/// <summary>
		/// 商品属性所显示的大图片 商品属性所显示的大图片
		/// </summary>
		public string goods_img
		{
			set{ _goods_img=value;}
			get{return _goods_img;}
		}
		/// <summary>
		/// 应该是上传的商品的原始图片 应该是上传的商品的原始图片
		/// </summary>
		public string original_img
		{
			set{ _original_img=value;}
			get{return _original_img;}
		}
		/// <summary>
		/// 是否是实物 是否是实物，1，是；0，否；比如虚拟卡就为0，不是实物
		/// </summary>
		public int? is_real
		{
			set{ _is_real=value;}
			get{return _is_real;}
		}
		/// <summary>
		/// 商品的扩展属性 商品的扩展属性，比如像虚拟卡
		/// </summary>
		public string extension_code
		{
			set{ _extension_code=value;}
			get{return _extension_code;}
		}
		/// <summary>
		/// 该商品是否开放销售 该商品是否开放销售，1，是；0，否
		/// </summary>
		public int? is_on_sale
		{
			set{ _is_on_sale=value;}
			get{return _is_on_sale;}
		}
		/// <summary>
		/// 是否能单独销售 是否能单独销售，1，是；0，否；如果不能单独销售，则只能作为某商品的配件或者赠品销售
		/// </summary>
		public int? is_alone_sale
		{
			set{ _is_alone_sale=value;}
			get{return _is_alone_sale;}
		}
		/// <summary>
		/// 购买该商品可以使用的积分数量
		/// </summary>
		public int? integral
		{
			set{ _integral=value;}
			get{return _integral;}
		}
		/// <summary>
		/// 商品的添加时间
		/// </summary>
		public DateTime? add_time
		{
			set{ _add_time=value;}
			get{return _add_time;}
		}
		/// <summary>
		/// 商品是否已经删除 商品是否已经删除，0，否；1，已删除
		/// </summary>
		public int? is_delete
		{
			set{ _is_delete=value;}
			get{return _is_delete;}
		}
		/// <summary>
		/// 是否是精品
		/// </summary>
		public int? is_best
		{
			set{ _is_best=value;}
			get{return _is_best;}
		}
		/// <summary>
		/// 是否热销
		/// </summary>
		public int? is_hot
		{
			set{ _is_hot=value;}
			get{return _is_hot;}
		}
		/// <summary>
		/// 是否特价促销
		/// </summary>
		public int? is_promote
		{
			set{ _is_promote=value;}
			get{return _is_promote;}
		}
		/// <summary>
		/// 最近一次更新商品配置的时间
		/// </summary>
		public DateTime? last_update
		{
			set{ _last_update=value;}
			get{return _last_update;}
		}
		/// <summary>
		/// 购买该商品时每笔成功交易赠送的积分数量
		/// </summary>
		public int? give_integral
		{
			set{ _give_integral=value;}
			get{return _give_integral;}
		}
        public int? classkind
        {
            set { _classkind = value; }
            get { return _classkind; }
        }
		#endregion Model

	}
}

