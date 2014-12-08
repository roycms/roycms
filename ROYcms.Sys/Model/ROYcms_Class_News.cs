using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// 实体类ROYcms_Class_News 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ROYcms_Class_News
	{
		public ROYcms_Class_News()
		{}
		#region Model
		private int _id;
        
		private int? _news_id;
        private int _Class;
		private string _class_id;
		private string _class_list;
		private DateTime? _time;
		private string _guid;
		/// <summary>
		/// 编号
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 新闻ID
		/// </summary>
		public int? news_id
		{
			set{ _news_id=value;}
			get{return _news_id;}
		}
        /// <summary>
        /// 类 编号
        /// </summary>
        public int Class
        {
            set { _Class = value; }
            get { return _Class; }
        }
		/// <summary>
		/// 类ID
		/// </summary>
		public string class_id
		{
			set{ _class_id=value;}
			get{return _class_id;}
		}
		/// <summary>
		/// 类列表
		/// </summary>
		public string class_list
		{
			set{ _class_list=value;}
			get{return _class_list;}
		}
		/// <summary>
		/// 时间
		/// </summary>
		public DateTime? Time
		{
			set{ _time=value;}
			get{return _time;}
		}
		/// <summary>
		/// 全局guid
		/// </summary>
		public string GUID
		{
			set{ _guid=value;}
			get{return _guid;}
		}
		#endregion Model

	}
}

