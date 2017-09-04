using Password.Entity;
using Password.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password.DAL
{
    public class FieldService : BaseService, Iservice<Field>
    {
        public FieldService(SendBackParameter sendBackParameter) : base(sendBackParameter) { }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int Add(List<Field> list)
        {
            return BaseAddOrDelete<Field>(databaseContext.Fields.AddRange, list);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int Delete(List<Field> list)
        {
            return BaseAddOrDelete<Field>(databaseContext.Fields.RemoveRange, list);
        }
        /// <summary>
        /// 加载
        /// </summary>
        /// <returns></returns>
        public List<Field> Load()
        {
            return BaseLoad<Field>(databaseContext.Fields.ToList);
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int Update(List<Field> list)
        {
            return BaseUpdate<Field>(() =>
            {
                foreach (var item in list)
                {
                    Field field = databaseContext.Fields.First(p => p.FieldID == item.FieldID);
                    field.UpdateDate = item.UpdateDate;
                    field.UpdateUserGuid = item.UpdateUserGuid;
                    field.SortID = item.SortID;
                }
            }, list);
        }
    }
}
