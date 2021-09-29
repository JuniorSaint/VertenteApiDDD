using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Address;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repository;
using Api.Domain.Interfaces.Services;
using Api.Domain.Models;
using AutoMapper;

namespace Api.Service.Service
{
    public class AddressService : IAddressService
    {
        private IMapper _mapper;
        private IAddressRepository _repository;
        public AddressService(IAddressRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<AddressDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<AddressDto>(entity);
        }

        public async Task<IEnumerable<AddressDto>> GetAll()
        {
            var entity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<AddressDto>>(entity);
        }

        public async Task<AddressDto> Post(AddressDtoCreate address)
        {
            var model = _mapper.Map<AddressModel>(address);
            var entity = _mapper.Map<AddressEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<AddressDto>(result);
        }

        public async Task<AddressDto> Put(AddressDtoUpdate address)
        {
            var model = _mapper.Map<AddressModel>(address);
            var entity = _mapper.Map<AddressEntity>(model);
            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<AddressDto>(result);
        }
    }
}

