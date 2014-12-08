using System;
namespace DNSABC.Model
{
	/// <summary>
	/// 用户信息 用户表 ROYcms_user 用户表 ROYcms_user
	///增加用户可用状态；增加注册时间、资料更新时间、最后登录时间；增加用户登录次数。
	/// </summary>
	[Serializable]
	public partial class ROYcms_user
	{
		public ROYcms_user()
		{}
		#region Model
		private int _bh;
		private string _roleid;
		private string _ugroupid;
		private string _name;
		private string _password;
		private int? _money;
		private string _qq;
		private string _email;
		private int? _age;
		private string _sex;
		private string _pic;
		private string _quanxian;
		private string _username;
		private string _guid;
		private string _ip;
		private DateTime? _logintime;
		/// <summary>
		/// 编号
		/// </summary>
		public int bh
		{
			set{ _bh=value;}
			get{return _bh;}
		}
		/// <summary>
		/// 权限ID
		/// </summary>
		public string RoleID
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		/// <summary>
		/// 用户组ID
		/// </summary>
		public string UgroupID
		{
			set{ _ugroupid=value;}
			get{return _ugroupid;}
		}
		/// <summary>
		/// 用户名
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 密码
		/// </summary>
		public string PASSWORD
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 积分
		/// </summary>
		public int? money
		{
			set{ _money=value;}
			get{return _money;}
		}
		/// <summary>
		/// QQ
		/// </summary>
		public string Qq
		{
			set{ _qq=value;}
			get{return _qq;}
		}
		/// <summary>
		/// 邮件
		/// </summary>
		public string Email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 年龄
		/// </summary>
		public int? Age
		{
			set{ _age=value;}
			get{return _age;}
		}
		/// <summary>
		/// 性别
		/// </summary>
		public string sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 头像
		/// </summary>
		public string Pic
		{
			set{ _pic=value;}
			get{return _pic;}
		}
		/// <summary>
		/// 权限
		/// </summary>
		public string Quanxian
		{
			set{ _quanxian=value;}
			get{return _quanxian;}
		}
		/// <summary>
		/// 昵称
		/// </summary>
		public string Username
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 全局ID
		/// </summary>
		public string Guid
		{
			set{ _guid=value;}
			get{return _guid;}
		}
		/// <summary>
		/// IP
		/// </summary>
		public string Ip
		{
			set{ _ip=value;}
			get{return _ip;}
		}
		/// <summary>
		/// 注册时间
		/// </summary>
		public DateTime? LoginTime
		{
			set{ _logintime=value;}
			get{return _logintime;}
		}
		#endregion Model

	}
}

