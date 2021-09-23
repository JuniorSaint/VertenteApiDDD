using System;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class StateMap
    {
        public void Configure(EntityTypeBuilder<StatesEntity> builder)
        {
            builder.ToTable("State");
            builder.HasKey(s => s.Id);
            builder.HasIndex(s => s.Sigla);
        }
    }
}
