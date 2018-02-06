using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PCITC.OA.DalFactory;
using PCITC.OA.IDal;
using PCITC.OA.Model;

namespace PCITC.OA.UnitTest.PCITC.OA.Dal
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CRUD()
        {
            IDbSession dbSession = DbSessionFactory.GetCurrentDbSession();

            IUserInfoDal userDal = dbSession.GetUserInfoDal;
            UserInfo user = new UserInfo();
            user.UName = "Jerry";
            user.ShowName = "大雄";
            user.Remark = "000000";
            user.Pwd = "123456";
            user.Id = 1;
            user.DelFlag = true;
            #region 增加
            //userDal.Add(user);
            // Assert.AreEqual(true, dbSession.SaveChanges() >= 1);
            #endregion
            #region 删除
            //userDal.Delete(new UserInfo { Id = 2 });
            //Assert.AreEqual(true, dbSession.SaveChanges() >= 1); 
            #endregion
            //修改
            userDal.Updata(new UserInfo { Id = 3, UName = "Tom", ShowName = "大雄", Pwd = "000000" });
            Assert.AreEqual(true, dbSession.SaveChanges() >= 1);
        }
    }
}
