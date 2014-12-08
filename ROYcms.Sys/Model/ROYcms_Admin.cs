using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// 实体类ROYcms_Admin 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ROYcms_Admin
	{
		public ROYcms_Admin()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _password;
		private string _classkind;
		private int? _rol;
		/// <summary>
		/// 编号
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 用户名 
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 密码
		/// </summary>
		public string password
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 对象编号
		/// </summary>
		public string classkind
		{
			set{ _classkind=value;}
			get{return _classkind;}
		}
		/// <summary>
		/// 权限编号
		/// </summary>
		public int? Rol
		{
			set{ _rol=value;}
			get{return _rol;}
		}
		#endregion Model

	}
}

