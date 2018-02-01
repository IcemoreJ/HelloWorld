/***********************************************************************************************************
 * Copyright (c) 2018Microsoft All Rights Reserved.
 * CLR版本: 4.0.30319.42000
 * 机器名称: PC201711131501
 * 公司名称: Microsoft
 * 命名空间: PCITC.OA.Common
 * 文件名: MyCache
 * 版本号: V1.0.0.0
 * 唯一标识: 83d00ba9-72de-44fe-b5da-8c11c448f0b1
 * 当前的用户域: PC201711131501
 * 创建人: Administrator
 * 电子邮箱: 1977936166@qq.com
 * 创建时间: 2018/1/31 22:05:03
 
 *描述:
 *
 * =========================================================================================================
 * 修改标记
 * 修改时间: 2018/1/31 22:05:03
 * 修改人: Administrator
 * 版本号: V1.0.0.0
 * 描述:
 * 
 * ********************************************************************************************************/
using Spring.Context;
using Spring.Context.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCITC.OA.Common
{
    public class MyCache
    {
        public static IBaseCache BaseCache{
            get;set;
        }

        static MyCache()
        {
            IApplicationContext ctx = ContextRegistry.GetContext();
            BaseCache = ctx.GetObject("BaseCache") as IBaseCache; 
        }

        public static void Add(string key, string value)
        {
            BaseCache.Add(key, value);
        }
        public static void Add(string key, string value, DateTime time)
        {
            BaseCache.Add(key, value, time);
        }
        public static object Get(string key)
        {
            return BaseCache.Get(key);
        }
        public static void Delete(string key)
        {
            BaseCache.Delete(key);
        }
        public static void Set(string key, string value, DateTime time)
        {
            BaseCache.Set(key, value, time);
        }

    }
}
