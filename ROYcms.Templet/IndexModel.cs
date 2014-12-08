using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace ROYcms.Templet
{
    public class IndexModel
    {
        #region IndexModel
        private string _DoMain;
        private string _index;
        private int _id;
        private int _type;
        private int _page;
        private int _classkind;
        /// <summary>
        /// 
        /// </summary>
        public string DoMain
        {
            set { _DoMain = value; }
            get { return _DoMain; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string index
        {
            set { _index = value; }
            get { return _index; }
        }
        /// <summary>
        /// 文章编号
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 频道编号
        /// </summary>
        public int type
        {
            set { _type = value; }
            get { return _type; }
        }
        /// <summary>
        /// 页码
        /// </summary>
        public int page
        {
            set { _page = value; }
            get { return _page; }
        }
        /// <summary>
        /// 全局标识
        /// </summary>
        public int classkind
        {
            set { _classkind = value; }
            get { return _classkind; }
        }
        #endregion Model
    }
}
