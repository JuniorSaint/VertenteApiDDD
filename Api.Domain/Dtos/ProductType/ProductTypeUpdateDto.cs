using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.ProductType
{
    public class ProductTypeUpdateDto
    {
        [Display(Name = "Id Tipo de produto"),
         Required(ErrorMessage = "O campo {0} é campo obrigatório")]
        public Guid Id { get; set; }

        [Display(Name = "Tipo de produto"),
         Required(ErrorMessage = "O campo {0} é campo obrigatório")]
        public string ProductType { get; set; }
    }
}
