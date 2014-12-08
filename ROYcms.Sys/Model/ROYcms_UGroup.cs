using System;
using System.Collections.Generic;
using System.Text;

namespace ROYcms.Sys.Model
{
   public class ROYcms_UGroup
    {
        public ROYcms_UGroup()
        { }
        #region Model
        private int _id;
        private string _name;
        private string _zhaiyao;
        private string _roleid;
        private DateTime? _time;
        /// <summary>
        /// 编号
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 工作组名称
        /// </summary>
        public string name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 摘要或者描述
        /// </summary>
        public string zhaiyao
        {
            set { _zhaiyao = value; }
            get { return _zhaiyao; }
        }
        /// <summary>
        /// 权限ID
        /// </summary>
        public string RoleID
        {
            set { _roleid = value; }
            get { return _roleid; }
        }
        /// <summary>
        /// 时间
        /// </summary>
        public DateTime? Time
        {
            set { _time = value; }
            get { return _time; }
        }
        #endregion Model

    }
}
