using System;
using Api.Domain.Dtos.Address;
using Api.Domain.Dtos.Phone;

namespace Api.Domain.Dtos.Client
{
    public class ClientDtoCreateResult
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Cpf_Cnpj { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public Guid PhoneId { get; set; }
        public PhoneDto Phones { get; set; }
        public Guid AddressId { get; set; }
        public AddressDto Addresses { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
