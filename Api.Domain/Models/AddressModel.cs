using System;
namespace Api.Domain.Models
{
    public class AddressModel :BaseModel
    {
        private string _street;
        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }

        private string _addressType;
        public string AddressType
        {
            get { return _addressType; }
            set { _addressType = value; }
        }

        private string _number;
        public string Number
        {
            get { return _number; }
            set { _number = string.IsNullOrEmpty(value) ? "S/N": value; }
        }

        private string _district;
        public string District
        {
            get { return _district; }
            set { _district = value; }
        }

        private string _complement;
        public string Complement
        {
            get { return _complement; }
            set { _complement = value; }
        }

        private string _city;
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        private int _zipCode;
        public int ZipCode
        {
            get { return _zipCode; }
            set { _zipCode = value; }
        }

        private string _state;
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }

        private Guid _clientId;
        public Guid ClientId
        {
            get { return _clientId; }
            set { _clientId = value; }
        }
    }
}
