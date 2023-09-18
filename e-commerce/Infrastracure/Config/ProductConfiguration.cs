﻿using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastracure.Config
{
    public class ProductConfiguration : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.Property(p=>p.Id).IsRequired();
            builder.Property(p=>p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p=>p.Description).IsRequired();
            builder.Property(p=>p.Price).HasColumnType("decimal");
            builder.Property(p=>p.PictureUrl).IsRequired();
            builder.HasOne(p=>p.ProductBrand).WithMany().HasForeignKey(p=>p.ProductBrandId);
            builder.HasOne(p=>p.ProductType).WithMany().HasForeignKey(p=>p.ProductTypeId);
        }
    }
}
