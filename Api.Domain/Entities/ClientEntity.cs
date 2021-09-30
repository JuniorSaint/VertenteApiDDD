using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class ClientEntity : BaseEntity
    {
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

        public IEnumerable<PhoneEntity> Phones { get; set; }

        public IEnumerable<AddressEntity> Addresses { get; set; }

    }
}
