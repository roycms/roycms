using System;
namespace ROYcms.Ask.Model
{
	/// <summary>
	/// 实体类ROYcms_result 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ROYcms_result
	{
		public ROYcms_result()
		{}
		#region Model
		private int _bh;
		private int? _question_id;
		private string _content;
		private string _user_id;
		private DateTime? _star_time;
		private string _ip;
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
		public int? question_id
		{
			set{ _question_id=value;}
			get{return _question_id;}
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
		public DateTime? star_time
		{
			set{ _star_time=value;}
			get{return _star_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ip
		{
			set{ _ip=value;}
			get{return _ip;}
		}
		#endregion Model

	}
}

