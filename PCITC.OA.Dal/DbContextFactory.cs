/***********************************************************************************************************
 * Copyright (c) 2018Microsoft All Rights Reserved.
 * CLR版本: 4.0.30319.42000
 * 机器名称: PC201711131501
 * 公司名称: Microsoft
 * 命名空间: PCITC.OA.Dal
 * 文件名: DbContextFactory
 * 版本号: V1.0.0.0
 * 唯一标识: 5b59583b-484c-4549-82c1-645af09ba672
 * 当前的用户域: PC201711131501
 * 创建人: Administrator
 * 电子邮箱: 1977936166@qq.com
 * 创建时间: 2018/1/18 20:57:45
 
 *描述:
 *
 * =========================================================================================================
 * 修改标记
 * 修改时间: 2018/1/18 20:57:45
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
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PCITC.OA.Dal
{
    public class DbContextFactory
    {
        public static DbContext GetCurrentDbContext()
        {
            DbContext Db = CallContext.GetData("DbContext") as DbContext;

            if (Db == null)
            {
                Db = new DataModelContainer();
                CallContext.SetData("DbContext", Db);
            }

            return Db;
        }
    }
}
