﻿using Password.Common;
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
    public class UserFieldValueManager : BaseManager, Imanager<UserFieldValue>
    {
        Iservice<UserFieldValue> service;
        public UserFieldValueManager(SendBackParameter sendBackParameter) : base(sendBackParameter)
        {
            if (service == null)
            {
                service = Tools.DynamicCreateClass<Iservice<UserFieldValue>>("UserFieldValueService", this.sendBackParameter);
                if (service == null)
                {
                    Logger.Error("创建用户自定义字段值服务类实例异常。", MethodBase.GetCurrentMethod(), this.sendBackParameter);//记录日志
                }
            }
        }

        public int Add(List<UserFieldValue> list)
        {
            if (list == null || list.Count < 1) return 0;
            return service.Add(list);
        }

        public int Delete(List<UserFieldValue> list)
        {
            if (list == null || list.Count < 1) return 0;
            return service.Delete(list);
        }

        public List<UserFieldValue> Load()
        {
            List<UserFieldValue> list = new List<UserFieldValue>();
            if (service != null)
            {
                list = service.Load();
            }
            return list;
        }

        public int Update(List<UserFieldValue> list)
        {
            if (list == null || list.Count < 1) return 0;
            return service.Update(list);
        }
    }
}
