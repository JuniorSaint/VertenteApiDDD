using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class ProductTypeEntity : BaseEntity
    {
        [Display(Name = "tipo de produto"),
            Required(ErrorMessage = "O campo {0} é obrigatorio")]
        public string ProductType { get; set; }
        public IEnumerable<ProductEntity> Products { get; set; }
    }
}
