using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// 实体类ROYcms_CustomTag 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	public class ROYcms_CustomTag
	{
		public ROYcms_CustomTag()
		{}
		#region Model
		private int _id;
		private string _tag;
		private string _tag_name;
		private string _tag_content;
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
		public string TAG
		{
			set{ _tag=value;}
			get{return _tag;}
		}
		/// <summary>
		/// 标签名称
		/// </summary>
		public string TAG_name
		{
			set{ _tag_name=value;}
			get{return _tag_name;}
		}
		/// <summary>
		/// 标签内容
		/// </summary>
		public string TAG_content
		{
			set{ _tag_content=value;}
			get{return _tag_content;}
		}
		#endregion Model

	}
}

