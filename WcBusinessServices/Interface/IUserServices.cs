using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wc.BusinessENtity;
using Wc.DataEntity;

namespace Wc.BusinessServices.Interface
{
    public interface IUserServices
    {
        bool AddUserInfo(RegistrationViewModel registrationViewModel);

        bool CheckLogin(string email, string password, out RegistrationViewModel userinfo);
    }
}
