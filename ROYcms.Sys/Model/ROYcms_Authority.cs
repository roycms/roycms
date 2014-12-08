using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// 主体信息和用户之间的访问权限控制表 主体信息和用户之间的访问权限控制表
	/// </summary>
	[Serializable]
	public partial class ROYcms_Authority
	{
		public ROYcms_Authority()
		{}
		#region Model
		private int _id;
		private int? _userid;
		private int? _groupid;
		private int? _rid;
		private int? _type;
		private DateTime? _startime;
		private DateTime? _endtime;
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
		public int? UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 用户组ID
		/// </summary>
		public int? GroupId
		{
			set{ _groupid=value;}
			get{return _groupid;}
		}
		/// <summary>
		/// 关联Id 对应文章表的bh或者其他模型的ID
		/// </summary>
		public int? Rid
		{
			set{ _rid=value;}
			get{return _rid;}
		}
		/// <summary>
		/// 关联编号 0是文章模型1是商品模型2下载模型3是图片模型
		/// </summary>
		public int? TYPE
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 开始时间
		/// </summary>
		public DateTime? StarTime
		{
			set{ _startime=value;}
			get{return _startime;}
		}
		/// <summary>
		/// 结束时间
		/// </summary>
		public DateTime? EndTime
		{
			set{ _endtime=value;}
			get{return _endtime;}
		}
		#endregion Model

	}
}

