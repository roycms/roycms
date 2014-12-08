using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// 管理后台的文件地址及对应的功能
	/// </summary>
	[Serializable]
	public partial class ROYcms_AdminUrlMap
	{
		public ROYcms_AdminUrlMap()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _path;
		private string _description;
		private DateTime? _time;
		/// <summary>
		/// 编号
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 权限名称
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 文件地址
		/// </summary>
		public string Path
		{
			set{ _path=value;}
			get{return _path;}
		}
		/// <summary>
		/// 文件功能描述
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// 时间
		/// </summary>
		public DateTime? TIME
		{
			set{ _time=value;}
			get{return _time;}
		}
		#endregion Model

	}
}

