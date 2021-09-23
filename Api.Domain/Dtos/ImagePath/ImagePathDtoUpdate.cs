using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.ImagePath
{
    public class ImagePathDtoUpdate
    {
        [Required]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Caminho da Imagem é Campo obrigatório")]
        public string ImagePath { get; set; }

        [Required(ErrorMessage = "Id do produto é campo obrigatório")]
        public Guid ProductId { get; set; }
    }
}
