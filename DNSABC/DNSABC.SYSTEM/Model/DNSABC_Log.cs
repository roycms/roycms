using System;
namespace DNSABC.Model
{
	/// <summary>
	/// 日志表
	/// </summary>
	[Serializable]
	public partial class DNSABC_Log
	{
		public DNSABC_Log()
		{}
		#region Model
		private int _id;
		private int? _userid;
		private int? _logtype;
		private string _content;
		private string _operator;
		private string _ip;
		private int? _adminid;
		private string _objecttype;
		private string _objectid;
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
		public int? UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 日志类型
		/// </summary>
		public int? LogType
		{
			set{ _logtype=value;}
			get{return _logtype;}
		}
		/// <summary>
		/// 内容
		/// </summary>
		public string Content
		{
			set{ _content=value;}
			get{return _content;}
		}
		/// <summary>
		/// 操作人
		/// </summary>
		public string Operator
		{
			set{ _operator=value;}
			get{return _operator;}
		}
		/// <summary>
		/// 操作IP 考虑反向代理的情况，获取真实IP
		/// </summary>
		public string Ip
		{
			set{ _ip=value;}
			get{return _ip;}
		}
		/// <summary>
		/// 【管理员字段】管理员ID
		/// </summary>
		public int? AdminID
		{
			set{ _adminid=value;}
			get{return _adminid;}
		}
		/// <summary>
		/// 业务编码【管理员字段】
		/// </summary>
		public string ObjectType
		{
			set{ _objecttype=value;}
			get{return _objecttype;}
		}
		/// <summary>
		/// 业务标识【管理员字段】
		/// </summary>
		public string ObjectID
		{
			set{ _objectid=value;}
			get{return _objectid;}
		}
		/// <summary>
		/// 备注【管理员字段】
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 操作时间
		/// </summary>
		public DateTime? CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		#endregion Model

	}
}

