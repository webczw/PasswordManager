using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password.Entity
{
    /// <summary>
    /// 栏位实体类
    /// </summary>
    public class Field
    {
        /// <summary>
        /// 自定义字段主键标识
        /// </summary>
        public int FieldID { get; set; }
        /// <summary>
        /// 代码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 用户自定义字段GUID
        /// </summary>
        public string UserFieldsGuid { get; set; }
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
    }
}
