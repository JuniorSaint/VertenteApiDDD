using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class ImagePathEntity : BaseEntity
    {
        [Display(Name = "Caminho do produto"),
         Required(ErrorMessage = "o campo {0} é Obrigatório")]
        public string ImagePath { get; set; }

        [Display(Name = "Id do produto"),
            Required(ErrorMessage = "O campo {0} é obrigatório")]
        public Guid ProductId { get; set; }
        public ProductEntity Product { get; set; }
    }
}

