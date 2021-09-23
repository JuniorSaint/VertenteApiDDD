using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Address;

namespace Api.Domain.Interfaces.Services
{
    public interface IAddressService
    {
        Task<AddressDto> Get(Guid id);
        Task<IEnumerable<AddressDto>> GetAll();
        Task<AddressDto> Post(AddressDtoCreate client);
        Task<AddressDto> Put(AddressDtoUpdate client);
        Task<bool> Delete(Guid id);
    }
}
