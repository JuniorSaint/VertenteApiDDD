using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Client;

namespace Api.Domain.Interfaces.Services
{
    public interface IClientService
    {
        Task<ClientDto> Get(Guid id);
        Task<IEnumerable<ClientDto>> GetAll();
        Task<ClientDto> Post(ClientDtoCreate client);
        Task<ClientDto> Put(ClientDtoUpdate client);
        Task<bool> Delete(Guid id);
    }
}
