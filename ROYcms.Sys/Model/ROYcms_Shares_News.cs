using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// 实体类ROYcms_Shares_News 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ROYcms_Shares_News
	{
		public ROYcms_Shares_News()
		{}
		#region Model
		private int _id;
		private int? _news_id;
		private string _typename;
		private DateTime? _time;
		/// <summary>
		/// 编号
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 新闻编号
		/// </summary>
		public int? news_id
		{
			set{ _news_id=value;}
			get{return _news_id;}
		}
		/// <summary>
		/// 推荐分类
		/// </summary>
		public string typename
		{
			set{ _typename=value;}
			get{return _typename;}
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

