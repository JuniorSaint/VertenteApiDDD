using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.ImagePath;
using Api.Domain.Dtos.Product;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repository;
using Api.Domain.Interfaces.Services;
using Api.Domain.Models;
using AutoMapper;

namespace Api.Service.Service
{
    public class ImagePathService : IImagePathService
    {
        private IImagePathRepository _repository;
        private readonly IMapper _mapper;

        public ImagePathService(
            IImagePathRepository repository,
            IMapper mapper
            )
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<ImagePathDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<ImagePathDto>(entity);
        }

        public async Task<IEnumerable<ImagePathDto>> GetAll()
        {
            var listAll = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<ImagePathDto>>(listAll);
        }

        public async Task<ImagePathDto> Post(ImagePathDtoCreate product)
        {
            var model = _mapper.Map<ImagePathModel>(product);
            var entity = _mapper.Map<ImagePathEntity>(model);
            var result = await _repository.InsertAsync(entity);
            return _mapper.Map<ImagePathDto>(result);
        }

        public async Task<ImagePathDto> Put(ImagePathDtoUpdate product)
        {
            var model = _mapper.Map<ImagePathModel>(product);
            var entity = _mapper.Map<ImagePathEntity>(model);
            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<ImagePathDto>(result);
        }
    }
}
