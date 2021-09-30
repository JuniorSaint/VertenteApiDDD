using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.Address
{
    public class AddressDtoCreate
    {
        [Display(Name = "Rua"),
         Required(ErrorMessage = "O campo {0} é obrigatório"),
        MaxLength(100, ErrorMessage = "Quantidade máxima de caracteres {1}, no campo {0}")]
        public string Street { get; set; }

        [Display(Name = "Tipo de endereço"),
         Required(ErrorMessage = "{0} é campo obrigatório")]
        public string AddressType { get; set; }

        private string _number;
        public string Number
        {
            get { return _number; }
            set { _number = (value.Equals(null) ? "S/N" : value); }
        }

        [Display(Name = "Bairro"),
         Required(ErrorMessage = "{0} de endereço é campo obrigatório")]
        public string District { get; set; }


        public string Complement { get; set; }

        [Display(Name = "Cidade"),
         Required(ErrorMessage = "Campo {0} é obrigatório"),
         MaxLength(90, ErrorMessage = "Quantidade máxima de caracteres {1}")]
        public string City { get; set; }

        [Display(Name = "CEP"),
         Required(ErrorMessage = "{0} é campo obrigatório"),
         MaxLength(8, ErrorMessage = "Quantidade máxima de caracteres {1}")]
        public int ZipCode { get; set; }

        [Display(Name = "Estado"),
            Required(ErrorMessage = "{0} é campo obrigatório")]
        public string State { get; set; }

        [Display(Name = "Id do cliente"),
         Required(ErrorMessage = "{0} é campo obrigatório")]
        public Guid ClientId { get; set; }
    }
}
