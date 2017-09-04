using Password.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Password.Interface;
using Password.Common;
using System.Reflection;
using System.Transactions;
namespace Password.DAL
{
    public class UserService : BaseService, Iservice<User>
    {
        public UserService(SendBackParameter sendBackParameter) : base(sendBackParameter) { }
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int Add(List<User> list)
        {
            return BaseAddOrDelete<User>(databaseContext.Users.AddRange, list);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int Delete(List<User> list)
        {
            return BaseAddOrDelete<User>(databaseContext.Users.RemoveRange, list);
        }
        /// <summary>
        /// 加载
        /// </summary>
        /// <returns></returns>
        public List<User> Load()
        {
            return BaseLoad<User>(databaseContext.Users.ToList);
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int Update(List<User> list)
        {
            return BaseUpdate<User>(() =>
            {
                foreach (var item in list)
                {
                    User user = databaseContext.Users.First(p => p.UserID == item.UserID);
                    user.LoginName = item.LoginName;
                    user.ChineseName = item.ChineseName;
                    user.Email = item.Email;
                    user.Sex = item.Sex;
                    user.IsAdmin = item.IsAdmin;
                    user.Remark = item.Remark;
                    user.Password = item.Password;
                    user.UpdateDate = item.UpdateDate;
                    user.UpdateUserGuid = item.UpdateUserGuid;
                }
            }, list);

            //int retVal = -1;
            //using (TransactionScope transaction = new TransactionScope())
            //{
            //    retVal=BaseAddOrDelete<User>(databaseContext.Users.RemoveRange, list);
            //    transaction.Complete();
            //}
            //return retVal;

        }

    }
}
