using System.Collections.Generic;

namespace Api.Domain.Entities
{
    public class ProductTypeEntity : BaseEntity
    {
        public string ProductType { get; set; }
        public IEnumerable<ProductEntity> Products { get; set; }
    }
}
