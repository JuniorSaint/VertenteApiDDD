using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Client;
using Api.Domain.Pagination;

namespace Api.Domain.Interfaces.Services
{
    public interface IClientService
    {
        Task<ClientDto> Get(Guid id);
        Task<IEnumerable<ClientDto>> GetAll();
        //Task<PagedList<ClientDto>> GetAllPagination(PaginationQueryModel paginationQueryModel);
        Task<ClientDto> Post(ClientDtoCreate client);
        Task<ClientDto> Put(ClientDtoUpdate client);
        Task<bool> Delete(Guid id);
    }
}
