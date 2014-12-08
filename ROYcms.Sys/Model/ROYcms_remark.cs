using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// 实体类ROYcms_remark 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ROYcms_remark
	{
		public ROYcms_remark()
		{}
		#region Model
		private int _bh;
		private int? _newid;
		private int _userid;
		private string _username;
		private string _contents;
		private string _ip;
		private DateTime? _time;
		/// <summary>
		/// 编号
		/// </summary>
		public int bh
		{
			set{ _bh=value;}
			get{return _bh;}
		}
		/// <summary>
		/// 新闻ID
		/// </summary>
		public int? NewID
		{
			set{ _newid=value;}
			get{return _newid;}
		}
		/// <summary>
		/// 用户ID
		/// </summary>
		public int userID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 用户name
		/// </summary>
		public string userName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 评论内容
		/// </summary>
		public string contents
		{
			set{ _contents=value;}
			get{return _contents;}
		}
		/// <summary>
		/// IP 地址
		/// </summary>
		public string Ip
		{
			set{ _ip=value;}
			get{return _ip;}
		}
		/// <summary>
		/// 时间
		/// </summary>
		public DateTime? Time
		{
			set{ _time=value;}
			get{return _time;}
		}
		#endregion Model

	}
}

