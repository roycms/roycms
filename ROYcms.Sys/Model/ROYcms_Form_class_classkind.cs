using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// 实体类ROYcms_Form_class_classkind 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ROYcms_Form_class_classkind
	{
		public ROYcms_Form_class_classkind()
		{}
		#region Model
		private int _id;
		private int? _from_id;
		private string _from_guid;
		private int? _class_id;
		private int? _classkind_id;
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
		public int? From_id
		{
			set{ _from_id=value;}
			get{return _from_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string From_GUID
		{
			set{ _from_guid=value;}
			get{return _from_guid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? class_id
		{
			set{ _class_id=value;}
			get{return _class_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? classkind_id
		{
			set{ _classkind_id=value;}
			get{return _classkind_id;}
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

