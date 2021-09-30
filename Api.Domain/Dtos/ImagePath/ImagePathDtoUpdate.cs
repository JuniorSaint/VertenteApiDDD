using System;
using System.ComponentModel.DataAnnotations;
using Api.Domain.Entities;

namespace Api.Domain.Dtos.ImagePath
{
    public class ImagePathDtoUpdate
    {

        [Display(Name = "Id"),
            Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public Guid Id { get; set; }

        [Display(Name = "Caminho do produto"),
         Required(ErrorMessage = "o campo {0} é Obrigatório")]
        public string ImagePath { get; set; }

        [Display(Name = "Id do produto"),
            Required(ErrorMessage = "O campo {0} é obrigatório")]
        public Guid ProductId { get; set; }
        public ProductEntity Product { get; set; }
    }
}
