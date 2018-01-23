/***********************************************************************************************************
 * Copyright (c) 2018Microsoft All Rights Reserved.
 * CLR版本: 4.0.30319.42000
 * 机器名称: PC201711131501
 * 公司名称: Microsoft
 * 命名空间: Spring.net.Demo.Models
 * 文件名: UserInfo
 * 版本号: V1.0.0.0
 * 唯一标识: 3acd8066-4941-499c-8612-b8ef2bdf00ba
 * 当前的用户域: PC201711131501
 * 创建人: Administrator
 * 电子邮箱: 1977936166@qq.com
 * 创建时间: 2018/1/21 22:39:15
 
 *描述:
 *
 * =========================================================================================================
 * 修改标记
 * 修改时间: 2018/1/21 22:39:15
 * 修改人: Administrator
 * 版本号: V1.0.0.0
 * 描述:
 * 
 * ********************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spring.net.Demo.Models
{
    public class UserInfo : IUserInfo
    {
        public UserInfo(string name, Order order)
        {
            this.Name = name;
            this.OrderBy = order;
        }
        public string Name { set; get; }
        public Order OrderBy { set; get; }
        public string GetMsg()
        {
            return ("欢迎" + Name + "订单号:" + OrderBy.OrderNo);
        }
        
    }
    public class Order
    {
        public string OrderNo { get; set; }
    }
}