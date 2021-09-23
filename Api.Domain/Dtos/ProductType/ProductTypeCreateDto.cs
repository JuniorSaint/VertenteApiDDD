using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.ProductType
{
    public class ProductTypeCreateDto
    {
       [Required(ErrorMessage = "Tipo de produto é campo obrigatório")] 
        public string ProductType { get; set; }       
    }
}
