using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password.Interface
{
    public interface Iservice<T> where T : class
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        int Add(List<T> list);
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        int Update(List<T> list);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        int Delete(List<T> list);
        /// <summary>
        /// 加载
        /// </summary>
        /// <returns></returns>
        List<T> Load();
    }
}
