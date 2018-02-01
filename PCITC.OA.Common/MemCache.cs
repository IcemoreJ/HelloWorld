/***********************************************************************************************************
 * Copyright (c) 2018Microsoft All Rights Reserved.
 * CLR版本: 4.0.30319.42000
 * 机器名称: PC201711131501
 * 公司名称: Microsoft
 * 命名空间: PCITC.OA.Common
 * 文件名: MemCache
 * 版本号: V1.0.0.0
 * 唯一标识: ec86d30c-2b38-4c86-b09f-cc6bea8878a5
 * 当前的用户域: PC201711131501
 * 创建人: Administrator
 * 电子邮箱: 1977936166@qq.com
 * 创建时间: 2018/1/31 22:18:11
 
 *描述:
 *
 * =========================================================================================================
 * 修改标记
 * 修改时间: 2018/1/31 22:18:11
 * 修改人: Administrator
 * 版本号: V1.0.0.0
 * 描述:
 * 
 * ********************************************************************************************************/
using Memcached.ClientLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCITC.OA.Common
{
    public class MemCache : IBaseCache
    {
        public MemcachedClient memcachedClient;
        public MemCache()
        {
            string str = System.Configuration.ConfigurationManager.AppSettings["MemcacheConfig"];
            string[] serverlist = new string[] { str };

  
            // initialize the pool for memcache servers
            SockIOPool pool = SockIOPool.GetInstance();
            pool.SetServers(serverlist);

            pool.InitConnections = 3;
            pool.MinConnections = 3;
            pool.MaxConnections = 5;

            pool.SocketConnectTimeout = 1000;
            pool.SocketTimeout = 3000;

            pool.MaintenanceSleep = 30;
            pool.Failover = true;

            pool.Nagle = false;
            pool.Initialize();
            MemcachedClient mc = new MemcachedClient();
            mc.EnableCompression = false;
            memcachedClient = mc;
        }
        
        public void Add(string key, object value)
        {
            memcachedClient.Add(key, value);
        }

        public void Add(string key, object value, DateTime time)
        {
            memcachedClient.Add(key, value, time);
        }

        public void Delete(string key)
        {
            memcachedClient.Delete(key);
        }

        public object Get(string key)
        {
            return memcachedClient.Get(key);
        }

        public void Set(string key, object value, DateTime time)
        {
            memcachedClient.Set(key, value, time);
        }
    }
}
