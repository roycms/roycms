using System;
namespace ROYcms.Sys.Model
{
	/// <summary>
    /// 数据访问类ROYcms_Custom
	/// </summary>
	public class ROYcms_Custom
	{
        /// <summary>
        ///  数据表名称
        /// </summary>
        private string _TableName;
        /// <summary>
        ///  创建表的序列  列序列 例子：Id INTEGER,a1 VARCHAR(4000),a2 VARCHAR(4000)
        /// </summary>
        private string _Tablelist;
        /// <summary>
        /// 更新格式如下 a1=11,a2=22,a3=33
        /// </summary>
        private string _UpdateList;
        /// <summary>
        /// 值顺序 例如：var1,var2
        /// </summary>
        private string _InsertList;
        /// <summary>
        /// 字段顺序 例如：a1,a2
        /// </summary>
        private string _Tlist;
        /// <summary>
        /// 新闻信息ID表示对应ROYcms_news的id字段
        /// </summary>
        private int _newid;
        /// <summary>
        /// 分类ID
        /// </summary>
        private int _Cid;
        /// <summary>
        ///   数据表名称
        /// </summary>
        public string TableName
        {
            set { _TableName = value; }
            get { return _TableName; }
        }
        /// <summary>
        ///  创建表的序列  列序列 例子：Id INTEGER,a1 VARCHAR(4000),a2 VARCHAR(4000)
        /// </summary>
        public string Tablelist
        {
            set { _Tablelist = value; }
            get { return _Tablelist; }
        }
        /// <summary>
        /// 更新格式如下 a1=11,a2=22,a3=33
        /// </summary>
        public string UpdateList
        {
            set { _UpdateList = value; }
            get { return _UpdateList; }
        }
        /// <summary>
        /// 值顺序 例如：var1,var2
        /// </summary>
        public string InsertList
        {
            set { _InsertList = value; }
            get { return _InsertList; }
        }
        /// <summary>
        /// 字段顺序 例如：a1,a2
        /// </summary>
        public string Tlist
        {
            set { _Tlist = value; }
            get { return _Tlist; }
        }
        /// <summary>
        /// 新闻信息ID表示对应ROYcms_news的id字段
        /// </summary>
        public int newid
        {
            set { _newid = value; }
            get { return _newid; }
        }
        /// <summary>
        /// 分类ID
        /// </summary>
        public int Cid
        {
            set { _Cid = value; }
            get { return _Cid; }
        }
	}
}

