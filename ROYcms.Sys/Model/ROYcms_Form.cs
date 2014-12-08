using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// 实体类ROYcms_Form 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ROYcms_Form
	{
		public ROYcms_Form()
		{}
		#region Model
		private int _id;
		private string _title;
		private string _zhaiyao;
		private int? _classname;
		private int? _classkind_id;
		private int? _class_id;
		private string _setfrom;
		private string _path;
		private string _contents;
		private DateTime? _time;
		private string _guid;
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
		public string title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zhaiyao
		{
			set{ _zhaiyao=value;}
			get{return _zhaiyao;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? classname
		{
			set{ _classname=value;}
			get{return _classname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ClassKind_id
		{
			set{ _classkind_id=value;}
			get{return _classkind_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Class_id
		{
			set{ _class_id=value;}
			get{return _class_id;}
		}
		/// <summary>
		/// 表单集合
		/// </summary>
		public string SetFrom
		{
			set{ _setfrom=value;}
			get{return _setfrom;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Path
		{
			set{ _path=value;}
			get{return _path;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Contents
		{
			set{ _contents=value;}
			get{return _contents;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Time
		{
			set{ _time=value;}
			get{return _time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GUID
		{
			set{ _guid=value;}
			get{return _guid;}
		}
		#endregion Model

	}
}

