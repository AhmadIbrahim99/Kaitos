using AutoMapper;
using Kaitos.Models;
using Kaitos.ViewModels.AboutUsVM;
using Kaitos.ViewModels.ContactUsVM;

namespace Kaitos.Data.Mapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            #region ContactUs
            CreateMap<ContactUs, ContactUsCreateVM>().ReverseMap();
            #endregion

            #region AboutUs
            CreateMap<AboutUs, AboutUsCreateVm>().ReverseMap();
            CreateMap<AboutUs, AboutUsUpdateVm>().ReverseMap();
            #endregion        
        }
    }
}
