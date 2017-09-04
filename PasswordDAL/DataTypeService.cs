using Password.Common;
using Password.Entity;
using Password.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Password.DAL
{
    public class DataTypeService : BaseService, Iservice<DataType>
    {
        public DataTypeService(SendBackParameter sendBackParameter) : base(sendBackParameter) { }
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int Add(List<DataType> list)
        {
            return BaseAddOrDelete<DataType>(databaseContext.DataTypes.AddRange, list);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int Delete(List<DataType> list)
        {
            return BaseAddOrDelete<DataType>(databaseContext.DataTypes.RemoveRange, list);
        }
        /// <summary>
        /// 加载
        /// </summary>
        /// <returns></returns>
        public List<DataType> Load()
        {
            return BaseLoad<DataType>(databaseContext.DataTypes.ToList);
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int Update(List<DataType> list)
        {
            return BaseUpdate<DataType>(() =>
            {
                foreach (var item in list)
                {
                    DataType dataType = databaseContext.DataTypes.First(p => p.DataTypeID == item.DataTypeID);
                    dataType.Code = item.Code;
                    dataType.Name = item.Name;
                    dataType.SortID = item.SortID;
                    dataType.UpdateDate = item.UpdateDate;
                    dataType.UpdateUserGuid = item.UpdateUserGuid;
                }
            }, list);
        }
    }
}
