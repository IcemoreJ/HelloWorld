/***********************************************************************************************************
 * Copyright (c) 2018Microsoft All Rights Reserved.
 * CLR版本: 4.0.30319.42000
 * 机器名称: PC201711131501
 * 公司名称: Microsoft
 * 命名空间: PCITC.OA.Dal
 * 文件名: BaseDal
 * 版本号: V1.0.0.0
 * 唯一标识: 330da1ce-e8bb-4500-9521-8f650369007c
 * 当前的用户域: PC201711131501
 * 创建人: Administrator
 * 电子邮箱: 1977936166@qq.com
 * 创建时间: 2018/1/17 23:06:10
 
 *描述:
 *
 * =========================================================================================================
 * 修改标记
 * 修改时间: 2018/1/17 23:06:10
 * 修改人: Administrator
 * 版本号: V1.0.0.0
 * 描述:
 * 
 * ********************************************************************************************************/
using PCITC.OA.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PCITC.OA.Dal
{
    public class BaseDal<T> where T : class, new()
    {
        public DbContext Db {
            get {
                return DbContextFactory.GetCurrentDbContext();
            }
        }
        public T GetById(int id)
        {
            return Db.Set<T>().Find(id);
        }

        public List<T> GetAll()
        {
            return Db.Set<T>().ToList();
        }

        public bool Updata(T entity)
        {
            Db.Entry(entity).State = System.Data.Entity.EntityState.Modified;

            return true;
        }

        public bool Delete(T entity)
        {
            Db.Set<T>().Attach(entity);
            Db.Set<T>().Remove(entity);
            return true;
        }

        public T Add(T entity)
        {
            Db.Set<T>().Add(entity);

            //Db.SaveChanges();

            return entity;
        }

        /// <summary>
        /// 根据条件查询
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public IQueryable<T> GetIQueryableBy(Expression<Func<T, bool>> where)
        {
            return Db.Set<T>().Where(where).AsQueryable();
        }
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">页容量</param>
        /// <param name="where"></param>
        /// <param name="orderBy">排序的类型</param>
        /// <returns></returns>
        public List<T> GetPageList<TKey>(int pageIndex, int pageSize, Expression<Func<T, bool>> where, Expression<Func<T, TKey>> orderBy)
        {
            return Db.Set<T>().Where(where).Skip((pageIndex - 1) * pageSize).Take(pageSize).OrderBy(orderBy).ToList();
        }
    }
}
