using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class ImagePathEntity : BaseEntity
    {
        [Required(ErrorMessage = "Caminho do Produto é Obrigatório")]
        public string ImagePath { get; set; }

        [Required]
        public Guid ProductId { get; set; }
        public ProductEntity Product { get; set; }
    }
}

