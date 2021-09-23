using System;
using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementations
{
    public class ProductImplementation : BaseRepository<ProductEntity>, IProductRepository
    {
        private DbSet<ProductEntity> _dbSet;
        public ProductImplementation(MyContext context): base(context)
        {
            _dbSet = context.Set<ProductEntity>();
        }
    }
}
