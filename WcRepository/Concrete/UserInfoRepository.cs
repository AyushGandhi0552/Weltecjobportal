using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wc.Common;
using Wc.DataEntity;
using Wc.Repository.Interface;

namespace Wc.Repository.Concrete
{
    public class UserInfoRepository : IUSerInfoRepository
    {
        private WeltecContext WeltecContext;
        public UserInfoRepository()
        {
            WeltecContext=new WeltecContext();
        }
        
        public bool AddUserInfo(UserInfo d)
        {
            WeltecContext.UserInfos.Add(d);
            return WeltecContext.SaveChanges() > 0 ? true : false;
        }
        public bool CheckLogin(string email, string password, out UserInfo userinfo)
        {
            var checkuser = WeltecContext.UserInfos.Where(x => x.Email == email).FirstOrDefault();

            var passworde = Helper.EncodePassword(password, checkuser.PasswordSalt);
            if (passworde == checkuser.Password)
            {
                userinfo = checkuser;
                return true;
            }
            else
            {
                userinfo = null;
                return false;
            }

        }
    }
}
