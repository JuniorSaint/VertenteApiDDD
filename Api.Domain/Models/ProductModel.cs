using System;

namespace Api.Domain.Models
{
    public class ProductModel : BaseModel
    {
        private string _productCode;
        public string ProductCode
        {
            get { return _productCode; }
            set { _productCode = value; }
        }

        private string _productName;
        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private double _price;
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private double _priceOff;
        public double PriceOff
        {
            get { return _priceOff; }
            set { _priceOff = value; }
        }

        private bool _isOnSale;
        public bool IsOnSale
        {
            get { return _isOnSale; }
            set { _isOnSale = value; }
        }
        public string ProductType { get; set; }

        private bool _isActive;
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        private string _brand;
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        private Guid _imagePath;
        public Guid ImagePathId 
        {
            get {return _imagePath; }
            set {_imagePath = value; }
        }

        private Guid _productTypeId;
        public Guid ProdudctTypeId
        {
            get { return _productTypeId; }
            set { _productTypeId = ProdudctTypeId; }
        }
    }
}
