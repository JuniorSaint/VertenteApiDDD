using System;
using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementations
{
    public class ImagePathImplementation : BaseRepository<ImagePathEntity>, IImagePathRepository
    {
        private DbSet<AddressEntity> _dbSet;
        public ImagePathImplementation(MyContext context): base(context)
        {
            _dbSet = context.Set<AddressEntity>();
        }
    }
}
