using System;
using System.Collections.Generic;
using Api.Domain.Dtos.ImagePath;
using Api.Domain.Entities;

namespace Api.Domain.Dtos.Product
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double PriceOff { get; set; }      
        public bool IsOnSale { get; set; } 
        public bool IsActive { get; set; }   
        public string Brand { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public IEnumerable<ImagePathDto> ImagePaths { get; set; }

        public Guid ProductTypeId { get; set; }
        public ProductTypeEntity ProductType { get; set; }
    }
}
