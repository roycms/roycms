using System;
namespace DNSABC.Model
{
	/// <summary>
	/// 在线支付记录表
	/// </summary>
	[Serializable]
	public partial class DNSABC_Payment
	{
		public DNSABC_Payment()
		{}
		#region Model
		private int _id;
		private int? _userid;
		private string _paymenttype;
		private string _paymentname;
		private int? _paymentamount;
		private string _paymentnum;
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
		/// 用户ID
		/// </summary>
		public int? UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 支付接口
		/// </summary>
		public string PaymentType
		{
			set{ _paymenttype=value;}
			get{return _paymenttype;}
		}
		/// <summary>
		/// 支付接口名称
		/// </summary>
		public string PaymentName
		{
			set{ _paymentname=value;}
			get{return _paymentname;}
		}
		/// <summary>
		/// 支付金额
		/// </summary>
		public int? PaymentAmount
		{
			set{ _paymentamount=value;}
			get{return _paymentamount;}
		}
		/// <summary>
		/// 支付号
		/// </summary>
		public string PaymentNum
		{
			set{ _paymentnum=value;}
			get{return _paymentnum;}
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

