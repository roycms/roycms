using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// 实体类ROYcms_RolePath 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ROYcms_RolePath
	{
		public ROYcms_RolePath()
		{}
		#region Model
		private int _id;
		private int? _roleid;
		private string _path;
		/// <summary>
		/// 编号    
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 权限ID
		/// </summary>
		public int? RoleID
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		/// <summary>
		/// 地址
		/// </summary>
		public string path
		{
			set{ _path=value;}
			get{return _path;}
		}
		#endregion Model

	}
}

