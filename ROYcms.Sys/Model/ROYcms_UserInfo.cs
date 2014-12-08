using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// 用户信息扩展表
	/// </summary>
	[Serializable]
	public partial class ROYcms_UserInfo
	{
		public ROYcms_UserInfo()
		{}
		#region Model
		private int _id;
		private int _userid;
		private int _accountbalance=0;
		private int _avilablebalance=0;
		private int _consumedamount=0;
		private int _money=0;
		private int _gradeid=1;
		private int _state=1;
		private string _realname;
		private int? _qq;
		private string _mobil;
		private string _tel;
		private string _address;
		private string _postcode;
		private string _website;
		private string _idcardnum;
		private int? _accounttype;
		private int _siteid=0;
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
		/// 账户余额
		/// </summary>
		public int AccountBalance
		{
			set{ _accountbalance=value;}
			get{return _accountbalance;}
		}
		/// <summary>
		/// 可用余额
		/// </summary>
		public int AvilableBalance
		{
			set{ _avilablebalance=value;}
			get{return _avilablebalance;}
		}
		/// <summary>
		/// 已经消费金额
		/// </summary>
		public int ConsumedAmount
		{
			set{ _consumedamount=value;}
			get{return _consumedamount;}
		}
		/// <summary>
		/// 积分
		/// </summary>
		public int Money
		{
			set{ _money=value;}
			get{return _money;}
		}
		/// <summary>
		/// 用户等级ID 默认值1，表示普通用户
		/// </summary>
		public int GradeID
		{
			set{ _gradeid=value;}
			get{return _gradeid;}
		}
		/// <summary>
		/// 有效状态 0为停用，1为启用；停用的产品不能解析
		/// </summary>
		public int State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 联系人姓名
		/// </summary>
		public string RealName
		{
			set{ _realname=value;}
			get{return _realname;}
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
		/// 联系人手机
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
		/// 地址
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 邮编
		/// </summary>
		public string Postcode
		{
			set{ _postcode=value;}
			get{return _postcode;}
		}
		/// <summary>
		/// 网站
		/// </summary>
		public string Website
		{
			set{ _website=value;}
			get{return _website;}
		}
		/// <summary>
		/// 身份证号码
		/// </summary>
		public string IDcardNum
		{
			set{ _idcardnum=value;}
			get{return _idcardnum;}
		}
		/// <summary>
		/// 账户类型 企业则对应企业信息表
		/// </summary>
		public int? AccountType
		{
			set{ _accounttype=value;}
			get{return _accounttype;}
		}
		/// <summary>
		/// 站点ID 0为主站 大于0为站点编号
		/// </summary>
		public int SiteID
		{
			set{ _siteid=value;}
			get{return _siteid;}
		}
		#endregion Model

	}
}

