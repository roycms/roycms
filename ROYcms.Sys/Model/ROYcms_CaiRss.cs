using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// 实体类ROYcms_CaiRss 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ROYcms_CaiRss
	{
		public ROYcms_CaiRss()
		{}
		#region Model
		private int _id;
		private string _rssurl;
		private string _encode;
		private string _htmlstar;
		private string _htmlend;
		private string _path;
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
		/// RSS地址
		/// </summary>
		public string RssUrl
		{
			set{ _rssurl=value;}
			get{return _rssurl;}
		}
		/// <summary>
		/// 编码
		/// </summary>
		public string Encode
		{
			set{ _encode=value;}
			get{return _encode;}
		}
		/// <summary>
		/// 开始URl标签
		/// </summary>
		public string HtmlStar
		{
			set{ _htmlstar=value;}
			get{return _htmlstar;}
		}
		/// <summary>
        /// 结束URl标签
		/// </summary>
		public string HtmlEnd
		{
			set{ _htmlend=value;}
			get{return _htmlend;}
		}
		/// <summary>
		/// 地址
		/// </summary>
		public string Path
		{
			set{ _path=value;}
			get{return _path;}
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

