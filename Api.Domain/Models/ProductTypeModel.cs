using System;
namespace Api.Domain.Models
{
    public class ProductTypeModel :BaseModel
    {
        private string _productType;
        public string ProductType {
            get { return _productType; }
            set { _productType = value; }
        }
    }
}
