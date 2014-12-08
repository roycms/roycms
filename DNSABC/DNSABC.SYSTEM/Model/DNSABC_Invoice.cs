using System;
namespace DNSABC.Model
{
	/// <summary>
	/// 发票记录表
	/// </summary>
	[Serializable]
	public partial class DNSABC_Invoice
	{
		public DNSABC_Invoice()
		{}
		#region Model
		private int _id;
		private int _userid;
		private string _invoicename;
		private int _price;
		private int _posttype;
		private string _realname;
		private string _tel;
		private string _mobil;
		private string _address;
		private string _postcode;
		private string _remark;
		private int _state=0;
		private string _adminremark;
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
		/// 申领人
		/// </summary>
		public int UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 发票抬头
		/// </summary>
		public string InvoiceName
		{
			set{ _invoicename=value;}
			get{return _invoicename;}
		}
		/// <summary>
		/// 申领金额
		/// </summary>
		public int Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 邮寄方式
		/// </summary>
		public int PostType
		{
			set{ _posttype=value;}
			get{return _posttype;}
		}
		/// <summary>
		/// 联系人
		/// </summary>
		public string RealName
		{
			set{ _realname=value;}
			get{return _realname;}
		}
		/// <summary>
		/// 电话
		/// </summary>
		public string Tel
		{
			set{ _tel=value;}
			get{return _tel;}
		}
		/// <summary>
		/// 手机
		/// </summary>
		public string Mobil
		{
			set{ _mobil=value;}
			get{return _mobil;}
		}
		/// <summary>
		/// 邮寄地址
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 邮编
		/// </summary>
		public string PostCode
		{
			set{ _postcode=value;}
			get{return _postcode;}
		}
		/// <summary>
		/// 备注 用户申请发票时的备注信息
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 管理员处理状态 0为未处理，1为已处理
		/// </summary>
		public int State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 管理员备注 备注发票邮寄方式信息方便用户查询
		/// </summary>
		public string AdminRemark
		{
			set{ _adminremark=value;}
			get{return _adminremark;}
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

