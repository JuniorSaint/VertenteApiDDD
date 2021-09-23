using System;
using System.Collections.Generic;
using Api.Domain.Dtos.Address;
using Api.Domain.Dtos.Phone;

namespace Api.Domain.Dtos.Client
{
    public class ClientDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Cpf_Cnpj { get; set; }
        public string Email { get; set; }
        public string Note { get; set; } 
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public IEnumerable<AddressDto> Addresses { get; set; }

        public IEnumerable<PhoneDto> Phones { get; set; }
    }
}

