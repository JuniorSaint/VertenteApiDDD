using System;
namespace Api.Domain.Models
{
    public class ClientModel : BaseModel
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _cpf_Cnpj;
        public int Cpf_Cnpj
        {
            get { return _cpf_Cnpj; }
            set { _cpf_Cnpj = value; }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _note;
        public string Note
        {
            get { return _note; }
            set { _note = value; }
        }

        private Guid _phoneId;
        public Guid PhoneId
        {
            get { return _phoneId; }
            set { _phoneId = value; }
        }


        private Guid _addressId;
        public Guid AddressId
        {
            get { return _addressId; }
            set { _addressId = value; }
        }
    }
}
