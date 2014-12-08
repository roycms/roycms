using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// ROYcms_Log:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ROYcms_Log
	{
		public ROYcms_Log()
		{}
		#region Model
		private int _id;
		private int? _user_id;
		private int? _admin_id;
		private string _err_id;
		private string _event;
		private string _content;
		private DateTime? _time= DateTime.Now;
		private string _ip;
		/// <summary>
		/// 编号
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 用户ID
		/// </summary>
		public int? User_id
		{
			set{ _user_id=value;}
			get{return _user_id;}
		}
		/// <summary>
		/// 管理员ID
		/// </summary>
		public int? Admin_id
		{
			set{ _admin_id=value;}
			get{return _admin_id;}
		}
		/// <summary>
		/// 错误id   标识 1管理员登录 2普通会员登录 3管理员操作日志 4普通会员操作日志 5错误日志
		/// </summary>
		public string Err_id
		{
			set{ _err_id=value;}
			get{return _err_id;}
		}
		/// <summary>
		/// 事件
		/// </summary>
		public string Event
		{
			set{ _event=value;}
			get{return _event;}
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
		/// 发生时间
		/// </summary>
		public DateTime? Time
		{
			set{ _time=value;}
			get{return _time;}
		}
		/// <summary>
		/// 来源ip
		/// </summary>
		public string Ip
		{
			set{ _ip=value;}
			get{return _ip;}
		}
		#endregion Model

	}
}

