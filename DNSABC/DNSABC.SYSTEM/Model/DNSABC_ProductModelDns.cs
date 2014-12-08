using System;
namespace DNSABC.Model
{
	/// <summary>
	/// 产品域名扩展表
	/// </summary>
	[Serializable]
	public partial class DNSABC_ProductModelDns
	{
		public DNSABC_ProductModelDns()
		{}
		#region Model
		private int _id;
		private int _productid;
		private int _ishost=0;
		private int _isttl=0;
		private int _ismonitor=0;
		private int _isgroupid=0;
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
		/// 产品ID
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
		/// TTL值 0表示TTL值不限制，大于0表示最小TTL值
		/// </summary>
		public int isTtl
		{
			set{ _isttl=value;}
			get{return _isttl;}
		}
		/// <summary>
		/// 宕机检测个数 0表示无宕机检测功能，大于0表示宕机检测个数
		/// </summary>
		public int isMonitor
		{
			set{ _ismonitor=value;}
			get{return _ismonitor;}
		}
		/// <summary>
		/// NS组 表示默认开通的服务器组，要求管理员后台可以配置，全局标识
		/// </summary>
		public int isGroupID
		{
			set{ _isgroupid=value;}
			get{return _isgroupid;}
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

