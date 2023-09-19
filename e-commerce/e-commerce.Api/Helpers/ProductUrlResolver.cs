using AutoMapper;
using AutoMapper.Execution;
using Core.Entities;
using e_commerce.Api.Dtos;

namespace e_commerce.Api.Helpers
{
    public class ProductUrlResolver : IValueResolver<Products, ProductToReturnDto, string>
    {
        private readonly IConfiguration _configuration;
        public ProductUrlResolver(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string Resolve(Products source, ProductToReturnDto destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.PictureUrl))
            {
                return _configuration["ApiUrl"] + source.PictureUrl;
            }else
            {
                return null;
            }
        }
    }
}
