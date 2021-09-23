using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.ImagePath;

namespace Api.Domain.Interfaces.Services
{
    public interface IImagePathService
    {
        Task<ImagePathDto> Get(Guid id);
        Task<IEnumerable<ImagePathDto>> GetAll();
        Task<ImagePathDto> Post(ImagePathDtoCreate client);
        Task<ImagePathDto> Put(ImagePathDtoUpdate client);
        Task<bool> Delete(Guid id);
    }
}
