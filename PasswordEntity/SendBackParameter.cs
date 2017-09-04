using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password.Entity
{
    /// <summary>
    /// 客户端向后台传递参数对象 
    /// </summary>
   public class SendBackParameter
    {
        public SendBackParameter(User userInfo) {
            this.UserInfo = userInfo;
        }
        /// <summary>
        /// 用户信息
        /// </summary>
        public User UserInfo {private set; get; }
    }
}
