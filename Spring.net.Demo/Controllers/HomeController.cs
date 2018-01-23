using Spring.Context;
using Spring.Context.Support;
using Spring.net.Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Spring.net.Demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IApplicationContext ctx = ContextRegistry.GetContext();
            IUserInfo userinfo = ctx.GetObject("UserInfo") as IUserInfo;
            ViewBag.Msg = userinfo.GetMsg();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}