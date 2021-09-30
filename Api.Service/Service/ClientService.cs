using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Client;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repository;
using Api.Domain.Interfaces.Services;
using Api.Domain.Models;
using AutoMapper;

namespace Api.Service.Service
{
    public class ClientService : IClientService
    {
        private IClientRepository _repository;
        private IMapper _mapper;

        public ClientService(IClientRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<ClientDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsyncComplete(id);
            return _mapper.Map<ClientDto>(entity);
        }

        public async Task<IEnumerable<ClientDto>> GetAll()
        {
            var entity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<ClientDto>>(entity);
        }

        //public async Task<PagedList<ClientDto>> GetAllPagination(PaginationQueryModel paginationQueryModel)
        //{
        //    var entity = _repository.SelectAsync();
        //    //var result = _mapper.Map<PagedList<ClientDto>>(entity);
        //    return await PagedList<ClientDto>.ToPagedList(_mapper.Map<PagedList<ClientDto>>(entity).OrderBy(x => x.Name), paginationQueryModel.PageNumber, paginationQueryModel.PageSize);

        //}

        public async Task<ClientDto> Post(ClientDtoCreate client)
        {
            var model = _mapper.Map<ClientModel>(client);
            var entity = _mapper.Map<ClientEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<ClientDto>(result);
        }

        public async Task<ClientDto> Put(ClientDtoUpdate client)
        {
            var model = _mapper.Map<ClientModel>(client);
            var entity = _mapper.Map<ClientEntity>(model);
            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<ClientDto>(result);
        }
    }
}
