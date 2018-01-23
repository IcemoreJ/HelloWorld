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

        public static IOrderDal GetOrderDal()
        {
            return Assembly.Load(str).CreateInstance(str + ".OrderDal") as IOrderDal;
        }
    }
}
