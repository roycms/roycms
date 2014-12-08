using System;
namespace ROYcms.Sys.Model
{
    /// <summary>
    /// 商品品牌表
    /// </summary>
    [Serializable]
    public partial class ROYcms_Goods_Brand
    {
        public ROYcms_Goods_Brand()
        { }
        #region Model
        private int _id;
        private string _name;
        private string _logo;
        private string _brand_desc;
        private string _site_url;
        private int? _sort_order;
        private int? _is_show;
        private DateTime? _time;
        /// <summary>
        /// 编号
        /// </summary>
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 品牌名称 品牌名称
        /// </summary>
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 品牌Logo 品牌Logo
        /// </summary>
        public string Logo
        {
            set { _logo = value; }
            get { return _logo; }
        }
        /// <summary>
        /// 品牌介绍 品牌介绍
        /// </summary>
        public string brand_desc
        {
            set { _brand_desc = value; }
            get { return _brand_desc; }
        }
        /// <summary>
        /// 网址 网址
        /// </summary>
        public string site_url
        {
            set { _site_url = value; }
            get { return _site_url; }
        }
        /// <summary>
        /// 排序字段 品牌在前台页面的显示顺序，数字越大越靠后 
        /// </summary>
        public int? sort_order
        {
            set { _sort_order = value; }
            get { return _sort_order; }
        }
        /// <summary>
        /// 是否前端显示 该品牌是否显示，0，否；1，显示
        /// </summary>
        public int? is_show
        {
            set { _is_show = value; }
            get { return _is_show; }
        }
        /// <summary>
        /// 时间
        /// </summary>
        public DateTime? TIME
        {
            set { _time = value; }
            get { return _time; }
        }
        #endregion Model

    }
}

