using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Password.Interface
{
   public interface ILogService<TT>:Iservice<TT> where TT :class
    {
        List<dynamic> GetPageData<T, TKey>(Expression<Func<T, dynamic>> select, Expression<Func<T, bool>> where, Expression<Func<T, TKey>> order, int pageIndex, int pageSize, out int Total)
          where T : class;
    }
}
