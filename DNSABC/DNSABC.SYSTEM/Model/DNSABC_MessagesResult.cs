using System;
namespace DNSABC.Model
{
	/// <summary>
	/// 消息回复表
	/// </summary>
	[Serializable]
	public partial class DNSABC_MessagesResult
	{
		public DNSABC_MessagesResult()
		{}
		#region Model
		private int _id;
		private int? _messagesid;
		private int _userid;
		private int _adminid;
		private string _title;
		private string _contents;
		private string _ip;
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
		/// 消息ID
		/// </summary>
		public int? MessagesID
		{
			set{ _messagesid=value;}
			get{return _messagesid;}
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
		/// 【管理员字段】管理员ID
		/// </summary>
		public int AdminID
		{
			set{ _adminid=value;}
			get{return _adminid;}
		}
		/// <summary>
		/// 标题
		/// </summary>
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 内容
		/// </summary>
		public string Contents
		{
			set{ _contents=value;}
			get{return _contents;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IP
		{
			set{ _ip=value;}
			get{return _ip;}
		}
		/// <summary>
		/// 发布时间
		/// </summary>
		public DateTime? CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		#endregion Model

	}
}

