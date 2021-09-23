using System;
using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementations
{
    public class AddressImplementation : BaseRepository<AddressEntity>, IAddressRepository
    {
        private DbSet<AddressEntity> _dbSet;
        public AddressImplementation(MyContext context): base(context)
        {
            _dbSet = context.Set<AddressEntity>();
        }
    }
}
