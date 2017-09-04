using Password.Entity;
using Password.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password.DAL
{
    public class UserFieldValueService : BaseService, Iservice<UserFieldValue>
    {
        public UserFieldValueService(SendBackParameter sendBackParameter) : base(sendBackParameter) { }
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int Add(List<UserFieldValue> list)
        {
            return BaseAddOrDelete<UserFieldValue>(databaseContext.UserFieldValues.AddRange, list);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int Delete(List<UserFieldValue> list)
        {
            return BaseAddOrDelete<UserFieldValue>(databaseContext.UserFieldValues.RemoveRange, list);
        }
        /// <summary>
        /// 加载
        /// </summary>
        /// <returns></returns>
        public List<UserFieldValue> Load()
        {
            return BaseLoad<UserFieldValue>(databaseContext.UserFieldValues.ToList);
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int Update(List<UserFieldValue> list)
        {
            return BaseUpdate<UserFieldValue>(() =>
            {
                foreach (var item in list)
                {
                    UserFieldValue userFieldValue = databaseContext.UserFieldValues.First(p => p.UserFieldValueID == item.UserFieldValueID);
                    userFieldValue.FieldValue = item.FieldValue;
                }
            }, list);
        }
    }
}
