using System;
namespace Api.Domain.Dtos.ProductType
{
    public class ProductTypeDto
    {
        public Guid Id { get; set; }
        public string ProductType { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
