using System;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Repository
{
    public interface IClientRepository : IRepository<ClientEntity>
    {
        Task<ClientEntity> SelectAsyncComplete(Guid id);
    }
}
