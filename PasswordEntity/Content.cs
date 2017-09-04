using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password.Entity
{
    /// <summary>
    /// 内容实体类
    /// </summary>
    public class Content
    {
        /// <summary>
        /// 分类主键标识
        /// </summary>
        public int ContentID { get; set; }
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
        public string Title { get; set; }
        /// <summary>
        ///地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public string CreateUserGuid { get; set; }
        /// <summary>
        /// 最后更新日期
        /// </summary>
        public DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 最后更新人
        /// </summary>
        public string UpdateUserGuid { get; set; }
        /// <summary>
        /// 所属分类
        /// </summary>
        public string DataTypeGuid { get; set; }
    }
}
