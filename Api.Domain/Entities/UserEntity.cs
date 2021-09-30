using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        [Display(Name = "Nome do usuário"),
         Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string UserName { get; set; }

        [Display(Name = "e-mail"),
         Required(ErrorMessage = "O campo {0} é campo obrigatório"),
         EmailAddress(ErrorMessage = "O campo {0} em formato invalido"),
         MaxLength(90, ErrorMessage = "Quantidade máxima de caracteres, {1}")]
        public string Email { get; set; }

        [Display(Name = "Senha"),
         Required(ErrorMessage = "O campo {0} é campo obrigatório")]
        public string Password { get; set; }

        [Display(Name = "Usuário Ativo"),
         Required(ErrorMessage = "O campo {0} é campo obrigatório")]
        public bool IsActive { get; set; }

        [Display(Name = "tipo de usuário"),
         Required(ErrorMessage = "O campo {0} é campo obrigatório")]
        public string UserType { get; set; }
    }
}
