

using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace ROYcms.DB
{
    /// <summary>
    /// 
    /// </summary>
    public enum EffentNextType
    {
        /// <summary>
        /// 对其他语句无任何影响 
        /// </summary>
        None,
        /// <summary>
        /// 当前语句必须为"select count(1) from .."格式，如果存在则继续执行，不存在回滚事务
        /// </summary>
        WhenHaveContine,
        /// <summary>
        /// 当前语句必须为"select count(1) from .."格式，如果不存在则继续执行，存在回滚事务
        /// </summary>
        WhenNoHaveContine,
        /// <summary>
        /// 当前语句影响到的行数必须大于0，否则回滚事务
        /// </summary>
        ExcuteEffectRows,
        /// <summary>
        /// 引发事件-当前语句必须为"select count(1) from .."格式，如果不存在则继续执行，存在回滚事务
        /// </summary>
        SolicitationEvent
    }   
    /// <summary>
    /// 
    /// </summary>
    public class CommandInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public object ShareObject = null;
        /// <summary>
        /// 
        /// </summary>
        public object OriginalData = null;
        /// <summary>
        /// 
        /// </summary>
        event EventHandler _solicitationEvent;
        /// <summary>
        /// 
        /// </summary>
        public event EventHandler SolicitationEvent
        {
            add
            {
                _solicitationEvent += value;
            }
            remove
            {
                _solicitationEvent -= value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public void OnSolicitationEvent()
        {
            if (_solicitationEvent != null)
            {
                _solicitationEvent(this,new EventArgs());
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CommandText;
        /// <summary>
        /// 
        /// </summary>
        public System.Data.Common.DbParameter[] Parameters;
        /// <summary>
        /// 
        /// </summary>
        public EffentNextType EffentNextType = EffentNextType.None;
        /// <summary>
        /// 
        /// </summary>
        public CommandInfo()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlText"></param>
        /// <param name="para"></param>
        public CommandInfo(string sqlText, SqlParameter[] para)
        {
            this.CommandText = sqlText;
            this.Parameters = para;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlText"></param>
        /// <param name="para"></param>
        /// <param name="type"></param>
        public CommandInfo(string sqlText, SqlParameter[] para, EffentNextType type)
        {
            this.CommandText = sqlText;
            this.Parameters = para;
            this.EffentNextType = type;
        }
    }
}
