using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password.Entity
{
    /// <summary>
    /// 用户自定义字段值实体类
    /// </summary>
   public class UserFieldValue
    {
        /// <summary>
        /// 自定义字段值主键标识
        /// </summary>
        public int UserFieldValueID { get; set; }
        /// <summary>
        /// 自定义字段唯一标识GUID
        /// </summary>
        public string UserFieldGuid { get; set; }
        /// <summary>
        /// 自定义字段值
        /// </summary>
        public string FieldValue { get; set; }
        /// <summary>
        /// 唯一标识GUID
        /// </summary>
        public string Guid { get; set; }
        /// <summary>
        /// 内容唯一标识GUID
        /// </summary>
        public string ContentGuid { get; set; }
    }
}
