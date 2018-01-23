using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PCITC.OA.Bll;
using PCITC.OA.Model;
using PCITC.OA.IDal;
using PCITC.OA.DalFactory;

namespace PCITC.OA.UnitTest.PCITC.OA.Bll
{
    [TestClass]
    public class CRUD
    {
        [TestMethod]
        public void TestMethod1()
        {
            UserInfoServer userServer = new UserInfoServer();
            IDbSession dbSession = DbSessionFactory.GetCurrentDbSession();

            UserInfo user = new UserInfo();

            user.Name = "Jerry";
            user.Gender = "雄性";
            user.Phone = "000000";

            userServer.Add(user);
            Assert.AreEqual(true, dbSession.SaveChanges() >= 1);
        }
    }
}
