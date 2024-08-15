using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wc.BusinessENtity;
using Wc.BusinessServices.Interface;
using Wc.Common;
using Wc.DataEntity;
using Wc.Repository.Concrete;
using Wc.Repository.Interface;

namespace Wc.BusinessServices.Concrete
{
    public class UserService : IUserServices
    {
       private readonly IUSerInfoRepository _uSerInfoRepository;
       private readonly IMapper _mapper;
        public UserService(IUSerInfoRepository uSerInfoRepository, IMapper mapper)
        {
            _mapper =mapper;
            _uSerInfoRepository = uSerInfoRepository;   
        }
        public bool AddUserInfo(RegistrationViewModel registrationViewModel)
        {
            var user = _mapper.Map<UserInfo>(registrationViewModel);

            var pass = Helper.Generatekey(7);
            user.PasswordSalt = pass;
            user.Password = Helper.EncodePassword(registrationViewModel.Password, pass);

            var p = _uSerInfoRepository.AddUserInfo(user);
            return p;
        }

        public bool CheckLogin(string email, string password, out RegistrationViewModel userinfo)
        {
            var de = new UserInfo();
            var d = _uSerInfoRepository.CheckLogin(email, password, out de);
            userinfo = _mapper.Map<RegistrationViewModel>(d);
            return d;
        }
    }
}
