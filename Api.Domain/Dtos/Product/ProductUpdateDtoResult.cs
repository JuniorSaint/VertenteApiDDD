using System;
using System.Collections.Generic;
using Api.Domain.Dtos.ImagePath;
using Api.Domain.Dtos.ProductType;

namespace Api.Domain.Dtos.Product
{
    public class ProductUpdateDtoResult
    {
        public Guid Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public double PriceOff { get; set; }
        public bool IsOnSale { get; set; }
        public bool IsActive { get; set; }
        public string Brand { get; set; }
        public IEnumerable<ImagePathDto> ImagePaths { get; set; }
        public Guid ProductTypeId { get; set; }
        public ProductTypeDto ProductType { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
