using PCITC.OA.Dal;
using PCITC.OA.IDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PCITC.OA.DalFactory
{
    public class StaticDalFactory
    {
        private static string str = System.Configuration.ConfigurationManager.AppSettings["DalAssembly"];

        //做单元测试使用
        //public static IUserInfoDal GetUserInfoDal()
        //{
        //    return new UserInfoDal();
        //}

        public static IUserInfoDal GetUserInfoDal()
        {
            return Assembly.Load(str).CreateInstance(str + ".UserInfoDal") as IUserInfoDal;
        }

        public static IOrderInfoDal GetOrderInfoDal()
        {
            return Assembly.Load(str).CreateInstance(str + ".OrderInfoDal") as IOrderInfoDal;
        }

        public static IActionInfoDal GetActionInfoDal()
        {
            return Assembly.Load(str).CreateInstance(str + ".ActionInfoDal") as IActionInfoDal;
        }
        public static IR_UserInfo_ActionInfoDal GetR_UserInfo_ActionInfoDal()
        {
            return Assembly.Load(str).CreateInstance(str + ".R_UserInfo_ActionInfoDal") as IR_UserInfo_ActionInfoDal;
        }
        public static IRoleInfoDal GetRoleInfoDal()
        {
            return Assembly.Load(str).CreateInstance(str + ".RoleInfoDal") as IRoleInfoDal;
        }
        public static IUserInfoExtDal GetUserInfoExtDal()
        {
            return Assembly.Load(str).CreateInstance(str + ".UserInfoExtDal") as IUserInfoExtDal;
        }
        
    }
}
