using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Phone;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services;
using Api.Domain.Models;
using AutoMapper;

namespace Api.Service.Services
{
    public class PhoneService : IPhoneService
    {
        private IRepository<PhoneEntity> _repository;
        private readonly IMapper _mapper;
        public PhoneService(IRepository<PhoneEntity> repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<IEnumerable<PhoneDto>> GetAll()
        {
            var result = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<PhoneDto>>(result);
        }

        public async Task<PhoneDto> Get(Guid id)
        {
            var result = await _repository.SelectAsync(id);
            return _mapper.Map<PhoneDto>(result);
        }

        public async Task<PhoneDto> Post(PhoneDtoCreate phone)
        {
            var model = _mapper.Map<PhoneModel>(phone);
            var entity = _mapper.Map<PhoneEntity>(model);
            var result = await _repository.InsertAsync(entity);
            return _mapper.Map<PhoneDto>(result);
        }

        public async Task<PhoneUpdateDtoResult> Put(PhoneDtoUpdate phone)
        {
            var model = _mapper.Map<PhoneModel>(phone);
            var entity = _mapper.Map<PhoneEntity>(model);
            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<PhoneUpdateDtoResult>(result);
        }

        public async Task<bool> Delete( Guid id)
        {
            return await _repository.DeleteAsync(id);
        }    
    }
}
