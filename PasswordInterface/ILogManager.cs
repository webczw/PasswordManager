using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Password.Interface
{
    public interface ILogManager<TT> : Imanager<TT> where TT : class
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="select">查询对象</param>
        /// <param name="where">条件</param>
        /// <param name="order">排序</param>
        /// <param name="pageIndex">当前页数</param>
        /// <param name="pageSize">分页行数</param>
        /// <param name="Total">总行数</param>
        /// <returns></returns>
        List<dynamic> GetPageData<T, TKey>(Expression<Func<T, dynamic>> select, Expression<Func<T, bool>> where, Expression<Func<T, TKey>> order, int pageIndex, int pageSize, out int Total)
          where T : class;
    }
}
