using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.ProductType
{
    public class ProductTypeCreateDto
    {
        [Display(Name = "Tipo de produto"),
         Required(ErrorMessage = "O campo {0} é campo obrigatório")]
        public string ProductType { get; set; }
    }
}
