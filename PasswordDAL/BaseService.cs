using Password.Common;
using Password.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Password.DAL
{
    public class BaseService
    {
        protected DatabaseContext databaseContext { private set; get; }
        protected SendBackParameter sendBackParameter { private set; get; }
        public BaseService(SendBackParameter sendBackParameter)
        {
            this.sendBackParameter = sendBackParameter;
            if (databaseContext == null)
            {
                this.databaseContext = new DatabaseContext();
            }
        }
        /// <summary>
        /// 增加或删除动作
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        protected int BaseAddOrDelete<T>(Func<List<T>, IEnumerable<T>> action, List<T> list)
        {
            int result = 0;
            try
            {
                if (list == null || list.Count < 1) return result;
                action(list);
                result = databaseContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), this.sendBackParameter);//记录日志
            }
            return result;
        }
        /// <summary>
        /// 加载数据动作
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
        protected List<T> BaseLoad<T>(Func<List<T>> action)
        {
            List<T> list = new List<T>();
            try
            {
                list = action();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), this.sendBackParameter);//记录日志
            }
            return list;
        }
        /// <summary>
        /// 更新动作
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        protected int BaseUpdate<T>(Action action, List<T> list)
        {
            int result = 0;
            try
            {
                if (list == null || list.Count < 1) return result;
                action();
                result = databaseContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), this.sendBackParameter);//记录日志
            }
            return result;
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
        protected List<dynamic> BaseGetPageData<T, TKey>(Expression<Func<T, dynamic>> select, Expression<Func<T, bool>> where, Expression<Func<T, TKey>> order, int pageIndex, int pageSize, out int Total)
            where T : class
        {

            Total = databaseContext.Set<T>().Where(where).Count();
            var list = databaseContext.Set<T>().Where(where).OrderByDescending(order).Select(select).Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return list.ToList();
        }
    }
}
