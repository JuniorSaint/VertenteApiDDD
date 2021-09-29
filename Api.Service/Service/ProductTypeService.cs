
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.ProductType;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repositories;
using Api.Domain.Interfaces.Services;
using Api.Domain.Models;
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

        public async Task<ProductTypeDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<ProductTypeDto>(entity);
        }

        public async Task<IEnumerable<ProductTypeDto>> GetAll()
        {
            var listAll = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<ProductTypeDto>>(listAll);
        }

        public async Task<ProductTypeDto> Post(ProductTypeCreateDto product)
        {
            var model = _mapper.Map<ProductTypeModel>(product);
            var entity = _mapper.Map<ProductTypeEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<ProductTypeDto>(result);
        }

        public async Task<ProductTypeUpdateDtoResult> Put(ProductTypeUpdateDto product)
        {
            var model = _mapper.Map<ProductTypeModel>(product);
            var entity = _mapper.Map<ProductTypeEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<ProductTypeUpdateDtoResult>(result);
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
