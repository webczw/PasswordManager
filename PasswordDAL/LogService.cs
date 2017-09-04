using Password.Entity;
using Password.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
namespace Password.DAL
{
    /// <summary>
    /// 日志服务类s
    /// </summary>
    public class LogService : BaseService, ILogService<Log>
    {
        public LogService(SendBackParameter sendBackParameter) : base(sendBackParameter) { }
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int Add(List<Log> list)
        {
            return BaseAddOrDelete<Log>(databaseContext.Logs.AddRange, list);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int Delete(List<Log> list)
        {
            return BaseAddOrDelete<Log>(databaseContext.Logs.RemoveRange, list);
        }
        
        /// <summary>
        /// 加载
        /// </summary>
        /// <returns></returns>
        public List<Log> Load()
        {
            return BaseLoad<Log>(databaseContext.Logs.ToList);
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int Update(List<Log> list)
        {
            return BaseUpdate<Log>(() =>
            {
                foreach (var item in list)
                {
                    Log SystemLog = databaseContext.Logs.First(p => p.LogID == item.LogID);
                    SystemLog.Level = item.Level;
                    SystemLog.Location = item.Location;
                    SystemLog.Exception = item.Exception;
                    SystemLog.Message = item.Message;
                }
            }, list);
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
            return BaseGetPageData<T, TKey>(select, where, order, pageIndex, pageSize, out Total);
        }

    }
}
