using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Api.Domain.Dtos.Address;
using Api.Domain.Dtos.Phone;

namespace Api.Domain.Dtos.Client
{
    public class ClientDtoUpdate
    {
        [Display(Name = "Id"),
         Required(ErrorMessage = "Campo {0} é obrigatório")]
        public Guid Id { get; set; }

        [Display(Name = "Nome do cliente"),
         Required(ErrorMessage = "Campo {0} é campo obrigatório"),
         MaxLength(90, ErrorMessage = "Quantidade máxima de caracteres {1}")]
        public string Name { get; set; }

        [Display(Name = "Cpf ou Cnpj"),
         Required(ErrorMessage = "Campo {0} é campo obrigatório")]
        public int Cpf_Cnpj { get; set; }

        [Display(Name = "e-mail"),
         EmailAddress(ErrorMessage = "Campo {0} com formato inválido")]
        public string Email { get; set; }

        public string Note { get; set; }

        public IEnumerable<PhoneDto> Phones { get; set; }

        public IEnumerable<AddressDto> Addresses { get; set; }
    }
}
