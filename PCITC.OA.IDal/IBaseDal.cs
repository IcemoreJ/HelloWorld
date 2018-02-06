/***********************************************************************************************************
 * Copyright (c) 2018Microsoft All Rights Reserved.
 * CLR版本: 4.0.30319.42000
 * 机器名称: PC201711131501
 * 公司名称: Microsoft
 * 命名空间: PCITC.OA.IDal
 * 文件名: IBaseDal
 * 版本号: V1.0.0.0
 * 唯一标识: 7022caaf-cb56-4936-8a9b-6a194f4bb54b
 * 当前的用户域: PC201711131501
 * 创建人: Administrator
 * 电子邮箱: 1977936166@qq.com
 * 创建时间: 2018/1/17 23:22:45
 
 *描述:
 *
 * =========================================================================================================
 * 修改标记
 * 修改时间: 2018/1/17 23:22:45
 * 修改人: Administrator
 * 版本号: V1.0.0.0
 * 描述:
 * 
 * ********************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PCITC.OA.IDal
{
    public interface IBaseDal<T> where T : class, new()
    {
        T GetById(int id);

        List<T> GetAll();
        /// <summary>
        /// 根据条件查询
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>

        bool Updata(T entity);

        bool Updata(int id);

        bool Delete(T entity);

        bool Delete(int id);

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
