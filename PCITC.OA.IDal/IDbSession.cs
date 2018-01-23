/***********************************************************************************************************
 * Copyright (c) 2018Microsoft All Rights Reserved.
 * CLR版本: 4.0.30319.42000
 * 机器名称: PC201711131501
 * 公司名称: Microsoft
 * 命名空间: PCITC.OA.IDal
 * 文件名: IDbSession
 * 版本号: V1.0.0.0
 * 唯一标识: 77ce7e07-4999-4167-a226-7c66a1dcbd68
 * 当前的用户域: PC201711131501
 * 创建人: Administrator
 * 电子邮箱: 1977936166@qq.com
 * 创建时间: 2018/1/18 21:34:40
 
 *描述:
 *
 * =========================================================================================================
 * 修改标记
 * 修改时间: 2018/1/18 21:34:40
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

namespace PCITC.OA.IDal
{
    public interface IDbSession
    {
        IUserInfoDal GetUserInfoDal
        {
            get;
        }

        IOrderDal GetOrderDal
        {
            get;
        }

        int SaveChanges();
    }
}
