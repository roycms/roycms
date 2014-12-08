using System;
namespace DNSABC.Model
{
	/// <summary>
	/// 产品主机扩展表
	/// </summary>
	[Serializable]
	public partial class DNSABC_ProductModelCdn
	{
		public DNSABC_ProductModelCdn()
		{}
		#region Model
		private int _id;
		private int _productid;
		private int _ishost=0;
		private int _isconnection=0;
		private int _isbandwidth=0;
		private string _remark;
		/// <summary>
		/// 编号
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 编号ID
		/// </summary>
		public int ProductID
		{
			set{ _productid=value;}
			get{return _productid;}
		}
		/// <summary>
		/// 主机个数 0表示主机个数不限制，大于0表示主机个数
		/// </summary>
		public int isHost
		{
			set{ _ishost=value;}
			get{return _ishost;}
		}
		/// <summary>
		/// 连接数 0表示连接数不限制，大于0表示最大连接数
		/// </summary>
		public int isConnection
		{
			set{ _isconnection=value;}
			get{return _isconnection;}
		}
		/// <summary>
		/// 带宽 0表示带宽不限制，大于0表示最大带宽
		/// </summary>
		public int isBandwidth
		{
			set{ _isbandwidth=value;}
			get{return _isbandwidth;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

