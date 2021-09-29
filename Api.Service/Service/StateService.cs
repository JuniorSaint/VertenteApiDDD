using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.State;
using Api.Domain.Interfaces.Repository;
using Api.Domain.Interfaces.Services;
using AutoMapper;

namespace Api.Service.Services
{
    public class StateService : IStateService
    {
        private IStateRepository _repository;
        private readonly IMapper _mapper;

        public StateService(IStateRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<StateDto>> GetAll()
        {
            var result = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<StateDto>>(result);
        }
    }
}
