using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        [Required]
        public string UserName { get; set; }

        [Required (ErrorMessage = "Email é campo obrigatório")]
        [EmailAddress(ErrorMessage = "Email em formato invalido")]
        [MaxLength(90, ErrorMessage = "Quantidade máxima de caracteres, {1}")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha é campo obrigatório")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Condição do usuário é campo obrigatório")]
        public bool IsActive { get; set; }

        [Required(ErrorMessage = "Tipo é campo obrigatório")]
        public string UserType { get; set; }
    }
}
