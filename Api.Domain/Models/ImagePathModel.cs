using System;
namespace Api.Domain.Models
{
    public class ImagePathModel : BaseModel
    {
        private string _imagePath;
        public string ImagePaht
        {
            get { return _imagePath; }
            set { _imagePath = value; }
        }

        private Guid _productId;
        public Guid ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }
    }
}

