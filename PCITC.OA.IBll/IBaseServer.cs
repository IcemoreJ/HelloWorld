using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PCITC.OA.IBll
{
    public interface IBaseServer<T> where T : class, new()
    {
        T GetById(int id);

        List<T> GetAll();
        /// <summary>
        /// 根据条件查询
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>

        bool Updata(T entity);

        bool Updata(List<int> ids);
        bool Delete(T entity);
        bool Delete(List<int> ids);
        T Add(T entity);
        IQueryable<T> GetIQueryableBy(Expression<Func<T, bool>> where);
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">页容量</param>
        /// <param name="where"></param>
        /// <param name="orderBy">排序的类型</param>
        /// <returns></returns>
        IQueryable<T> GetPageList<TKey>(int pageIndex, int pageSize, Expression<Func<T, bool>> where, Expression<Func<T, TKey>> orderBy);
    }
}
