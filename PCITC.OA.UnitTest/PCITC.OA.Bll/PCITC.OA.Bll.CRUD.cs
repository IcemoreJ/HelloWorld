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

            user.UName = "Jerry";
            user.ShowName = "大雄";
            user.Remark = "000000";
            user.Pwd = "123456";
            user.Id = 1;
            user.DelFlag = true;
            userServer.Add(user);
            Assert.AreEqual(true, dbSession.SaveChanges() >= 1);
        }
    }
}
