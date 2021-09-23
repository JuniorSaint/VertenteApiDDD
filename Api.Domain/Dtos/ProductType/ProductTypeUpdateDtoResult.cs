using System;
namespace Api.Domain.Dtos.ProductType
{
    public class ProductTypeUpdateDtoResult
    {
        public Guid Id { get; set; }
        public string ProductType { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
