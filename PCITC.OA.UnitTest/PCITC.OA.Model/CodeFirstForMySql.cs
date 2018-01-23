using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PCITC.OA.Model;
using PCITC.OA.IDal;
using PCITC.OA.Dal;

namespace PCITC.OA.UnitTest.PCITC.OA.Model
{
    [TestClass]
    public class CodeFirstForMySql
    {
        [TestMethod]
        public void TestCRUD()
        {
            #region 测试是否可以连接
            //using (DataModel db = new DataModel())
            //{
            //    int r;
            //    UserInfo user = new UserInfo();
            //    //代码中设置主键了，所以该行指定也不起效果
            //    //user.Id = 2;
            //    user.Name = "xiao";
            //    user.Gender = "男";
            //    user.Phone = "123456";
            //    db.UserInfo.Add(user);
            //    r =  db.SaveChanges();
            //    Assert.AreEqual(true, r >= 1);

            //    Order order = new Order();
            //    Order order1 = new Order();
            //    //order.Id = 3;
            //    order.Name = "IBMPC";
            //    order.Detail = "IBM的游戏本";
            //    db.Order.Add(order);
            //    //order1.Id = 4;
            //    order1.Name = "IPad";
            //    order1.Detail = "苹果公司的平板电脑";
            //    db.Order.Add(order1);

            //    r = db.SaveChanges();

            //    Assert.AreEqual(true, r >= 1);
            //} 
            #endregion

            IDal.IOrderDal baseDal = new OrderDal();
            Order order = baseDal.Add(new Order { Name = "橘子", Detail = "很好吃" });
            //Assert.AreEqual(true, baseDal.Delete(order));
        }
    }
}
