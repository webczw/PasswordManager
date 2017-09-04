using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password.Entity
{
    /// <summary>
    /// 日志实体类
    /// </summary>
    public class Log
    {
        /// <summary>
        /// 日志主键标识
        /// </summary>
        public int LogID { get; set; }
        /// <summary>
        /// 日期
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// 级别
        /// </summary>
        public string Level { get; set; }
        /// <summary>
        /// 记录位置
        /// </summary>
        public string Logger { get; set; }
        ///// <summary>
        ///// 消息
        ///// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserID { get; set; }
        /// <summary>
        /// 位置
        /// </summary>
        public string Location { get; set; }
        /// <summary>
        /// 异常
        /// </summary>
        public string Exception { get; set; }
    }
}
