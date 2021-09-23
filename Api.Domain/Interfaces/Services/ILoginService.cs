﻿using System;
using System.Threading.Tasks;
using Api.Domain.Dtos.Login;

namespace Api.Domain.Interfaces.Services
{
    public interface ILoginService
    {
        Task<object> FindByLogin(LoginDto user);
    }
}
