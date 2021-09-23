using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class ProductEntity : BaseEntity
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

        private double _priceOff { get; set; }
        public double PriceOff
        {
            get { return _priceOff; }
            set { _priceOff = (value.Equals(null) ? 0.0 : value); }
        }

        [Required(ErrorMessage = "Informação se produto esta em promoção é Obrigatório")]
        public bool IsOnSale { get; set; }

        [Required(ErrorMessage = "Informar se Produto esta ativo é Obrigatório")]
        public bool IsActive { get; set; }

        [Required(ErrorMessage = "Marca do Produto é Obrigatório")]
        public string Brand { get; set; }

        public IEnumerable<ImagePathEntity> ImagePaths { get; set; }

        [Required(ErrorMessage = "Id do tipo de produto é obrigatório")]
        public Guid ProductTypeId { get; set; }
        public ProductTypeEntity ProductType { get; set; }
    }
}

