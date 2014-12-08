using System;
namespace ROYcms.Blog.Model
{
	/// <summary>
	/// 实体类ROYcms_Blog_user 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ROYcms_Blog_user
	{
		public ROYcms_Blog_user()
		{}
		#region Model
		private int _id;
		private int? _user_id;
		private string _blogtitle;
		private string _keyword;
		private string _description;
		private DateTime? _time;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? user_id
		{
			set{ _user_id=value;}
			get{return _user_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BlogTitle
		{
			set{ _blogtitle=value;}
			get{return _blogtitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Keyword
		{
			set{ _keyword=value;}
			get{return _keyword;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
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

