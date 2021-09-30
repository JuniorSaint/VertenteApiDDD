using System;
using Api.Domain.Dtos.Client;

namespace Api.Domain.Dtos.Phone
{
    public class PhoneUpdateDtoResult
    {
        public Guid Id { get; set; }
        public string PhoneType { get; set; }
        public int PhoneNumber { get; set; }
        public string Social { get; set; }
    }
}
