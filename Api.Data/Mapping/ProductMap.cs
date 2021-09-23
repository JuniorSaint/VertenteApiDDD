using System;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class ProductMap
    {
        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(p => p.Id);
            builder.HasIndex(p => p.ProductName).IsUnique();
            builder.HasIndex(p => p.ProductCode).IsUnique();
            builder.HasMany(p => p.ImagePaths).WithOne(i => i.Product);
        }

    }
}
