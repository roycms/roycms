using System;
namespace DNSABC.Model
{
	/// <summary>
	/// 用户接口数据表
	/// </summary>
	[Serializable]
	public partial class DNSABC_UserApi
	{
		public DNSABC_UserApi()
		{}
		#region Model
		private int _id;
		private int? _userid;
		private string _ip;
		private string _key;
		/// <summary>
		/// 编号
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 关联编号
		/// </summary>
		public int? UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 授权IP
		/// </summary>
		public string Ip
		{
			set{ _ip=value;}
			get{return _ip;}
		}
		/// <summary>
		/// Key密钥
		/// </summary>
		public string KEY
		{
			set{ _key=value;}
			get{return _key;}
		}
		#endregion Model

	}
}

