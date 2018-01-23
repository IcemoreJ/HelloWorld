/***********************************************************************************************************
 * Copyright (c) 2018Microsoft All Rights Reserved.
 * CLR版本: 4.0.30319.42000
 * 机器名称: PC201711131501
 * 公司名称: Microsoft
 * 命名空间: PCITC.OA.Bll
 * 文件名: BaseServer
 * 版本号: V1.0.0.0
 * 唯一标识: ca24cd2c-03f8-4ce6-992b-227d39d2162d
 * 当前的用户域: PC201711131501
 * 创建人: Administrator
 * 电子邮箱: 1977936166@qq.com
 * 创建时间: 2018/1/18 21:41:42
 
 *描述:
 *
 * =========================================================================================================
 * 修改标记
 * 修改时间: 2018/1/18 21:41:42
 * 修改人: Administrator
 * 版本号: V1.0.0.0
 * 描述:
 * 
 * ********************************************************************************************************/
using PCITC.OA.DalFactory;
using PCITC.OA.IDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PCITC.OA.Bll
{
    public abstract class BaseServer<T> where T : class, new()
    {
        //IDbSession dbSession = DbSessionFactory.GetCurrentDbSession();
        //public BaseServer()
        //{
        //    SetBaseDal();
        //}

        public IBaseDal<T> currentDal
        {
            get; set;
        }

        public IDbSession DbSession
        {
            get;
            set;
        }

        //public abstract void SetBaseDal();

        public T GetById(int id)
        {
            return currentDal.GetById(id);
        }

        public List<T> GetAll()
        {
            return currentDal.GetAll();
        }
        /// <summary>
        /// 根据条件查询
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>

        public bool Updata(T entity)
        {
            bool flag = currentDal.Updata(entity);
            DbSession.SaveChanges();
            return flag;
        }

        public bool Delete(T entity)
        {
            bool flag = currentDal.Delete(entity);
            DbSession.SaveChanges();
            return flag;
        }



        public T Add(T entity)
        {
            T obj = currentDal.Add(entity);
            DbSession.SaveChanges();
            return obj;
        }
        public IQueryable<T> GetIQueryableBy(Expression<Func<T, bool>> where)
        {
            return currentDal.GetIQueryableBy(where);
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
            return currentDal.GetPageList<TKey>(pageIndex, pageSize, where, orderBy);
        }
    }
}
