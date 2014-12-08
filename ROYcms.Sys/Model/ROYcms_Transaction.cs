using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// 交易记录表
	/// </summary>
	[Serializable]
	public partial class ROYcms_Transaction
	{
		public ROYcms_Transaction()
		{}
		#region Model
		private int _id;
		private int _userid;
		private int _tradetype;
		private int _price;
		private int _accountbalance;
		private string _payentmethord;
		private string _tradeexplaining;
		private string _paymentlogo;
		private string _remark;
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
		public int UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 交易类型 1为在线支付 2为银行汇款 3为现金 4为其他
		/// </summary>
		public int TradeType
		{
			set{ _tradetype=value;}
			get{return _tradetype;}
		}
		/// <summary>
		/// 交易金额 正数为充值，负数为退款
		/// </summary>
		public int Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 账户余额
		/// </summary>
		public int AccountBalance
		{
			set{ _accountbalance=value;}
			get{return _accountbalance;}
		}
		/// <summary>
		/// 支付方式
		/// </summary>
		public string PayentMethord
		{
			set{ _payentmethord=value;}
			get{return _payentmethord;}
		}
		/// <summary>
		/// 交易说明
		/// </summary>
		public string TradeExplaining
		{
			set{ _tradeexplaining=value;}
			get{return _tradeexplaining;}
		}
		/// <summary>
		/// 付款标识
		/// </summary>
		public string PaymentLogo
		{
			set{ _paymentlogo=value;}
			get{return _paymentlogo;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 交易时间
		/// </summary>
		public DateTime? CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		#endregion Model

	}
}

