using System;
namespace DNSABC.Model
{
	/// <summary>
	/// 域名业务表 注意：NsGroupID对应的数据结构为Mysql数据库db_system中解析服务器组的ID
	/// </summary>
	[Serializable]
	public partial class DNSABC_Dns
	{
		public DNSABC_Dns()
		{}
		#region Model
		private int _id;
		private int _productid;
		private int _userid;
		private string _domain;
		private string _password;
		private DateTime _startime;
		private DateTime _endtime;
		private int _ishost=0;
		private int _isttl=0;
		private int _ismonitor=0;
		private int _isgroupid=0;
		private int _state=1;
		private string _remark;
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
		/// 产品ID
		/// </summary>
		public int ProductID
		{
			set{ _productid=value;}
			get{return _productid;}
		}
		/// <summary>
		/// 用户ID
		/// </summary>
		public int UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 域名 域名是唯一的
		/// </summary>
		public string Domain
		{
			set{ _domain=value;}
			get{return _domain;}
		}
		/// <summary>
		/// 域名密码 随机生成w3e4r2r6r6t4，全部小写12位长度，中英文间隔，密文储存
		/// </summary>
		public string PASSWORD
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 服务开始时间
		/// </summary>
		public DateTime StarTime
		{
			set{ _startime=value;}
			get{return _startime;}
		}
		/// <summary>
		/// 服务结束时间
		/// </summary>
		public DateTime EndTime
		{
			set{ _endtime=value;}
			get{return _endtime;}
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
		/// 最小TTL值 0表示TTL值不限制，大于0表示最小TTL值
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
		/// 服务器组ID 表示默认开通的服务器组，要求管理员后台可以配置，全局标识
		/// </summary>
		public int isGroupID
		{
			set{ _isgroupid=value;}
			get{return _isgroupid;}
		}
		/// <summary>
		/// 解析状态 0为停用，1为启用；停用的产品不能解析
		/// </summary>
		public int State
		{
			set{ _state=value;}
			get{return _state;}
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

