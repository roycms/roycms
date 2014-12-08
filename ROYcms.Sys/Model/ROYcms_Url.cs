using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
	/// 实体类ROYcms_Form 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
    public class ROYcms_Url
	{
        public ROYcms_Url()
        { }
        #region Model
        private int _id;
        private int? _bh;
        private string _url;
        private int? _isurl;
        private DateTime? _time;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? bh
        {
            set { _bh = value; }
            get { return _bh; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Url
        {
            set { _url = value; }
            get { return _url; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? isurl
        {
            set { _isurl = value; }
            get { return _isurl; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Time
        {
            set { _time = value; }
            get { return _time; }
        }
        #endregion Model

	}
}

