using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// 权限表
	/// </summary>
	[Serializable]
	public partial class ROYcms_Jurisdiction
	{
		public ROYcms_Jurisdiction()
		{}
		#region Model
		private int _id;
		private string _jid;
		private int? _adminid;
		private int? _classid;
		private string _classkind;
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
		/// 权限编号
		/// </summary>
		public string JID
		{
			set{ _jid=value;}
			get{return _jid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? AdminID
		{
			set{ _adminid=value;}
			get{return _adminid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ClassID
		{
			set{ _classid=value;}
			get{return _classid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ClassKind
		{
			set{ _classkind=value;}
			get{return _classkind;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		#endregion Model

	}
}

