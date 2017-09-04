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
    public class UserFieldManager : BaseManager, Imanager<UserField>
    {
        Iservice<UserField> service;
        public UserFieldManager(SendBackParameter sendBackParameter) : base(sendBackParameter)
        {
            if (service == null)
            {
                service = Tools.DynamicCreateClass<Iservice<UserField>>("UserFieldService", this.sendBackParameter);
                if (service == null)
                {
                    Logger.Error("创建用户自定义字段服务类实例异常。", MethodBase.GetCurrentMethod(), this.sendBackParameter);//记录日志
                }
            }
        }
        public int Add(List<UserField> list)
        {
            if (list == null || list.Count < 1) return 0;
            return service.Add(list);
        }

        public int Delete(List<UserField> list)
        {
            if (list == null || list.Count < 1) return 0;
            return service.Delete(list);
        }

        public List<UserField> Load()
        {
            List<UserField> list = new List<UserField>();
            if (service != null)
            {
                list = service.Load();
            }
            return list;
        }

        public int Update(List<UserField> list)
        {
            if (list == null || list.Count < 1) return 0;
            return service.Update(list);
        }
        
    }
}
