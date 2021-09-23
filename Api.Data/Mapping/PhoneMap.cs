using System;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class PhoneMap
    {
        public void Configure(EntityTypeBuilder<PhoneEntity> builder)
        {
            builder.ToTable("Phone");
            builder.HasKey(p => p.Id);
            builder.HasIndex(p => p.ClientId);
        }
    }
}
