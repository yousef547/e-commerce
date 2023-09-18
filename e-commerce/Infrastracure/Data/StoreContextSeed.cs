using Core.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Infrastracure.Data
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync(StoreContext context)
        {
            if (!context.ProductBrands.Any())
            {

                List<ProductBrand> brands = new List<ProductBrand> {
   new ProductBrand {
    Id= 1,
    Name= "Angular"
  },
   new ProductBrand {
    Id= 2,
    Name= "NetCore"
  },
   new ProductBrand {
    Id= 3,
    Name= "VS Code"
  },
   new ProductBrand {
    Id= 4,
    Name= "React"
  },
   new ProductBrand {
    Id= 5,
    Name= "Typescript"
  },
   new ProductBrand {
    Id= 6,
    Name= "Redis"
  }
  };

                foreach (var brand in brands)
                {
                    await context.ProductBrands.AddAsync(brand);
                }
                context.SaveChanges();
            }
            //            if (!context.ProductTypes.Any())
            //            {

            //                var types = new List<ProductType>
            //                {
            //                      new ProductType{
            //    Id= 1,
            //    Name= "Boards"
            //  },

            //  new ProductType{
            //    Id = 2,
            //    Name = "Hats"
            //  },
            //  new ProductType{
            //    Id = 3,
            //    Name = "Boots"
            //  },
            //  new ProductType{
            //    Id= 4,
            //    Name= "Gloves"
            //  }
            //};
            //                context.ProductTypes.AddRange(types);
            //                await context.SaveChangesAsync();
            //            }

            //            if (!context.products.Any())
            //            {

            //                var products = new List<Products>
            //                {
            //                     new Products {
            //    Name= "Angular Speedster Board 2000",
            //    Description= "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
            //    Price= 200,
            //    PictureUrl= "images/products/sb-ang1.png",
            //    ProductTypeId= 1,
            //    ProductBrandId= 1
            //  },
            //  new Products {
            //    Name= "Green Angular Board 3000",
            //    Description= "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
            //    Price= 150,
            //    PictureUrl= "images/products/sb-ang2.png",
            //    ProductTypeId= 1,
            //    ProductBrandId= 1
            //  },
            //  new Products {
            //    Name= "Core Board Speed Rush 3",
            //    Description= "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
            //    Price= 180,
            //    PictureUrl= "images/products/sb-core1.png",
            //    ProductTypeId= 1,
            //    ProductBrandId= 2
            //  },
            //  new Products {
            //    Name= "Net Core Super Board",
            //    Description= "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
            //    Price= 300,
            //    PictureUrl= "images/products/sb-core2.png",
            //    ProductTypeId= 1,
            //    ProductBrandId= 2
            //  },
            //  new Products {
            //    Name= "React Board Super Whizzy Fast",
            //    Description= "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
            //    Price= 250,
            //    PictureUrl= "images/products/sb-react1.png",
            //    ProductTypeId= 1,
            //    ProductBrandId= 4
            //  },
            //  new Products {
            //    Name= "Typescript Entry Board",
            //    Description= "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
            //    Price= 120,
            //    PictureUrl= "images/products/sb-ts1.png",
            //    ProductTypeId= 1,
            //    ProductBrandId= 5
            //  },
            //  new Products {
            //    Name= "Core Blue Hat",
            //    Description= "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
            //    Price= 10,
            //    PictureUrl= "images/products/hat-core1.png",
            //    ProductTypeId= 2,
            //    ProductBrandId= 2
            //  },
            //  new Products {
            //    Name= "Green React Woolen Hat",
            //    Description= "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
            //    Price= 8,
            //    PictureUrl= "images/products/hat-react1.png",
            //    ProductTypeId= 2,
            //    ProductBrandId= 4
            //  },
            //  new Products {
            //    Name= "Purple React Woolen Hat",
            //    Description= "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
            //    Price= 15,
            //    PictureUrl= "images/products/hat-react2.png",
            //    ProductTypeId= 2,
            //    ProductBrandId= 4
            //  },
            //  new Products {
            //    Name= "Blue Code Gloves",
            //    Description= "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
            //    Price= 18,
            //    PictureUrl= "images/products/glove-code1.png",
            //    ProductTypeId= 4,
            //    ProductBrandId= 3
            //  },
            //  new Products {
            //    Name= "Green Code Gloves",
            //    Description= "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
            //    Price= 15,
            //    PictureUrl= "images/products/glove-code2.png",
            //    ProductTypeId= 4,
            //    ProductBrandId= 3
            //  },
            //  new Products {
            //    Name= "Purple React Gloves",
            //    Description= "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa.",
            //    Price= 16,
            //    PictureUrl= "images/products/glove-react1.png",
            //    ProductTypeId= 4,
            //    ProductBrandId= 4
            //  },
            //  new Products {
            //    Name= "Green React Gloves",
            //    Description= "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
            //    Price= 14,
            //    PictureUrl= "images/products/glove-react2.png",
            //    ProductTypeId= 4,
            //    ProductBrandId= 4
            //  },
            //  new Products {
            //    Name= "Redis Red Boots",
            //    Description= "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
            //    Price= 250,
            //    PictureUrl= "images/products/boot-redis1.png",
            //    ProductTypeId= 3,
            //    ProductBrandId= 6
            //  },
            //  new Products {
            //    Name= "Core Red Boots",
            //    Description= "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
            //    Price= (decimal)189.99,
            //    PictureUrl= "images/products/boot-core2.png",
            //    ProductTypeId= 3,
            //    ProductBrandId= 2
            //  },
            //  new Products {
            //    Name= "Core Purple Boots",
            //    Description= "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
            //    Price= (decimal)199.99,
            //    PictureUrl= "images/products/boot-core1.png",
            //    ProductTypeId= 3,
            //    ProductBrandId= 2
            //  },
            //  new Products {
            //    Name= "Angular Purple Boots",
            //    Description= "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
            //    Price= 150,
            //    PictureUrl= "images/products/boot-ang2.png",
            //    ProductTypeId= 3,
            //    ProductBrandId= 1
            //  },
            //  new Products {
            //    Name= "Angular Blue Boots",
            //    Description= "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
            //    Price= 180,
            //    PictureUrl= "images/products/boot-ang1.png",
            //    ProductTypeId= 3,
            //    ProductBrandId= 1
            //  }
            //                };
            //                context.products.AddRange(products);
            //                await context.SaveChangesAsync();
            //            }
            //if (context.ChangeTracker.HasChanges()) await context.SaveChangesAsync();
            //await context.SaveChangesAsync();
        }
    }
}
