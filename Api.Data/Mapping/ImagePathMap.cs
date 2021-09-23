using System;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class ImagePathMap
    {
        public void Configure(EntityTypeBuilder<ImagePathEntity> builder)
        {
            builder.ToTable("ImagePath");
            builder.HasKey(u => u.Id);
            builder.HasIndex(u => u.ImagePath);
        }
    }
}
