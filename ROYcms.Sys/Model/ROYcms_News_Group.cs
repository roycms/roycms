using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// 实体类ROYcms_News_Group 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ROYcms_News_Group
	{
		public ROYcms_News_Group()
		{}
		#region Model
		private int _id;
		private int? _index_news_id;
		private int? _news_id;
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
		public int? index_news_id
		{
			set{ _index_news_id=value;}
			get{return _index_news_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? news_id
		{
			set{ _news_id=value;}
			get{return _news_id;}
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

