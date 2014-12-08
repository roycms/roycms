using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// 实体类ROYcms_UGroup_Workflow 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ROYcms_UGroup_Workflow
	{
		public ROYcms_UGroup_Workflow()
		{}
		#region Model
		private int _id;
		private int? _ugroup_id;
		private int? _workflow_id;
		private DateTime? _time;
		/// <summary>
		/// 编号
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 工作组ID
		/// </summary>
		public int? UGroup_id
		{
			set{ _ugroup_id=value;}
			get{return _ugroup_id;}
		}
		/// <summary>
		/// 权限ID
		/// </summary>
		public int? Workflow_id
		{
			set{ _workflow_id=value;}
			get{return _workflow_id;}
		}
		/// <summary>
		/// 时间
		/// </summary>
		public DateTime? Time
		{
			set{ _time=value;}
			get{return _time;}
		}
		#endregion Model

	}
}

