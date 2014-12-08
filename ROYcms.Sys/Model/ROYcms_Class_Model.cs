using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// 分类和模型表关系表 ROYcms_Class_Model 分类和模型表关系表 ROYcms_Class_Model
	/// </summary>
	[Serializable]
	public partial class ROYcms_Class_Model
	{
		public ROYcms_Class_Model()
		{}
		#region Model
		private int _id;
		private int? _mid;
		private int? _cid;
		private int? _uid;
		private int? _classid;
		private DateTime? _time= DateTime.Now;
		/// <summary>
		/// 编号 编号
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 模型表ID 模型表ID
		/// </summary>
		public int? Mid
		{
			set{ _mid=value;}
			get{return _mid;}
		}
		/// <summary>
		/// class分类表ID class分类表ID
		/// </summary>
		public int? Cid
		{
			set{ _cid=value;}
			get{return _cid;}
		}
		/// <summary>
		/// 用户表ID
		/// </summary>
		public int? Uid
		{
			set{ _uid=value;}
			get{return _uid;}
		}
		/// <summary>
		/// 分类表自身字段扩展时ID
		/// </summary>
		public int? ClassID
		{
			set{ _classid=value;}
			get{return _classid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? TIME
		{
			set{ _time=value;}
			get{return _time;}
		}
		#endregion Model

	}
}

