using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public class ProductWithTypeAndBrendSpecification : BaseSpecification<Products>
    {
        public ProductWithTypeAndBrendSpecification(ProductSpesParams productParams)
            : base(x => 
            (string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search)) &&
            (!productParams.BrandId.HasValue || x.ProductBrandId == productParams.BrandId) &&
            (!productParams.TypeId.HasValue || x.ProductTypeId == productParams.TypeId))
            
        {

           
            AddIncludes(x => x.ProductType);
            AddIncludes(x => x.ProductBrand);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1), productParams.PageSize);
            AddOrderBy(x => x.Name);
            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "ProceAsc":
                        AddOrderBy(p => p.Price);
                        break;

                    case "PriceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(p => p.Name);
                        break;
                }
            }
        }
        public ProductWithTypeAndBrendSpecification(int id) : base(c => c.Id == id)
        {
            AddIncludes(x => x.ProductType);
            AddIncludes(x => x.ProductBrand);
        }
    }
}
