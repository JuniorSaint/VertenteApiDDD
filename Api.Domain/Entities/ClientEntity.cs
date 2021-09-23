using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class ClientEntity : BaseEntity
    {
        [Required(ErrorMessage = "Campo Nome é campo obrigatório")]
        [MaxLength(90, ErrorMessage = "Quantidade máxima de caracteres {1}")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Campo Cnpj/Cpf é campo obrigatório")]
        public int Cpf_Cnpj { get; set; }

        [EmailAddress(ErrorMessage = "Campo email com formato inválido")]
        public string Email { get; set; }

        public string Note { get; set; }

        public IEnumerable<PhoneEntity> Phones { get; set; }

        public IEnumerable<AddressEntity> Addresses { get; set; }

    }
}
