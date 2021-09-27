using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repository;
using Api.Domain.Pagination;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementations
{
    public class ClientImplementations : BaseRepository<ClientEntity>, IClientRepository
    {
        private DbSet<ClientEntity> _dataset;
        public ClientImplementations(MyContext context) : base(context)
        {
            _dataset = context.Set<ClientEntity>();
        }

        public async Task<IEnumerable<ClientEntity>> SelectAsync(PaginationQueryModel paginationQueryModel)
        {
            return await _dataset
                           .OrderBy(x => x.Name)
                           .Skip((paginationQueryModel.PageNumber - 1) * paginationQueryModel.PageSize)
                           .Take(paginationQueryModel.PageSize)
                           .ToListAsync();
        }

    }
}
