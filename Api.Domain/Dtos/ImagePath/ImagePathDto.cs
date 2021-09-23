using System;
namespace Api.Domain.Dtos.ImagePath
{
    public class ImagePathDto
    {
        public Guid Id { get; set; }
        public string ImagePath { get; set; }       
        public Guid ProductId { get; set; }       
    }
}
