using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password.Entity
{
    /// <summary>
    /// 用户自定义字段实体类
    /// </summary>
    public class UserField
    {
        /// <summary>
        /// 自定义字段主键标识
        /// </summary>
        public int UserFieldID { get; set; }
        /// <summary>
        /// 代码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 数据类型
        /// </summary>
        public string DataType { get; set; }
        /// <summary>
        /// 排序标识
        /// </summary>
        public int SortID { get; set; }
        /// <summary>
        /// 唯一GUID
        /// </summary>
        public string Guid { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// 创建人GUID
        /// </summary>
        public string CreateUserGuid { get; set; }
        /// <summary>
        /// 更新日期
        /// </summary>
        public DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 更新人GUID
        /// </summary>
        public string UpdateUserGuid { get; set; }
        /// <summary>
        /// 是否为系统字段，0不是系统字段、1是系统字段
        /// </summary>
        public int SystemField { get; set; }
    }
}
