using System;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class ClientMap: IEntityTypeConfiguration<ClientEntity>
    {
        public void Configure(EntityTypeBuilder<ClientEntity> builder)
        {
            builder.ToTable("Client");
            builder.HasKey(c => c.Id);
            builder.HasIndex(c => c.Name);
            builder.HasMany(c => c.Addresses).WithOne(a => a.Client);
            builder.HasMany(c => c.Phones).WithOne(p => p.Client);
        }
    }
}
