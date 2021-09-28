
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.ProductType;
using Api.Domain.Interfaces.Repositories;
using Api.Domain.Interfaces.Services;
using AutoMapper;

namespace Api.Service.Services
{
    public class ProductTypeService : IProductTypeService
    {
        private IProductTypeRepository _repository;
        private readonly IMapper _mapper;

        public ProductTypeService(IProductTypeRepository repository,
            IMapper mapper
            )
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task<ProductTypeDto> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductTypeDto>> GetAll()
        {
            var listAll = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<ProductTypeDto>>(listAll);
        }

        public Task<ProductTypeDto> Post(ProductTypeCreateDto product)
        {
            throw new NotImplementedException();
        }

        public Task<ProductTypeUpdateDtoResult> Put(ProductTypeUpdateDto product)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
