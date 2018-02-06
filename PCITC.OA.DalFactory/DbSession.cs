/***********************************************************************************************************
 * Copyright (c) 2018Microsoft All Rights Reserved.
 * CLR版本: 4.0.30319.42000
 * 机器名称: PC201711131501
 * 公司名称: Microsoft
 * 命名空间: PCITC.OA.DalFactory
 * 文件名: DbSession
 * 版本号: V1.0.0.0
 * 唯一标识: 7fe6b981-a60e-4b35-ba48-da609d9d27e2
 * 当前的用户域: PC201711131501
 * 创建人: Administrator
 * 电子邮箱: 1977936166@qq.com
 * 创建时间: 2018/1/18 21:26:30
 
 *描述:
 *
 * =========================================================================================================
 * 修改标记
 * 修改时间: 2018/1/18 21:26:30
 * 修改人: Administrator
 * 版本号: V1.0.0.0
 * 描述:
 * 
 * ********************************************************************************************************/
using PCITC.OA.Dal;
using PCITC.OA.IDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCITC.OA.DalFactory
{
    public class DbSession : IDbSession
    {
        public IUserInfoDal GetUserInfoDal
        {
            get{
                return StaticDalFactory.GetUserInfoDal();
            }
        }

        public IOrderInfoDal GetOrderInfoDal
        {
            get{
                return StaticDalFactory.GetOrderInfoDal();
            }
        }

        public IActionInfoDal GetActionInfoDal
        {
            get
            {
                return StaticDalFactory.GetActionInfoDal();
            }
        }

        public IR_UserInfo_ActionInfoDal GetR_UserInfo_ActionInfoDal
        {
            get
            {
                return StaticDalFactory.GetR_UserInfo_ActionInfoDal();
            }
        }
        public IRoleInfoDal GetRoleInfoDal
        {
            get
            {
                return StaticDalFactory.GetRoleInfoDal();
            }
        }

        public IUserInfoExtDal GetUserInfoExtDal
        {
            get
            {
                return StaticDalFactory.GetUserInfoExtDal();
            }
        }

        public int SaveChanges()
        {
            return DbContextFactory.GetCurrentDbContext().SaveChanges();
        }
    }
}
