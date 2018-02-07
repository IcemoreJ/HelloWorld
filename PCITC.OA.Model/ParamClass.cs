/***********************************************************************************************************
 * Copyright (c) 2018Microsoft All Rights Reserved.
 * CLR版本: 4.0.30319.42000
 * 机器名称: PC201711131501
 * 公司名称: Microsoft
 * 命名空间: PCITC.OA.Model
 * 文件名: ParamClass
 * 版本号: V1.0.0.0
 * 唯一标识: 621af122-0d43-4c78-abf4-1cfd826d06ab
 * 当前的用户域: PC201711131501
 * 创建人: Administrator
 * 电子邮箱: 1977936166@qq.com
 * 创建时间: 2018/2/7 23:51:02
 
 *描述:
 *
 * =========================================================================================================
 * 修改标记
 * 修改时间: 2018/2/7 23:51:02
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
    public class ParamClass
    {
        public int PId { set; get; }
        public string PUName { get; set; }
        public string PPwd { get; set; }
        public string PShowName { get; set; }
        public string PRemark { get; set; }
    }
}
