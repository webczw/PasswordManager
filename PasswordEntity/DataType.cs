using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password.Entity
{
    /// <summary>
    /// 分类实体类
    /// </summary>
   public class DataType
    {
        /// <summary>
        /// 分类主键标识
        /// </summary>
        public int DataTypeID { get; set; }
        /// <summary>
        /// 唯一GUID
        /// </summary>
        public string Guid { get; set; }
        /// <summary>
        /// 代码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 父节点GUID
        /// </summary>
        public string ParentGuid { get; set; }
        /// <summary>
        /// 层级
        /// </summary>
        public int Level { get; set; }
        /// <summary>
        /// 排序ID
        /// </summary>
        public int SortID { get; set; }

        /// <summary>
        /// 是否系统数据
        /// </summary>
        public string IsSystem { get; set; }

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
