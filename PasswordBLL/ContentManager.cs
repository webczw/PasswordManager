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
    public class ContentManager : BaseManager, Imanager<Content>
    {
        Iservice<Content> service;
        public ContentManager(SendBackParameter sendBackParameter) : base(sendBackParameter)
        {
            if (service == null)
            {
                service = Tools.DynamicCreateClass<Iservice<Content>>("ContentService", this.sendBackParameter);
                if (service == null)
                {
                    Logger.Error("创建分类服务类实例异常。", MethodBase.GetCurrentMethod(), this.sendBackParameter);//记录日志
                }
            }
        }
        public int Add(List<Content> list)
        {
            if (list == null || list.Count < 1) return 0;
            return service.Add(list);
        }

        public int Delete(List<Content> list)
        {
            if (list == null || list.Count < 1) return 0;
            return service.Delete(list);
        }

        public List<Content> Load()
        {
            List<Content> list = new List<Content>();
            if (service != null)
            {
                list = service.Load();
            }
            return list;
        }

        public int Update(List<Content> list)
        {
            if (list == null || list.Count < 1) return 0;
            return service.Update(list);
        }
    }
}
