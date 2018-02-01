using PCITC.OA.UI.Portal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PCITC.OA.UI.Portal.Controllers
{
    [MyActionFilter(Flag = false)]
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Index()
        {
            return View();
        }
    }
}