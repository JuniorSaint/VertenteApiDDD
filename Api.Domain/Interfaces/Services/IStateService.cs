using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.State;

namespace Api.Domain.Interfaces.Services
{
    public interface IStateService
    {

        Task<IEnumerable<StateDto>> GetAll();
    }
}
