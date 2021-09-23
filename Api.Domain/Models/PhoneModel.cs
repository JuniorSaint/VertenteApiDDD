using System;
namespace Api.Domain.Models
{
    public class PhoneModel : BaseModel
    {
        private string _phoneType;
        public string PhoneType
        {
            get { return _phoneType; }
            set { _phoneType = value; }
        }

        private int _phoneNumber;
        public int PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        private string _socialPhone;
        public string SocialPhone
        {
            get { return _socialPhone; }
            set { _socialPhone = value; }
        }

        private Guid _clientId;
        public Guid ClientId
        {
            get { return _clientId; }
            set { _clientId = value; }
        }
    }
}
