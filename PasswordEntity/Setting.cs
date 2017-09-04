using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password.Entity
{
    /// <summary>
    /// 系统设置实体类
    /// </summary>
    public class Setting
    {
        /// <summary>
        /// 主键唯一标识
        /// </summary>
        public int SettingID { get; set; }
        /// <summary>
        /// 用户唯一标识
        /// </summary>
        public string UserGuid { get; set; }
        /// <summary>
        /// 系统设置代码
        /// </summary>
        public string SetCode { get; set; }
        /// <summary>
        /// 系统设置值
        /// </summary>
        public string SetValue { get; set; }
        /// <summary>
        /// 系统设置唯一标识
        /// </summary>
        public string Guid { get; set; }
        /// <summary>
        /// 更新日期
        /// </summary>
        public DateTime? UpdateDate { get; set; }
    }
}
