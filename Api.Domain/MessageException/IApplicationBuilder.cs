using System;

namespace Api.Domain.MessageException
{
    public interface IApplicationBuilder
    {
        void UseExceptionHandler(Action<object> p);
    }
}