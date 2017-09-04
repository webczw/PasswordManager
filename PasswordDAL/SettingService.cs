using Password.Entity;
using Password.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password.DAL
{
    public class SettingService : BaseService, Iservice<Setting>
    {
        public SettingService(SendBackParameter sendBackParameter) : base(sendBackParameter) { }
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int Add(List<Setting> list)
        {
            return BaseAddOrDelete<Setting>(databaseContext.Settings.AddRange, list);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int Delete(List<Setting> list)
        {
            return BaseAddOrDelete<Setting>(databaseContext.Settings.RemoveRange, list);
        }
        /// <summary>
        /// 加载
        /// </summary>
        /// <returns></returns>
        public List<Setting> Load()
        {
            return BaseLoad<Setting>(databaseContext.Settings.ToList);
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int Update(List<Setting> list)
        {
            return BaseUpdate<Setting>(() =>
            {
                foreach (var item in list)
                {
                    Setting setting = databaseContext.Settings.First(p => p.SettingID == item.SettingID);
                    setting.SetValue = item.SetValue;
                    setting.UpdateDate = item.UpdateDate;
                }
            }, list);
        }
        
    }
}
