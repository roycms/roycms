using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// 附件表 附件表
	/// </summary>
	[Serializable]
	public partial class ROYcms_Appendix
	{
		public ROYcms_Appendix()
		{}
		#region Model
		private int _id;
		private int? _rid;
		private int? _type;
		private string _url;
		private string _title;
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
		/// 关联文章编号
		/// </summary>
		public int? Rid
		{
			set{ _rid=value;}
			get{return _rid;}
		}
		/// <summary>
		/// 附件类型 0为文章相册1为产品相册2为会员相册
		/// </summary>
		public int? TYPE
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 附件地址
		/// </summary>
		public string URL
		{
			set{ _url=value;}
			get{return _url;}
		}
		/// <summary>
		/// 附件描述说明
		/// </summary>
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
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

