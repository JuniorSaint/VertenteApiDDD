using System;
using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementations
{
    public class ClientImplementations : BaseRepository<ClientEntity>, IClientRepository
    {
        private DbSet<ClientEntity> _dbset;
        public ClientImplementations(MyContext context): base(context)
        {
            _dbset = context.Set<ClientEntity>();
        }
    }
}
