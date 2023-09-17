﻿using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastracure.Data
{
    public class StoreContext:DbContext
    {
        public StoreContext(DbContextOptions options):base(options)
        {
                
        }
        public DbSet<Products> products { get; set; }
        public DbSet<ProductBrand> ProductBrands { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
    }
}
