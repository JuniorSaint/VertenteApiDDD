using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementation
{
    public class ProductTypeImplementation : BaseRepository<ProductTypeEntity>, IProductTypeRepository
    {
        private DbSet<ProductTypeEntity> _dataset;

        public ProductTypeImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<ProductTypeEntity>();

        }
    }
}
