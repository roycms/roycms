using System;
namespace DNSABC.Model
{
	/// <summary>
	/// 产品信息表 添加产品的时候需要添加用户等级ID为1的价格信息（0元/月）。删除产品的时候需要删除对应的价格信息和产品扩展信息。
	///添加产品的时候需要添加对应类型的产品扩展信息。删除产品的时候，如果改产品有业务和有订单不能删除。
	/// </summary>
	[Serializable]
	public partial class DNSABC_ProductInfo
	{
		public DNSABC_ProductInfo()
		{}
		#region Model
		private int _id;
		private int _producttype;
		private string _productname;
		private string _productpic= "200";
		private string _productdescription;
		private string _producttablename;
		private int _month=1;
		private int _state=1;
		private int _isorder=0;
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
		/// 产品类型 1，DNS，ProductModelDns；2，CDN，ProductModelCdn。
		/// </summary>
		public int ProductType
		{
			set{ _producttype=value;}
			get{return _producttype;}
		}
		/// <summary>
		/// 名称
		/// </summary>
		public string ProductName
		{
			set{ _productname=value;}
			get{return _productname;}
		}
		/// <summary>
		/// 产品图片
		/// </summary>
		public string ProductPic
		{
			set{ _productpic=value;}
			get{return _productpic;}
		}
		/// <summary>
		/// 产品描述 编辑器区域
		/// </summary>
		public string ProductDescription
		{
			set{ _productdescription=value;}
			get{return _productdescription;}
		}
		/// <summary>
		/// 模型的表格名称 ProductModelDns或者ProductModelCdn
		/// </summary>
		public string ProductTableName
		{
			set{ _producttablename=value;}
			get{return _producttablename;}
		}
		/// <summary>
		/// 月数 产品默认订购时限
		/// </summary>
		public int MONTH
		{
			set{ _month=value;}
			get{return _month;}
		}
		/// <summary>
		/// 产品状态 0为停用，1为启用；停用的产品不能购买，前台不展示
		/// </summary>
		public int State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 权重
		/// </summary>
		public int isOrder
		{
			set{ _isorder=value;}
			get{return _isorder;}
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

