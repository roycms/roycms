using System;
namespace DNSABC.Model
{
	/// <summary>
	/// 订单表
	/// </summary>
	[Serializable]
	public partial class DNSABC_Order
	{
		public DNSABC_Order()
		{}
		#region Model
		private int _id;
		private string  _orderid;
		private int _producttype;
		private int _productid;
		private string _productname;
		private int _userid;
		private string _domain;
		private int _price;
		private int _state;
		private string _remark;
		private DateTime? _finishtime;
		private DateTime? _updatetime;
		private DateTime? _createtime;
		/// <summary>
		/// 编号
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 订单号 时间戳，格式：201212091211290001
		/// </summary>
		public string OrderId
		{
			set{ _orderid=value;}
			get{return _orderid;}
		}
		/// <summary>
		/// 产品类型 1，DNS，ProductModelDns；2，CDN，ProductModelCdn。
		/// </summary>
		public int ProductType
		{
			set{ _producttype=value;}
			get{return _producttype;}
		}
		/// <summary>
		/// 产品ID
		/// </summary>
		public int ProductID
		{
			set{ _productid=value;}
			get{return _productid;}
		}
		/// <summary>
		/// 产品名称
		/// </summary>
		public string ProductName
		{
			set{ _productname=value;}
			get{return _productname;}
		}
		/// <summary>
		/// 用户ID
		/// </summary>
		public int UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 产品标识 对应业务的表示，比如为域名或者IP
		/// </summary>
		public string Domain
		{
			set{ _domain=value;}
			get{return _domain;}
		}
		/// <summary>
		/// 产品金额
		/// </summary>
		public int Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 订单状态
		/// </summary>
		public int State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 附注说明 生成订单的时候，需要描述该订单的详细内容。
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 完成时间
		/// </summary>
		public DateTime? FinishTime
		{
			set{ _finishtime=value;}
			get{return _finishtime;}
		}
		/// <summary>
		/// 更新时间
		/// </summary>
		public DateTime? UpdateTime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		#endregion Model

	}
}

