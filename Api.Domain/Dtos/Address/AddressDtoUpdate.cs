using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.Address
{
    public class AddressDtoUpdate
    {
        [Required(ErrorMessage = "Campo Id é obrigatório")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Rua é campo obrigatório")]
        [MaxLength(90, ErrorMessage = "Quantidade máxima de caracteres {1}")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Tipo de endereço é campo obrigatório")]
        public string AddressType { get; set; }

        public string Number { get; set; }

        [Required(ErrorMessage = "Bairro é campo obrigatório")]
        [MaxLength(40, ErrorMessage = "Quantidade máxima de caracteres {1}")]
        public string District { get; set; }

        public string Complement { get; set; }

        [Required(ErrorMessage = "Cidade é campo obrigatório")]
        [MaxLength(80, ErrorMessage = "Quantidade máxima de caracteres {1}")]
        public string City { get; set; }

        [Required(ErrorMessage = "Cep é campo obrigatório")]
        [MaxLength(8, ErrorMessage = "Quantidade máxima de caracteres {1}")]
        public int ZipCode { get; set; }

        [Required(ErrorMessage = "Rua é campo obrigatório")]
        public string State { get; set; }

        [Required(ErrorMessage = "Campo Id do Cliente é obrigatório")]
        public Guid ClientId { get; set; }
    }
}
