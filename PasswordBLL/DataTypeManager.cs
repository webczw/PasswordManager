using Password.Common;
using Password.Entity;
using Password.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Password.BLL
{
    public class DataTypeManager : BaseManager, Imanager<DataType>
    {
        Iservice<DataType> service;
        public DataTypeManager(SendBackParameter sendBackParameter) : base(sendBackParameter)
        {
            if (service == null)
            {
                service = Tools.DynamicCreateClass<Iservice<DataType>>("DataTypeService", this.sendBackParameter);
                if (service == null)
                {
                    Logger.Error("创建分类服务类实例异常。", MethodBase.GetCurrentMethod(), this.sendBackParameter);//记录日志
                }
            }
        }

        public int Add(List<DataType> list)
        {
            if (list == null || list.Count < 1) return 0;
            return service.Add(list);
        }

        public int Delete(List<DataType> list)
        {
            if (list == null || list.Count < 1) return 0;
            return service.Delete(list);
        }

        public List<DataType> Load()
        {
            return service.Load();
        }

        public int Update(List<DataType> list)
        {
            if (list == null || list.Count < 1) return 0;
            return service.Update(list);
        }
        
    }
}
