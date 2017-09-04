using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password.Entity
{
    /// <summary>
    /// 用户实体类
    /// </summary>
    public class User
    {
        /// <summary>
        /// 用户主键标识
        /// </summary>
        public int UserID { get; set; }
        /// <summary>
        /// 唯一GUID
        /// </summary>
        public string Guid { get; set; }
        /// <summary>
        /// 登录名
        /// </summary>
        public string LoginName { get; set; }
        /// <summary>
        /// 中文名称
        /// </summary>
        public string ChineseName { get; set; }
        /// <summary>
        /// 登陆密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 邮箱地址
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 性别，0男、1女
        /// </summary>
        public int Sex { get; set; }
        /// <summary>
        /// 是否管理员用户，0普通用户、1管理用户
        /// </summary>
        public int IsAdmin { get; set; }
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
