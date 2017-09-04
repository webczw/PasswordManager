using Password.Entity;
using Password.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password.DAL
{
    public class UserFieldService : BaseService, Iservice<UserField>
    {
        public UserFieldService(SendBackParameter sendBackParameter) : base(sendBackParameter) { }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int Add(List<UserField> list)
        {
            return BaseAddOrDelete<UserField>(databaseContext.UserFields.AddRange, list);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int Delete(List<UserField> list)
        {
            return BaseAddOrDelete<UserField>(databaseContext.UserFields.RemoveRange, list);
        }
        /// <summary>
        /// 加载
        /// </summary>
        /// <returns></returns>
        public List<UserField> Load()
        {
            return BaseLoad<UserField>(databaseContext.UserFields.ToList);
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int Update(List<UserField> list)
        {
            return BaseUpdate<UserField>(() =>
            {
                foreach (var item in list)
                {
                    UserField userField = databaseContext.UserFields.First(p => p.UserFieldID == item.UserFieldID);
                    userField.Code = item.Code;
                    userField.Name = item.Name;
                    userField.DataType = item.DataType;
                    userField.UpdateDate = item.UpdateDate;
                    userField.UpdateUserGuid = item.UpdateUserGuid;
                    userField.SortID = item.SortID;
                }
            }, list);
        }
        
    }
}
