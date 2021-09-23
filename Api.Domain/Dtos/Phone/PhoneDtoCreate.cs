using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.Phone
{
    public class PhoneDtoCreate
    {        

        [Required(ErrorMessage = "Tipo de Telefone é campo obrigatório")]
        public string PhoneType { get; set; }

        [Required(ErrorMessage = "Número de Telefone é campo obrigatório")]
        public int PhoneNumber { get; set; }

        [Required(ErrorMessage = "Tem rede social de Telefone é campo obrigatório")]
        public string SocialPhone { get; set; }

        [Required(ErrorMessage = "Id do cliente é campo obrigatório")]
        public Guid ClientId { get; set; }
    }
}
