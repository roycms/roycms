using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// 实体类ROYcms_Tag 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ROYcms_Tag
	{
		public ROYcms_Tag()
		{}
		#region Model
		private int _id;
		private string _tag;
		private DateTime? _time;
		private string _type;
		/// <summary>
		/// 编号        
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 标签
		/// </summary>
		public string Tag
		{
			set{ _tag=value;}
			get{return _tag;}
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
		/// 类型
		/// </summary>
		public string type
		{
			set{ _type=value;}
			get{return _type;}
		}
		#endregion Model

	}
}

