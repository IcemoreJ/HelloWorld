/***********************************************************************************************************
 * Copyright (c) 2018Microsoft All Rights Reserved.
 * CLR版本: 4.0.30319.42000
 * 机器名称: PC201711131501
 * 公司名称: Microsoft
 * 命名空间: PCITC.OA.UI.Portal.Models
 * 文件名: ActionFilterAttribute
 * 版本号: V1.0.0.0
 * 唯一标识: 07327e95-3012-442a-aa76-a2d092c1d618
 * 当前的用户域: PC201711131501
 * 创建人: Administrator
 * 电子邮箱: 1977936166@qq.com
 * 创建时间: 2018/1/27 18:01:30
 
 *描述:
 *
 * =========================================================================================================
 * 修改标记
 * 修改时间: 2018/1/27 18:01:30
 * 修改人: Administrator
 * 版本号: V1.0.0.0
 * 描述:
 * 
 * ********************************************************************************************************/
using PCITC.OA.Common;
using PCITC.OA.IBll;
using PCITC.OA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Mvc;

namespace PCITC.OA.UI.Portal.Models
{
    public class MyActionFilterAttribute : ActionFilterAttribute
    {
        public IUserInfoServer UserInfoServer { set; get; }
        public UserInfo userInfo { set; get; }
        public bool Flag {
            set;
            get;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            if (Flag == true)
            {
                string str = HttpContext.Current.Request.Cookies["cookieName"].Value;
                userInfo = MyCache.Get(str) as UserInfo;

                if (userInfo == null)
                {
                    filterContext.HttpContext.Response.Redirect("/LoginUser/Index");
                }

                MyCache.Delete(str);
                MyCache.Add(str, userInfo, DateTime.Now.AddMinutes(20));
            }
        }
    }
}