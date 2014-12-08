using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// 数据模型表 ROYcms_Model 数据模型表 ROYcms_Model
	/// </summary>
	[Serializable]
	public partial class ROYcms_Model
	{
		public ROYcms_Model()
		{}
		#region Model
		private int _id;
		private int? _modeltype;
		private string _name;
		private string _tablename;
		private string _modeldescription;
		private DateTime? _time= DateTime.Now;
		/// <summary>
		/// 编号 时间
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 模型应用行业分类 模型应用行业分类
		/// </summary>
		public int? ModelType
		{
			set{ _modeltype=value;}
			get{return _modeltype;}
		}
		/// <summary>
		/// 模型名称 模型名称
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 模型创建的数据库表的名称 模型创建的数据库表的名称
		/// </summary>
		public string TableName
		{
			set{ _tablename=value;}
			get{return _tablename;}
		}
		/// <summary>
		/// 模型描述说明 模型描述说明
		/// </summary>
		public string ModelDescription
		{
			set{ _modeldescription=value;}
			get{return _modeldescription;}
		}
		/// <summary>
		/// 时间 时间
		/// </summary>
		public DateTime? TIME
		{
			set{ _time=value;}
			get{return _time;}
		}
		#endregion Model

	}
}

