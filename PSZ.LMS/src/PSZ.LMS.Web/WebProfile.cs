using AutoMapper;
using PSZ.LMS.Domain.Entities;
using PSZ.LMS.Web.Areas.Admin.Models;

namespace PSZ.LMS.Web
{
    public class WebProfile : Profile
    {
        public WebProfile()
        {
            CreateMap<AddCategoryModel, Category>().ReverseMap();
        }
    }
}
