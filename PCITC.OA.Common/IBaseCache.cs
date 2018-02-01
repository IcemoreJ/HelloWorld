/***********************************************************************************************************
 * Copyright (c) 2018Microsoft All Rights Reserved.
 * CLR版本: 4.0.30319.42000
 * 机器名称: PC201711131501
 * 公司名称: Microsoft
 * 命名空间: PCITC.OA.Common
 * 文件名: IBaseCache
 * 版本号: V1.0.0.0
 * 唯一标识: 3023286b-eb6c-4c01-bb33-521659668bc0
 * 当前的用户域: PC201711131501
 * 创建人: Administrator
 * 电子邮箱: 1977936166@qq.com
 * 创建时间: 2018/1/31 22:09:30
 
 *描述:
 *
 * =========================================================================================================
 * 修改标记
 * 修改时间: 2018/1/31 22:09:30
 * 修改人: Administrator
 * 版本号: V1.0.0.0
 * 描述:
 * 
 * ********************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCITC.OA.Common
{
    public interface IBaseCache
    {
        void Add(string key, object value);
        void Add(string key, object value, DateTime time);
        object Get(string key);
        void Delete(string key);
        void Set(string key, object value, DateTime time);
    }
}
