using AutoMapper;
using ReAuthServer.Dtos;
using ReAuthServer.Models;

namespace ReAuthServer.Profiles
{
    public class ReAuthsProfile : Profile
    {
        public ReAuthsProfile()
        {
            CreateMap<ReAuthFormData, ReadReAuthFormDataDto>();
            CreateMap<CreateReAuthFormDataDto, ReAuthFormData>();
        }
        
    }
}