using System;
namespace ROYcms.Sys.Model
{
    /// <summary>
    /// 订单详情
    /// </summary>
    [Serializable]
    public partial class ROYcms_Goods_Order_Detail
    {
        public ROYcms_Goods_Order_Detail()
        { }
        #region Model
        private int _id;
        private string _order_id;
        private int? _goods_id;
        private string _goods_name;
        private string _goods_sn;
        private int? _goods_number;
        private int? _market_price;
        private int? _goods_price;
        private string _goods_attr;
        private int? _send_number;
        private int? _is_real;
        private string _extension_code;
        private int? _parent_id;
        private int? _is_gift;
        /// <summary>
        /// 编号
        /// </summary>
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 订单商品信息对应的详细信息id，取值order_info的order_id
        /// </summary>
        public string order_id
        {
            set { _order_id = value; }
            get { return _order_id; }
        }
        /// <summary>
        /// 商品的的id，取值表ecs_goods 的 goods_id 
        /// </summary>
        public int? goods_id
        {
            set { _goods_id = value; }
            get { return _goods_id; }
        }
        /// <summary>
        /// 商品的名称，取值表ecs_goods 
        /// </summary>
        public string goods_name
        {
            set { _goods_name = value; }
            get { return _goods_name; }
        }
        /// <summary>
        /// 商品的唯一货号，取值ecs_goods 
        /// </summary>
        public string goods_sn
        {
            set { _goods_sn = value; }
            get { return _goods_sn; }
        }
        /// <summary>
        /// 商品的购买数量
        /// </summary>
        public int? goods_number
        {
            set { _goods_number = value; }
            get { return _goods_number; }
        }
        /// <summary>
        /// 商品的市场售价，取值ecs_goods 
        /// </summary>
        public int? market_price
        {
            set { _market_price = value; }
            get { return _market_price; }
        }
        /// <summary>
        /// 商品的本店售价，取值ecs_goods 
        /// </summary>
        public int? goods_price
        {
            set { _goods_price = value; }
            get { return _goods_price; }
        }
        /// <summary>
        /// 购买该商品时所选择的属性；
        /// </summary>
        public string goods_attr
        {
            set { _goods_attr = value; }
            get { return _goods_attr; }
        }
        /// <summary>
        /// 是否已发货，0 ，否；1，是
        /// </summary>
        public int? send_number
        {
            set { _send_number = value; }
            get { return _send_number; }
        }
        /// <summary>
        /// 是否是实物
        /// </summary>
        public int? is_real
        {
            set { _is_real = value; }
            get { return _is_real; }
        }
        /// <summary>
        /// 商品的扩展属性，比如像虚拟卡
        /// </summary>
        public string extension_code
        {
            set { _extension_code = value; }
            get { return _extension_code; }
        }
        /// <summary>
        /// 父商品id，取值于ecs_cart的 parent_id；如果有该值则是值多代表的物品的配件
        /// </summary>
        public int? parent_id
        {
            set { _parent_id = value; }
            get { return _parent_id; }
        }
        /// <summary>
        /// 是参加的优惠活动的id
        /// </summary>
        public int? is_gift
        {
            set { _is_gift = value; }
            get { return _is_gift; }
        }
        #endregion Model

    }
}

