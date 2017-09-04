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
    public class FieldManager : BaseManager, Imanager<Field>
    {
        Iservice<Field> service;
        public FieldManager(SendBackParameter sendBackParameter) : base(sendBackParameter)
        {
            if (service == null)
            {
                service = Tools.DynamicCreateClass<Iservice<Field>>("FieldService", this.sendBackParameter);
                if (service == null)
                {
                    Logger.Error("创建栏位服务类实例异常。", MethodBase.GetCurrentMethod(), this.sendBackParameter);//记录日志
                }
            }
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int Add(List<Field> list)
        {
            if (list == null || list.Count < 1) return 0;
            return service.Add(list);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int Delete(List<Field> list)
        {
            if (list == null || list.Count < 1) return 0;
            return service.Delete(list);
        }
        /// <summary>
        /// 加载
        /// </summary>
        /// <returns></returns>
        public List<Field> Load()
        {
            List<Field> list = new List<Field>();
            if (service != null)
            {
                list = service.Load();
            }
            return list;
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int Update(List<Field> list)
        {
            if (list == null || list.Count < 1) return 0;
            return service.Update(list);
        }
    }
}
