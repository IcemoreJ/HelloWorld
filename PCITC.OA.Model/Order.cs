/***********************************************************************************************************
 * Copyright (c) 2018Microsoft All Rights Reserved.
 * CLR版本: 4.0.30319.42000
 * 机器名称: PC201711131501
 * 公司名称: Microsoft
 * 命名空间: PCITC.OA.Model
 * 文件名: Order
 * 版本号: V1.0.0.0
 * 唯一标识: 89cb9a6b-3076-4c59-8cbe-aae5cd19a063
 * 当前的用户域: PC201711131501
 * 创建人: Administrator
 * 电子邮箱: 1977936166@qq.com
 * 创建时间: 2018/1/17 20:08:23
 
 *描述:
 *
 * =========================================================================================================
 * 修改标记
 * 修改时间: 2018/1/17 20:08:23
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

namespace PCITC.OA.Model
{
    public class Order
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Detail { set; get; }

        public virtual UserInfo UserInfo { set; get; }
    }
}
