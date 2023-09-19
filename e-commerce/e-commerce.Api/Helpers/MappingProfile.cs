using AutoMapper;
using Core.Entities;
using e_commerce.Api.Dtos;

namespace e_commerce.Api.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Products, ProductToReturnDto>()
                .ForMember(d => d.ProductBrand, o => o.MapFrom(x => x.ProductBrand.Name))
                 .ForMember(d => d.ProductType, o => o.MapFrom(x => x.ProductType.Name))
                 .ForMember(d=>d.PictureUrl,o=>o.MapFrom<ProductUrlResolver>());
        }
    }
}
