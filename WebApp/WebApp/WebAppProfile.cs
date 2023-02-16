using AutoMapper;
using WebApp.Dto;
using WebApp.Models;

namespace WebApp
{
    public class WebAppProfile: Profile
    {
        public WebAppProfile() 
        {
            CreateMap<Package, PackageDto>().ReverseMap();
            CreateMap<Recipient, RecipientDto>().ReverseMap();
        }
    }
}
