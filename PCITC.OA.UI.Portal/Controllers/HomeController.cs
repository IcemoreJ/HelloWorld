using PCITC.OA.IBll;
using PCITC.OA.Model;
using System.Collections.Generic;
using System.Web.Mvc;

namespace PCITC.OA.UI.Portal.Controllers
{

    public class HomeController : Controller
    {
        //IUserInfoServer userServer = new UserInfoServer();
        public IUserInfoServer UserInfoServer { set; get; }
        //该项应该再另建一个Controller的类里面写入，此处为方便不另建Controller而写在该地方以通过调试
        public IOrderServer OrderServer { set; get; }
        //IDbSession dbSession = DbSessionFactory.GetCurrentDbSession();
        public ActionResult Index()
        {
            List<UserInfo> list = UserInfoServer.GetAll();
            return View(list);
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

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserInfo user)
        {
            if (ModelState.IsValid)
            {
                UserInfoServer.Add(user);
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult Details(int id = 0)
        {
            var obj = UserInfoServer.GetById(id);
            if (obj == null)
            {
                return HttpNotFound();
            }

            return View(obj);
        }

        public ActionResult Delete(int id = 0)
        {
            var obj = UserInfoServer.GetById(id);

            if (obj == null)
            {
                return HttpNotFound();
            }

            return View(obj);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteInfo(UserInfo user)
        {
            bool flag = UserInfoServer.Delete(user);
            if (flag == false)
            {
                return HttpNotFound();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id = 0)
        {
            var obj = UserInfoServer.GetById(id);

            if (obj == null)
            {
                return HttpNotFound();
            }

            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UserInfo user)
        {
            bool flag = UserInfoServer.Updata(user);

            if (flag == false)
            {
                return HttpNotFound();
            }

            return RedirectToAction("Index");
        }

        #region 
        //[HttpPost]
        //public ActionResult NotExitesUserName()
        //{
        //    string name = Request.Params["Name"];
        //    var user = userServer.GetIQueryableBy(u => u.Name == name);

        //    return user == null ? Json(true, JsonRequestBehavior.AllowGet) : Json(false, JsonRequestBehavior.AllowGet);
        //} 
        #endregion
    }
}