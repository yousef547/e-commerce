using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public class ProductWithTypeAndBrendSpecification:BaseSpecification<Products>
    {
        public ProductWithTypeAndBrendSpecification()
        {
            AddIncludes(x => x.ProductType);
            AddIncludes(x => x.ProductBrand);
        }
        public ProductWithTypeAndBrendSpecification(int id):base(c=>c.Id == id)
        {
            AddIncludes(x => x.ProductType);
            AddIncludes(x => x.ProductBrand);
        }
    }
}
