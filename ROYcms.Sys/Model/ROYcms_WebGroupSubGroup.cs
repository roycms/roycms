using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// 实体类ROYcms_WebGroupSubGroup 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ROYcms_WebGroupSubGroup
	{
		public ROYcms_WebGroupSubGroup()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _domain;
		private string _keystring;
		private string _guid;
		private int? _state;
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
		/// 站群名称
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 站群范围 区域 标识字符
		/// </summary>
		public string Domain
		{
			set{ _domain=value;}
			get{return _domain;}
		}
		/// <summary>
		/// 关键词 字符
		/// </summary>
		public string KeyString
		{
			set{ _keystring=value;}
			get{return _keystring;}
		}
		/// <summary>
		/// 全局标识 
		/// </summary>
		public string GUID
		{
			set{ _guid=value;}
			get{return _guid;}
		}
		/// <summary>
		/// 状态
		/// </summary>
		public int? State
		{
			set{ _state=value;}
			get{return _state;}
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

