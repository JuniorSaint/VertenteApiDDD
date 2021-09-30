using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class ProductEntity : BaseEntity
    {
        [Display(Name = "Código do produto"),
         Required(ErrorMessage = "O campo {0} é Obrigatório")]
        public string ProductCode { get; set; }

        [Display(Name = "Nome do produto"),
         Required(ErrorMessage = "O campo {0} é Obrigatório"),
         MaxLength(90, ErrorMessage = "Quantidade máxima de caracteres {1}")]
        public string ProductName { get; set; }

        [Display(Name = "Descrição do produto"),
         Required(ErrorMessage = "O campo {0} é Obrigatório")]
        public string Description { get; set; }

        [Display(Name = "Preço do produto"),
         Required(ErrorMessage = "O campo {0} é Obrigatório")]
        public double Price { get; set; }

        private double _priceOff { get; set; }
        public double PriceOff
        {
            get { return _priceOff; }
            set { _priceOff = (value.Equals(null) ? 0.0 : value); }
        }

        [Display(Name = "Esta na promoção"),
         Required(ErrorMessage = "O campo {0} é Obrigatório")]
        public bool IsOnSale { get; set; }

        [Display(Name = "Produto ativo"),
         Required(ErrorMessage = "O campo {0} é Obrigatório")]
        public bool IsActive { get; set; }

        [Display(Name = "Marca do produto"),
         Required(ErrorMessage = "O campo {0} é Obrigatório")]
        public string Brand { get; set; }

        public IEnumerable<ImagePathEntity> ImagePaths { get; set; }

        [Display(Name = "Id do tipo produto"),
         Required(ErrorMessage = "O campo {0} é obrigatório")]
        public Guid ProductTypeId { get; set; }
        public ProductTypeEntity ProductType { get; set; }
    }
}

