using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// 实体类ROYcms_Dissertation 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	public class ROYcms_Dissertation
	{
		public ROYcms_Dissertation()
		{}
		#region Model
		private int _id;
		private string _dissertation_name;
		private string _dissertation_content;
		private string _templet_url;
		/// <summary>
		/// 编号
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 专题名称
		/// </summary>
		public string dissertation_name
		{
			set{ _dissertation_name=value;}
			get{return _dissertation_name;}
		}
		/// <summary>
		/// 专题内容
		/// </summary>
		public string dissertation_content
		{
			set{ _dissertation_content=value;}
			get{return _dissertation_content;}
		}
		/// <summary>
		/// 模板地址
		/// </summary>
		public string templet_url
		{
			set{ _templet_url=value;}
			get{return _templet_url;}
		}
		#endregion Model

	}
}

