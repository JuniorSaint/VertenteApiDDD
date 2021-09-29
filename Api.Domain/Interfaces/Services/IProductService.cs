using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Product;

namespace Api.Domain.Interfaces.Services
{
    public interface IProductService
    {
        Task<ProductDto> Get(Guid id);
        Task<IEnumerable<ProductDto>> GetAll();
        Task<ProductDto> Post(ProductDtoCreate product);
        Task<ProductUpdateDtoResult> Put(ProductDtoUpdate product);
        Task<bool> Delete(Guid id);
    }
}
