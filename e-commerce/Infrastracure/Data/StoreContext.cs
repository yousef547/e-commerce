﻿using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Reflection;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //if (Database.ProviderName == "Microsoft.EntityFrameworkCore.SqlServer")
            //{
            //    foreach(var entityType in modelBuilder.Model.GetEntityTypes())
            //    {
            //        var properties = entityType.ClrType.GetProperties().Where(p=>p.PropertyType == typeof(decimal));
            //        foreach(var property in properties)
            //        {
            //            modelBuilder.Entity(entityType.Name).Property(property.Name).HasConversion<double>();
            //        }
            //    }
            //}
        }
    }
}
