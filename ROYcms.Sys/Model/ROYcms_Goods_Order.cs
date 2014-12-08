using System;
namespace ROYcms.Sys.Model
{
    /// <summary>
    /// 订单表
    /// </summary>
    [Serializable]
    public partial class ROYcms_Goods_Order
    {
        public ROYcms_Goods_Order()
        { }
        #region Model
        private int _id;
        private string _order_sn;
        private int? _user_id;
        private int? _order_status;
        private int? _shipping_status;
        private int? _pay_status;
        private string _consignee;
        private string _country;
        private string _province;
        private string _city;
        private string _district;
        private string _address;
        private string _zipcode;
        private string _tel;
        private string _mobile;
        private string _email;
        private int? _best_time;
        private string _sign_building;
        private string _postscript;
        private int? _shipping_id;
        private string _shipping_name;
        private int? _pay_id;
        private string _pay_name;
        private int? _how_oos;
        private int? _how_surplus;
        private string _pack_name;
        private string _card_name;
        private string _card_message;
        private string _inv_payee;
        private string _inv_content;
        private int? _goods_amount;
        private string _shipping_fee;
        private int? _insure_fee;
        private string _pay_fee;
        private string _pack_fee;
        private string _card_fee;
        private int? _money_paid;
        private string _surplus;
        private int? _integeregral;
        private int? _integeregral_money;
        private int? _bonus;
        private int? _order_amount;
        private int? _from_ad;
        private string _referer;
        private DateTime? _add_time;
        private DateTime? _confirm_time;
        private DateTime? _pay_time;
        private DateTime? _shipping_time;
        private int? _pack_id;
        private int? _card_id;
        private int? _bonus_id;
        private string _invoice_no;
        private int? _extension_code;
        private int? _extension_id;
        private string _to_buyer;
        private string _pay_note;
        private int? _agency_id;
        private string _inv_type;
        private string _tax;
        private int? _is_separate;
        private int? _parent_id;
        private string _discount;
        /// <summary>
        /// 订单详细信息自增id,
        /// </summary>
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 订单号，唯一,
        /// </summary>
        public string order_sn
        {
            set { _order_sn = value; }
            get { return _order_sn; }
        }
        /// <summary>
        /// 用户id，同ecs_users的user_id,
        /// </summary>
        public int? user_id
        {
            set { _user_id = value; }
            get { return _user_id; }
        }
        /// <summary>
        /// 订单状态。0，未确认；1，已确认；2，已取消；3，无效；4，退货；,
        /// </summary>
        public int? order_status
        {
            set { _order_status = value; }
            get { return _order_status; }
        }
        /// <summary>
        /// 商品配送情况，0，未发货；1，已发货；2，已收货；3，备货中,
        /// </summary>
        public int? shipping_status
        {
            set { _shipping_status = value; }
            get { return _shipping_status; }
        }
        /// <summary>
        /// 支付状态；0，未付款；1，付款中；2，已付款,
        /// </summary>
        public int? pay_status
        {
            set { _pay_status = value; }
            get { return _pay_status; }
        }
        /// <summary>
        /// 收货人的姓名，用户页面填写，默认取值于表user_address,
        /// </summary>
        public string consignee
        {
            set { _consignee = value; }
            get { return _consignee; }
        }
        /// <summary>
        /// 收货人的国家，用户页面填写，默认取值于表user_address，其id对应的值在ecs_region,
        /// </summary>
        public string country
        {
            set { _country = value; }
            get { return _country; }
        }
        /// <summary>
        /// 收货人的省份，用户页面填写，默认取值于表user_address，其id对应的值在ecs_region,
        /// </summary>
        public string province
        {
            set { _province = value; }
            get { return _province; }
        }
        /// <summary>
        /// 收货人的城市，用户页面填写，默认取值于表user_address，其id对应的值在ecs_region,
        /// </summary>
        public string city
        {
            set { _city = value; }
            get { return _city; }
        }
        /// <summary>
        /// 收货人的地区，用户页面填写，默认取值于表user_address，其id对应的值在ecs_region,
        /// </summary>
        public string district
        {
            set { _district = value; }
            get { return _district; }
        }
        /// <summary>
        /// 收货人的详细地址，用户页面填写，默认取值于表user_address,
        /// </summary>
        public string address
        {
            set { _address = value; }
            get { return _address; }
        }
        /// <summary>
        /// 收货人的邮编，用户页面填写，默认取值于表user_address,
        /// </summary>
        public string zipcode
        {
            set { _zipcode = value; }
            get { return _zipcode; }
        }
        /// <summary>
        /// 收货人的电话，用户页面填写，默认取值于表user_address,
        /// </summary>
        public string tel
        {
            set { _tel = value; }
            get { return _tel; }
        }
        /// <summary>
        /// 收货人的手机，用户页面填写，默认取值于表user_address,
        /// </summary>
        public string mobile
        {
            set { _mobile = value; }
            get { return _mobile; }
        }
        /// <summary>
        ///  收货人的手机，用户页面填写，默认取值于表user_address,
        /// </summary>
        public string email
        {
            set { _email = value; }
            get { return _email; }
        }
        /// <summary>
        ///  收货人的最佳送货时间，用户页面填写，默认取值于表user_address,
        /// </summary>
        public int? best_time
        {
            set { _best_time = value; }
            get { return _best_time; }
        }
        /// <summary>
        ///  收货人的地址的标志性建筑，用户页面填写，默认取值于表user_address,
        /// </summary>
        public string sign_building
        {
            set { _sign_building = value; }
            get { return _sign_building; }
        }
        /// <summary>
        /// 订单附言，由用户提交订单前填写,
        /// </summary>
        public string postscript
        {
            set { _postscript = value; }
            get { return _postscript; }
        }
        /// <summary>
        /// 用户选择的配送方式id，取值表ecs_shipping,
        /// </summary>
        public int? shipping_id
        {
            set { _shipping_id = value; }
            get { return _shipping_id; }
        }
        /// <summary>
        /// 用户选择的配送方式的名称，取值表ecs_shipping,
        /// </summary>
        public string shipping_name
        {
            set { _shipping_name = value; }
            get { return _shipping_name; }
        }
        /// <summary>
        /// 用户选择的支付方式的id，取值表ecs_payment,
        /// </summary>
        public int? pay_id
        {
            set { _pay_id = value; }
            get { return _pay_id; }
        }
        /// <summary>
        /// 用户选择的支付方式的名称，取值表ecs_payment,
        /// </summary>
        public string pay_name
        {
            set { _pay_name = value; }
            get { return _pay_name; }
        }
        /// <summary>
        /// 缺货处理方式，等待所有商品备齐后再发； 取消订单；与店主协商,
        /// </summary>
        public int? how_oos
        {
            set { _how_oos = value; }
            get { return _how_oos; }
        }
        /// <summary>
        /// 根据字段猜测应该是余额处理方式，程序未作这部分实现,
        /// </summary>
        public int? how_surplus
        {
            set { _how_surplus = value; }
            get { return _how_surplus; }
        }
        /// <summary>
        /// 包装名称，取值表ecs_pack,
        /// </summary>
        public string pack_name
        {
            set { _pack_name = value; }
            get { return _pack_name; }
        }
        /// <summary>
        /// 贺卡的名称，取值ecs_card ,
        /// </summary>
        public string card_name
        {
            set { _card_name = value; }
            get { return _card_name; }
        }
        /// <summary>
        /// 贺卡内容，由用户提交,
        /// </summary>
        public string card_message
        {
            set { _card_message = value; }
            get { return _card_message; }
        }
        /// <summary>
        /// 发票抬头，用户页面填写,
        /// </summary>
        public string inv_payee
        {
            set { _inv_payee = value; }
            get { return _inv_payee; }
        }
        /// <summary>
        /// 发票内容，用户页面选择，取值ecs_shop_config的code字段的值为invoice_content的value,
        /// </summary>
        public string inv_content
        {
            set { _inv_content = value; }
            get { return _inv_content; }
        }
        /// <summary>
        /// 商品总金额,
        /// </summary>
        public int? goods_amount
        {
            set { _goods_amount = value; }
            get { return _goods_amount; }
        }
        /// <summary>
        /// 配送费用,
        /// </summary>
        public string shipping_fee
        {
            set { _shipping_fee = value; }
            get { return _shipping_fee; }
        }
        /// <summary>
        /// 保价费用,
        /// </summary>
        public int? insure_fee
        {
            set { _insure_fee = value; }
            get { return _insure_fee; }
        }
        /// <summary>
        /// 支付费用,跟支付方式的配置相关，取值表ecs_payment,
        /// </summary>
        public string pay_fee
        {
            set { _pay_fee = value; }
            get { return _pay_fee; }
        }
        /// <summary>
        /// 包装费用，取值表取值表ecs_pack,
        /// </summary>
        public string pack_fee
        {
            set { _pack_fee = value; }
            get { return _pack_fee; }
        }
        /// <summary>
        ///  贺卡费用，取值ecs_card ,
        /// </summary>
        public string card_fee
        {
            set { _card_fee = value; }
            get { return _card_fee; }
        }
        /// <summary>
        /// 已付款金额,
        /// </summary>
        public int? money_paid
        {
            set { _money_paid = value; }
            get { return _money_paid; }
        }
        /// <summary>
        /// 该订单使用余额的数量，取用户设定余额，用户可用余额，订单金额中最小者,
        /// </summary>
        public string surplus
        {
            set { _surplus = value; }
            get { return _surplus; }
        }
        /// <summary>
        /// 使用的积分的数量，取用户使用积分，商品可用积分，用户拥有积分中最小者,
        /// </summary>
        public int? Integeregral
        {
            set { _integeregral = value; }
            get { return _integeregral; }
        }
        /// <summary>
        /// 使用积分金额,
        /// </summary>
        public int? Integeregral_money
        {
            set { _integeregral_money = value; }
            get { return _integeregral_money; }
        }
        /// <summary>
        /// 使用红包金额,
        /// </summary>
        public int? bonus
        {
            set { _bonus = value; }
            get { return _bonus; }
        }
        /// <summary>
        /// 应付款金额,
        /// </summary>
        public int? order_amount
        {
            set { _order_amount = value; }
            get { return _order_amount; }
        }
        /// <summary>
        /// 订单由某广告带来的广告id，应该取值于ecs_ad,
        /// </summary>
        public int? from_ad
        {
            set { _from_ad = value; }
            get { return _from_ad; }
        }
        /// <summary>
        /// 订单的来源页面,
        /// </summary>
        public string referer
        {
            set { _referer = value; }
            get { return _referer; }
        }
        /// <summary>
        /// 订单生成时间,
        /// </summary>
        public DateTime? add_time
        {
            set { _add_time = value; }
            get { return _add_time; }
        }
        /// <summary>
        /// 订单确认时间,
        /// </summary>
        public DateTime? confirm_time
        {
            set { _confirm_time = value; }
            get { return _confirm_time; }
        }
        /// <summary>
        /// 订单支付时间,
        /// </summary>
        public DateTime? pay_time
        {
            set { _pay_time = value; }
            get { return _pay_time; }
        }
        /// <summary>
        /// 订单配送时间,
        /// </summary>
        public DateTime? shipping_time
        {
            set { _shipping_time = value; }
            get { return _shipping_time; }
        }
        /// <summary>
        /// 包装id，取值取值表ecs_pack,
        /// </summary>
        public int? pack_id
        {
            set { _pack_id = value; }
            get { return _pack_id; }
        }
        /// <summary>
        /// 贺卡id，用户在页面选择，取值取值ecs_card ,
        /// </summary>
        public int? card_id
        {
            set { _card_id = value; }
            get { return _card_id; }
        }
        /// <summary>
        /// 红包的id，ecs_user_bonus的bonus_id,
        /// </summary>
        public int? bonus_id
        {
            set { _bonus_id = value; }
            get { return _bonus_id; }
        }
        /// <summary>
        ///  发货单号，发货时填写，可在订单查询查看,
        /// </summary>
        public string invoice_no
        {
            set { _invoice_no = value; }
            get { return _invoice_no; }
        }
        /// <summary>
        ///  通过活动购买的商品的代号；GROUP_BUY是团购；AUCTION，是拍卖；SNATCH，夺宝奇兵；正常普通产品该处为空,
        /// </summary>
        public int? extension_code
        {
            set { _extension_code = value; }
            get { return _extension_code; }
        }
        /// <summary>
        /// 通过活动购买的物品的id，取值ecs_goods_activity；如果是正常普通商品，该处为0,
        /// </summary>
        public int? extension_id
        {
            set { _extension_id = value; }
            get { return _extension_id; }
        }
        /// <summary>
        ///  商家给客户的留言,当该字段有值时可以在订单查询看到,
        /// </summary>
        public string to_buyer
        {
            set { _to_buyer = value; }
            get { return _to_buyer; }
        }
        /// <summary>
        ///  付款备注，在订单管理里编辑修改,
        /// </summary>
        public string pay_note
        {
            set { _pay_note = value; }
            get { return _pay_note; }
        }
        /// <summary>
        ///  该笔订单被指派给的办事处的id，根据订单内容和办事处负责范围自动决定，也可以有管理员修改，取值于表ecs_agency,
        /// </summary>
        public int? agency_id
        {
            set { _agency_id = value; }
            get { return _agency_id; }
        }
        /// <summary>
        ///  发票类型，用户页面选择，取值ecs_shop_config的code字段的值为invoice_type的value,
        /// </summary>
        public string inv_type
        {
            set { _inv_type = value; }
            get { return _inv_type; }
        }
        /// <summary>
        ///  发票税额,
        /// </summary>
        public string tax
        {
            set { _tax = value; }
            get { return _tax; }
        }
        /// <summary>
        /// 0，未分成或等待分成；1，已分成；2，取消分成；,
        /// </summary>
        public int? is_separate
        {
            set { _is_separate = value; }
            get { return _is_separate; }
        }
        /// <summary>
        /// 能获得推荐分成的用户id，id取值于表ecs_users,
        /// </summary>
        public int? parent_id
        {
            set { _parent_id = value; }
            get { return _parent_id; }
        }
        /// <summary>
        ///  折扣金额,
        /// </summary>
        public string discount
        {
            set { _discount = value; }
            get { return _discount; }
        }
        #endregion Model

    }
}

