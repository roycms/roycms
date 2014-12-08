using System;
namespace ROYcms.Community.Model
{
	/// <summary>
	/// 实体类ROYcms_Community_result 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ROYcms_Community_result
	{
		public ROYcms_Community_result()
		{}
		#region Model
		private int _bh;
		private int? _community_id;
		private string _title;
		private string _content;
		private string _user_id;
		private string _ip;
		private DateTime? _time;
		/// <summary>
		/// 
		/// </summary>
		public int bh
		{
			set{ _bh=value;}
			get{return _bh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Community_id
		{
			set{ _community_id=value;}
			get{return _community_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string content
		{
			set{ _content=value;}
			get{return _content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string user_id
		{
			set{ _user_id=value;}
			get{return _user_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ip
		{
			set{ _ip=value;}
			get{return _ip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Time
		{
			set{ _time=value;}
			get{return _time;}
		}
		#endregion Model

	}
}

