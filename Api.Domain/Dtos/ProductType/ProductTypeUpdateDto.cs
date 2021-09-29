using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.ProductType
{
    public class ProductTypeUpdateDto
    {
        [Required(ErrorMessage = "{0}Tipo de produto é campo obrigatório")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Tipo de produto é campo obrigatório")]
        public string ProductType { get; set; }
    }
}
