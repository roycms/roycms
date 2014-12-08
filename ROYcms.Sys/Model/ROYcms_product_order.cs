using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// ROYcms_product_order:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ROYcms_product_order
	{
		public ROYcms_product_order()
		{}
		#region Model
		private int _id;
		private string _order_id;
		private string _user_id;
		private string _order_status;
		private decimal? _order_price;
		private string _order_payment;
		private string _order_rec_name;
		private string _order_rec_address;
		private string _order_rec_code;
		private string _order_rec_phone;
		private string _order_rec_tel;
		private string _order_shipping;
		private decimal? _order_freight;
		private string _order_deliverytime;
		private DateTime? _create_time;
		private bool? _ifdefault;
		/// <summary>
		/// 编号
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 订单号
		/// </summary>
		public string order_id
		{
			set{ _order_id=value;}
			get{return _order_id;}
		}
		/// <summary>
		/// 用户id
		/// </summary>
		public string user_id
		{
			set{ _user_id=value;}
			get{return _user_id;}
		}
		/// <summary>
		/// 订单状态
		/// </summary>
		public string order_status
		{
			set{ _order_status=value;}
			get{return _order_status;}
		}
		/// <summary>
		/// 订单金额
		/// </summary>
		public decimal? order_price
		{
			set{ _order_price=value;}
			get{return _order_price;}
		}
		/// <summary>
		/// 订单 付款方式
		/// </summary>
		public string order_payment
		{
			set{ _order_payment=value;}
			get{return _order_payment;}
		}
		/// <summary>
		/// 收货人
		/// </summary>
		public string order_rec_name
		{
			set{ _order_rec_name=value;}
			get{return _order_rec_name;}
		}
		/// <summary>
		/// 收货人地址
		/// </summary>
		public string order_rec_address
		{
			set{ _order_rec_address=value;}
			get{return _order_rec_address;}
		}
		/// <summary>
		/// 收货人邮编
		/// </summary>
		public string order_rec_code
		{
			set{ _order_rec_code=value;}
			get{return _order_rec_code;}
		}
		/// <summary>
		/// 收货人电话
		/// </summary>
		public string order_rec_phone
		{
			set{ _order_rec_phone=value;}
			get{return _order_rec_phone;}
		}
		/// <summary>
		/// 收货人手机
		/// </summary>
		public string order_rec_tel
		{
			set{ _order_rec_tel=value;}
			get{return _order_rec_tel;}
		}
		/// <summary>
		/// 配送方式
		/// </summary>
		public string order_shipping
		{
			set{ _order_shipping=value;}
			get{return _order_shipping;}
		}
		/// <summary>
		/// 运费
		/// </summary>
		public decimal? order_freight
		{
			set{ _order_freight=value;}
			get{return _order_freight;}
		}
		/// <summary>
		/// 订单交付时间
		/// </summary>
		public string order_deliveryTime
		{
			set{ _order_deliverytime=value;}
			get{return _order_deliverytime;}
		}
		/// <summary>
		/// 时间
		/// </summary>
		public DateTime? create_time
		{
			set{ _create_time=value;}
			get{return _create_time;}
		}
		/// <summary>
		/// 标识
		/// </summary>
		public bool? ifdefault
		{
			set{ _ifdefault=value;}
			get{return _ifdefault;}
		}
		#endregion Model

	}
}

