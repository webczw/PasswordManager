using Password.Common;
using Password.Entity;
using Password.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
namespace Password.BLL
{
    /// <summary>
    /// 日志管理类
    /// </summary>
    public class LogManager : BaseManager, ILogManager<Log>
    {
        ILogService<Log> service;
        public LogManager(SendBackParameter sendBackParameter) : base(sendBackParameter)
        {
            if (service == null)
            {
                service = Tools.DynamicCreateClass<ILogService<Log>>("LogService", this.sendBackParameter);
                if (service == null)
                {
                    Logger.Error("创建日志服务类实例异常。", MethodBase.GetCurrentMethod(), this.sendBackParameter);//记录日志
                }
            }
        }
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int Add(List<Log> list)
        {
            if (list == null || list.Count < 1) return 0;
            return service.Add(list);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int Delete(List<Log> list)
        {
            if (list == null || list.Count < 1) return 0;
            return service.Delete(list);
        }
        
        /// <summary>
        /// 加载
        /// </summary>
        /// <returns></returns>
        public List<Log> Load()
        {
            List<Log> list = new List<Log>();
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
        public int Update(List<Log> list)
        {
            if (list == null || list.Count < 1) return 0;
            return service.Update(list);
        }
        /// <summary>
        /// 分页
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="Total"></param>
        /// <returns></returns>
        public List<dynamic> GetPageData<T, TKey>(Expression<Func<T, dynamic>> select, Expression<Func<T, bool>> where, Expression<Func<T, TKey>> order, int pageIndex, int pageSize, out int Total) where T : class
        {
            return service.GetPageData<T, TKey>(select, where, order, pageIndex, pageSize, out Total); 
        }
    }
}
