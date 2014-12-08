using System;
namespace DNSABC.Model
{
	/// <summary>
	/// 消息表
	/// </summary>
	[Serializable]
	public partial class DNSABC_Messages
	{
		public DNSABC_Messages()
		{}
		#region Model
		private int _id;
		private int _messagestypeid;
		private int _userid;
		private string _title;
		private string _contents;
		private string _ip;
		private int _state;
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
		/// 处理类型ID 系统配置参数
		/// </summary>
		public int MessagesTypeID
		{
			set{ _messagestypeid=value;}
			get{return _messagestypeid;}
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
		/// IP地址
		/// </summary>
		public string IP
		{
			set{ _ip=value;}
			get{return _ip;}
		}
		/// <summary>
		/// 状态 0为处理中 1为关闭
		/// </summary>
		public int State
		{
			set{ _state=value;}
			get{return _state;}
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

