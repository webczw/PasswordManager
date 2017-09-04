using Password.DAL;
using Password.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Password.Interface;
using Password.Common;
using System.Reflection;

namespace Password.BLL
{
    public class UserManager : BaseManager, Imanager<User>
    {
        Iservice<User> service;

        public UserManager(SendBackParameter sendBackParameter) : base(sendBackParameter) 
        {
            if (service == null)
            {
                service =  Tools.DynamicCreateClass<Iservice<User>>("UserService",this.sendBackParameter);
                if (service == null)
                {
                    Logger.Error("创建用户服务类实例异常。", MethodBase.GetCurrentMethod(), this.sendBackParameter);//记录日志
                }
            }
        }

        public int Add(List<User> list)
        {
            return service.Add(list);
        }

        public int Delete(List<User> list)
        {
            if (list == null || list.Count < 1) return 0;
            return service.Delete(list);
        }

        public List<User> Load()
        {
            return service.Load();
        }

        public int Update(List<User> list)
        {
            if (list == null || list.Count < 1) return 0;
            return service.Update(list);
        }
        
    }
}
