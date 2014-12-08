using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// 实体类ROYcms_XML 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ROYcms_XML
	{
		public ROYcms_XML()
		{}
		#region Model
		private int _id;
		private string _guid;
		private string _contents;
		private DateTime? _time;
		/// <summary>
		///  编号 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 全局统一标识                        
		/// </summary>
		public string GUID
		{
			set{ _guid=value;}
			get{return _guid;}
		}
		/// <summary>
		/// 内容
		/// </summary>
		public string Contents
		{
			set{ _contents=value;}
			get{return _contents;}
		}
		/// <summary>
		/// 事件
		/// </summary>
		public DateTime? Time
		{
			set{ _time=value;}
			get{return _time;}
		}
		#endregion Model

	}
}

