using PCITC.OA.IBll;
using PCITC.OA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PCITC.OA.UI.Portal.Controllers
{
    public class OrderController : Controller
    {
        public static IOrderServer OrderServer { set; get; }
        // GET: Order
        public ActionResult Index()
        {
            List<Order> list = new List<Order>();
            list = OrderServer.GetAll();
            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Order order)
        {
            if (ModelState.IsValid)
            {
                OrderServer.Add(order);
                return RedirectToAction("Index", "Order");
            }

            return View();
        }
        public static Order CreateOrder(Order order)
        {
            return OrderServer.Add(order);
        }
    }
}