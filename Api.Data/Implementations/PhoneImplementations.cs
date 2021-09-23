using System;
using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementations
{
    public class PhoneImplementations : BaseRepository<PhoneEntity>, IPhoneRepository
    {
        private DbSet<PhoneEntity> _dbSet;
        public PhoneImplementations(MyContext context): base(context)
        {
            _dbSet = context.Set<PhoneEntity>();
        }
    }
}
