using System;
namespace DNSABC.Model
{
	/// <summary>
	/// 用户联系人表
	/// </summary>
	[Serializable]
	public partial class DNSABC_UserPerson
	{
		public DNSABC_UserPerson()
		{}
		#region Model
		private int _id;
		private int _userid;
		private string _name;
		private string _position;
		private string _mobil;
		private string _tel;
		private int? _qq;
		private string _email;
		private string _remark;
		private DateTime? _updatetime;
		private DateTime? _createtime;
		/// <summary>
		/// 编号
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 用户ID
		/// </summary>
		public int UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 姓名
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 职位
		/// </summary>
		public string Position
		{
			set{ _position=value;}
			get{return _position;}
		}
		/// <summary>
		/// 手机 必须要有联系人手机号码
		/// </summary>
		public string Mobil
		{
			set{ _mobil=value;}
			get{return _mobil;}
		}
		/// <summary>
		/// 电话
		/// </summary>
		public string Tel
		{
			set{ _tel=value;}
			get{return _tel;}
		}
		/// <summary>
		/// QQ号码
		/// </summary>
		public int? Qq
		{
			set{ _qq=value;}
			get{return _qq;}
		}
		/// <summary>
		/// 邮箱
		/// </summary>
		public string Email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 更新时间
		/// </summary>
		public DateTime? UpdateTime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		#endregion Model

	}
}

