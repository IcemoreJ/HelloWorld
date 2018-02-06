/***********************************************************************************************************
 * Copyright (c) 2018Microsoft All Rights Reserved.
 * CLR版本: 4.0.30319.42000
 * 机器名称: PC201711131501
 * 公司名称: Microsoft
 * 命名空间: PCITC.OA.Bll
 * 文件名: OrderServer
 * 版本号: V1.0.0.0
 * 唯一标识: 1629c59b-97d6-4ded-bdc3-e1c2af88d7d5
 * 当前的用户域: PC201711131501
 * 创建人: Administrator
 * 电子邮箱: 1977936166@qq.com
 * 创建时间: 2018/1/18 21:41:20
 
 *描述:
 *
 * =========================================================================================================
 * 修改标记
 * 修改时间: 2018/1/18 21:41:20
 * 修改人: Administrator
 * 版本号: V1.0.0.0
 * 描述:
 * 
 * ********************************************************************************************************/
using PCITC.OA.IBll;
using PCITC.OA.IDal;
using PCITC.OA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCITC.OA.Bll
{
    public class OrderInfoServer : BaseServer<OrderInfo>, IOrderInfoServer
    {
        //public override void SetBaseDal()
        //{
        //    baseDal = this.CurrentDbSession.GetOrderDal;
        //}
    }
}
