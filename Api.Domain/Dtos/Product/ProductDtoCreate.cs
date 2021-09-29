using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Api.Domain.Dtos.ImagePath;
using Api.Domain.Entities;

namespace Api.Domain.Dtos.Product
{
    public class ProductDtoCreate
    {

        [Required(ErrorMessage = "Codigo do Produto é Obrigatório")]
        public string ProductCode { get; set; }

        [Required(ErrorMessage = "Nome do Produto é Obrigatório")]
        [MaxLength(90, ErrorMessage = "Quantidade máxima de caracteres {1}")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Descrição do Produto é Obrigatório")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Preço do Produto é Obrigatório")]
        public double Price { get; set; }

        public double PriceOff { get; set; }

        [Required(ErrorMessage = "Informação se produto esta em promoção é Obrigatório")]
        public bool IsOnSale { get; set; }



        [Required(ErrorMessage = "Informar se Produto esta ativo é Obrigatório")]
        public bool IsActive { get; set; }

        [Required(ErrorMessage = "Marca do Produto é Obrigatório")]
        public string Brand { get; set; }

        public IEnumerable<ImagePathDto> ImagePaths { get; set; }

        [Required(ErrorMessage = "Tipo do Produto é Obrigatório")]
        public string ProductType { get; set; }
        public Guid ProductTypeId { get; set; }
    }
}
