using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// 消息表
	/// </summary>
	[Serializable]
	public partial class ROYcms_ASK
	{
		public ROYcms_ASK()
		{}
		#region Model
		private int _id;
		private int _userid;
		private int? _asktype;
		private int? _state;
		private string _title;
		private string _contents;
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
		/// 消息类型
		/// </summary>
		public int? ASKType
		{
			set{ _asktype=value;}
			get{return _asktype;}
		}
		/// <summary>
		/// 状态 0为未读，1为已读，-1为回收站
		/// </summary>
		public int? State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Contents
		{
			set{ _contents=value;}
			get{return _contents;}
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

