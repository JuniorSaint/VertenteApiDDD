using System;
using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementations
{
    public class StateImplementation : BaseRepository<StatesEntity>, IStateRepository
    {
        private DbSet<StatesEntity> _dbSet;
        public StateImplementation(MyContext context) : base(context)
        {
            _dbSet = context.Set<StatesEntity>();
        }
    }
}
