using PCITC.OA.Dal;
using PCITC.OA.IBll;
using PCITC.OA.IDal;
using PCITC.OA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCITC.OA.Bll
{
    public class UserInfoServer : BaseServer<UserInfo>, IUserInfoServer
    {
        //IUserInfoDal user = new UserInfoDal();
        //public override void SetBaseDal()
        //{
        //    baseDal = this.CurrentDbSession.GetUserInfoDal;
        //}
    }
}
