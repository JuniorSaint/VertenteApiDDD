using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.ProductType;

namespace Api.Domain.Interfaces.Services
{
    public interface IProductTypeService
    {
        Task<ProductTypeDto> Get(Guid id);
        Task<IEnumerable<ProductTypeDto>> GetAll();
        Task<ProductTypeDto> Post(ProductTypeCreateDto product);
        Task<ProductTypeUpdateDtoResult> Put(ProductTypeUpdateDto product);
        Task<bool> Delete(Guid id);
    }
}
