using Common.Logging;
using PCITC.OA.UI.Portal.Models;
using Spring.Web.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace PCITC.OA.UI.Portal
{
    public class MvcApplication : SpringMvcApplication //System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            log4net.Config.XmlConfigurator.Configure();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ThreadPool.QueueUserWorkItem(o =>
            {
                while (true)
                {
                    if (MyExceptionFilterAttribute.queue.Count > 0)
                    {
                        Exception exception = MyExceptionFilterAttribute.queue.Dequeue();
                        //foreach (IBaseLog item in list)
                        //{    
                        //    item.WriteLog(str);
                        //}

                        if (exception != null)
                        {
                            ILog log = LogManager.GetLogger("testLog");
                            log.Error(exception.ToString());
                        }
                        else
                        {
                            Thread.Sleep(50);
                        }
                    }
                    else
                    {
                        Thread.Sleep(50);
                    }

                }
            });
        }
    }
}
