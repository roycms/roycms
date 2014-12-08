using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// 管理员操作权限表
	/// </summary>
	[Serializable]
	public partial class ROYcms_Admin_Map
	{
		public ROYcms_Admin_Map()
		{}
		#region Model
		private int _id;
		private int? _rid;
		private int? _adminid;
		/// <summary>
		/// 编号
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 关联编号 关联ROYcms_AdminUrlMap的ID
		/// </summary>
		public int? Rid
		{
			set{ _rid=value;}
			get{return _rid;}
		}
		/// <summary>
		/// 管理员Id
		/// </summary>
		public int? AdminId
		{
			set{ _adminid=value;}
			get{return _adminid;}
		}
		#endregion Model

	}
}

