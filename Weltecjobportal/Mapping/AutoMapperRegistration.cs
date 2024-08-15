using AutoMapper;
using Wc.BusinessENtity;
using Wc.DataEntity;

namespace Weltecjobportal.Mapping
{
    public class AutoMapperRegistration : Profile
    {
        public AutoMapperRegistration()
        {
            CreateMap<RegistrationViewModel, UserInfo>().ReverseMap();
        }
       
    }
}
