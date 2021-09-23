using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.State;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services;
using AutoMapper;

namespace Api.Service.Services
{
    public class StateService : IStateService
    {
        private IRepository<StatesEntity> _repository;
        private readonly IMapper _mapper;

        public StateService(IRepository<StatesEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<StateDto> Get(Guid id)
        {
            var result =  await _repository.SelectAsync(id);
            return _mapper.Map<StateDto>(result);
        }

        public async Task<IEnumerable<StateDto>> GetAll()
        {
            var result = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<StateDto>>(result);
        }
    }
}
