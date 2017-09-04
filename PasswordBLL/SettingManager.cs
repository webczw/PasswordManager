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
    public class SettingManager : BaseManager, Imanager<Setting>
    {

        Iservice<Setting> service;
        public SettingManager(SendBackParameter sendBackParameter) : base(sendBackParameter)
        {
            if (service == null)
            {
                service = Tools.DynamicCreateClass<Iservice<Setting>>("SettingService", this.sendBackParameter);
                if (service == null)
                {
                    Logger.Error("创建系统设置服务类实例异常。", MethodBase.GetCurrentMethod(), this.sendBackParameter);//记录日志
                }
            }
        }

        public int Add(List<Setting> list)
        {
            if (list == null || list.Count < 1) return 0;
            return service.Add(list);
        }

        public int Delete(List<Setting> list)
        {
            if (list == null || list.Count < 1) return 0;
            return service.Delete(list);
        }

        public List<Setting> Load()
        {
            List<Setting> list = new List<Setting>();
            if (service != null)
            {
                list = service.Load();
            }
            return list;
        }

        public int Update(List<Setting> list)
        {
            if (list == null || list.Count < 1) return 0;
            return service.Update(list);
        }
    }
}
