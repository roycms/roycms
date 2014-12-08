using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// 实体类ROYcms_user_defined 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ROYcms_user_defined
	{
		public ROYcms_user_defined()
		{}
		#region Model
		private int _id;
		private int? _user_id;
		private string _title;
		private string _xmlpath;
		private string _key_id;
		private string _fieldgroup;
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
		public string title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string XmlPath
		{
			set{ _xmlpath=value;}
			get{return _xmlpath;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string key_id
		{
			set{ _key_id=value;}
			get{return _key_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FieldGroup
		{
			set{ _fieldgroup=value;}
			get{return _fieldgroup;}
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

