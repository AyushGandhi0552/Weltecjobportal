using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wc.DataEntity;
using Wc.Repository.Concrete;

namespace Wc.Repository.Interface
{
    public interface IUSerInfoRepository
    {
        bool AddUserInfo(UserInfo d);
        bool CheckLogin(string email, string password, out UserInfo userinfo);
        

    }
}
