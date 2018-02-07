/***********************************************************************************************************
 * Copyright (c) 2018Microsoft All Rights Reserved.
 * CLR版本: 4.0.30319.42000
 * 机器名称: PC201711131501
 * 公司名称: Microsoft
 * 命名空间: PCITC.OA.UI.Portal.Models
 * 文件名: MyExceptionFilterAttribute
 * 版本号: V1.0.0.0
 * 唯一标识: d53ce36c-fee0-49af-93c3-692d524fb829
 * 当前的用户域: PC201711131501
 * 创建人: Administrator
 * 电子邮箱: 1977936166@qq.com
 * 创建时间: 2018/1/23 22:51:50
 
 *描述:
 *
 * =========================================================================================================
 * 修改标记
 * 修改时间: 2018/1/23 22:51:50
 * 修改人: Administrator
 * 版本号: V1.0.0.0
 * 描述:
 * 
 * ********************************************************************************************************/
using PCITC.OA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PCITC.OA.UI.Portal.Models
{
    public class MyExceptionFilterAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            string exception = filterContext.Exception.ToString();
            LogHelper.WriteLog(exception);
            filterContext.Result = new RedirectResult("~/error.html");
            filterContext.ExceptionHandled = true;
            base.OnException(filterContext);
        }
    }
}