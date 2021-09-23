using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class AddressEntity : BaseEntity
    {
        [Required]
        [MaxLength(100, ErrorMessage = "Quantidade máxima de caracteres {1}")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Tipo de endereço é campo obrigatório")]
        public string AddressType { get; set; }

        private string _number;
        public string Number
        {
            get { return _number; }
            set { _number = (value.Equals(null) ? "S/N" : value); }
        }

        [Required(ErrorMessage = "Bairro de endereço é campo obrigatório")]
        public string District { get; set; }

        
        public string Complement { get; set; }

        [Required]
        [MaxLength(90, ErrorMessage = "Quantidade máxima de caracteres {1}")]
        public string City { get; set; }

        [Required]
        [MaxLength(8, ErrorMessage = "Quantidade máxima de caracteres {1}")]
        public int ZipCode { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public Guid ClientId { get; set; }
        public ClientEntity Client { get; set; }
    }
}
