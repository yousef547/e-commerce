using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public class ProductWithFilterCountSepecification:BaseSpecification<Products>
      
    {
        public ProductWithFilterCountSepecification(ProductSpesParams productSpesParams)
             : base(x =>
             (string.IsNullOrEmpty(productSpesParams.Search) || x.Name.ToLower().Contains(productSpesParams.Search))&&
             (!productSpesParams.BrandId.HasValue || x.ProductBrandId == productSpesParams.BrandId)&&
                 (!productSpesParams.TypeId.HasValue || x.ProductTypeId == productSpesParams.TypeId))
        {
                
        }

    }
}
