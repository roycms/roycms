using System;
namespace ROYcms.Sys.Model
{
    /// <summary>
    /// 用户等级扩展表 编号为1的用户等级为初始化数据，不能删除。该等级有对应用户，不能删除。删除等级时，删除对应的产品价格数据。
    ///
    /// </summary>
    [Serializable]
    public partial class ROYcms_UserGrade
    {
        public ROYcms_UserGrade()
        { }
        #region Model
        private int _id;
        private string _gradename;
        private int _isorder = 0;
        private string _remark;
        /// <summary>
        /// 编号
        /// </summary>
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 等级名称
        /// </summary>
        public string GradeName
        {
            set { _gradename = value; }
            get { return _gradename; }
        }
        /// <summary>
        /// 权重
        /// </summary>
        public int isOrder
        {
            set { _isorder = value; }
            get { return _isorder; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        #endregion Model

    }
}



