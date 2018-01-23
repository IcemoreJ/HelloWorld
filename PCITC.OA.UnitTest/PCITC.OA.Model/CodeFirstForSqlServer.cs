using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PCITC.OA.Model;
using System.Data.SqlClient;
namespace PCITC.OA.UnitTest.PCITC.OA.Model
{
    [TestClass]
    public class CodeFirstForSqlServer
    {
        [TestMethod]
        public void TestCRUD()
        {
            using (DataModel db = new DataModel())
            {
                int r;
                //UserInfo user = new UserInfo();
                //user.Id = 2;
                //user.Name = "xiao";
                //user.Gender = "男";
                //user.Phone = "123456";
                //db.UserInfo.Add(user);
                //r =  db.SaveChanges();
                //Assert.AreEqual(true, r >= 1);

                Order order = new Order();
                Order order1 = new Order();
                order.Id = 1;
                order.Name = "IBMPC";
                order.Detail = "IBM的游戏本";
                db.Order.Add(order);
                r = db.SaveChanges();
                //order1.Id = 2;
                //order1.Name = "IPad";
                //order1.Detail = "苹果公司的平板电脑";
                //db.Order.Add(order1);

                //db.SaveChanges();

                Assert.AreEqual(true, r >= 1);
            }
        }
    }
}
