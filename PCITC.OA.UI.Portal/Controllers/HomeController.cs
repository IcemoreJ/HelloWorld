using PCITC.OA.IBll;
using PCITC.OA.Model;
using PCITC.OA.UI.Portal.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace PCITC.OA.UI.Portal.Controllers
{
    [MyActionFilter(Flag = false)]
    public class HomeController : Controller
    {
        //IUserInfoServer userServer = new UserInfoServer();
        public IUserInfoServer UserInfoServer { set; get; }
        //该项应该再另建一个Controller的类里面写入，此处为方便不另建Controller而写在该地方以通过调试
        public IOrderInfoServer OrderInfoServer { set; get; }
        //IDbSession dbSession = DbSessionFactory.GetCurrentDbSession();
        public ActionResult Index()
        {
            int a = 0;
            int b = 1 / a;
            return View();
        }
        [HttpPost]
        public ActionResult UserInfoToJson(string rows, string page)
        {
            int pageSize = int.Parse(Request["rows"] == null ? "10" : Request["rows"]);
            int pageIndex = int.Parse(Request["page"] == null ? "1" : Request["page"]);
            var pageData = UserInfoServer.GetPageList(pageIndex, pageSize, u => u.Id >= 0, u => u.Id).Select(u => new { u.Id, u.UName, u.Pwd, u.ShowName, u.Remark, u.DelFlag }).ToList();
            int total = UserInfoServer.GetAll().Count;

            //var pageData = UserInfoServer.GetPageList(pageIndex, pageSize, u => u.Id >= 0, u => u.Id).Select(u => new { u.Id, u.UName, u.Pwd, u.ShowName, u.Remark, u.DelFlag });
            var data = new {total = total, rows = pageData.ToList() };
            return Json(data, JsonRequestBehavior.AllowGet);
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

        [HttpPost]
        public ActionResult Create(UserInfo user)
        {
            if (ModelState.IsValid)
            {
                UserInfoServer.Add(user);
                return Content("OK");
            }

            return Content("NOOK");
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
        [HttpPost]
        public ActionResult Delete(string idlist)
        {
            string[] str = idlist.Split(',');
            List<int> list = new List<int>();
            foreach (var item in str)
            {
                list.Add(int.Parse(item));
            }

            bool flag = UserInfoServer.Delete(list);

            if (flag)
            {
                return Content("OK");
            }
            else
            {
                return Content("NOOK");
            }
        }
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteInfo(UserInfo user)
        //{
        //    bool flag = UserInfoServer.Delete(user);
        //    if (flag == false)
        //    {
        //        return HttpNotFound();
        //    }

        //    return RedirectToAction("Index");
        //}

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