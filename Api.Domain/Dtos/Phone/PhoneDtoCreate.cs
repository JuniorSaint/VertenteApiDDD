using System;
using System.ComponentModel.DataAnnotations;
using Api.Domain.Entities;

namespace Api.Domain.Dtos.Phone
{
    public class PhoneDtoCreate
    {

        [Display(Name = "Tipo de telefone"),
            Required(ErrorMessage = "Campo {0} é obrigatório")]
        public string PhoneType { get; set; }

        [Display(Name = "Número de telefone"),
         Required(ErrorMessage = "O campo {0} é obrigatório"),
         Phone(ErrorMessage = "O campo {0} formato errado")]
        public int PhoneNumber { get; set; }

        private string _socialPhone;
        public string SocialPhone
        {
            get { return _socialPhone; }
            set { _socialPhone = (value.Equals(null) ? "Não tem" : value); }
        }

        [Display(Name = "Id do cliente"),
         Required(ErrorMessage = "O campo {0} é obrigatório")]
        public Guid ClientId { get; set; }
        public ClientEntity Client { get; set; }
    }
}
