using PCITC.OA.Common;
using PCITC.OA.IBll;
using PCITC.OA.Model;
using PCITC.OA.UI.Portal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PCITC.OA.UI.Portal.Controllers
{
    [MyActionFilterAttribute(Flag = false)]
    public class LoginUserController : Controller
    {
        public IUserInfoServer UserInfoServer { set; get; }
        // GET: LoginUser
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowVCode()
        {
            string oldcode = TempData["SecurityCode"] as string;
            string code = RandomCode.CreateRandomCode(4); //验证码的字符为4个
            TempData["SecurityCode"] = code; //验证码存放在TempData中
            Session["SecurityCode"] = code;
            return File(RandomCode.CreateValidateGraphic(code), "image/Jpeg");
        }
        [HttpPost]
        public ActionResult Index(string name, string passwd, string securityCode)
        {
            string str = Session["SecurityCode"].ToString();

            if (String.IsNullOrEmpty(str))
            {
                return Content("NotCode");
            }

            if (!str.ToLower().Equals(securityCode.ToLower()))
            {
                return Content("NotCode");
            }
            var user = UserInfoServer.GetIQueryableBy(u => u.Name == name && u.Passwd == passwd).FirstOrDefault();
            if (user == null)
            {
                return Content("NotPasswd");
            }
            Session["UserInfo"] = new UserInfo { Name = name, Passwd = passwd };
            string UserGuid = new Guid().ToString();
    

            MyCache.Add(UserGuid, name);

            return Content("Ok");
        }
    }
}