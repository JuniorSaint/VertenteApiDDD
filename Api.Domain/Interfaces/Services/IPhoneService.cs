using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Phone;

namespace Api.Domain.Interfaces.Services
{
    public interface IPhoneService
    {
        Task<PhoneDto> Get(Guid id);
        Task<IEnumerable<PhoneDto>> GetAll();
        Task<PhoneDto> Post(PhoneDtoCreate phone);
        Task<PhoneUpdateDtoResult> Put(PhoneDtoUpdate phone);
        Task<bool> Delete(Guid id);
    }
}
