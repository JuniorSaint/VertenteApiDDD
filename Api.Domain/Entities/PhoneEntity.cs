using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class PhoneEntity : BaseEntity
    {
        [Required]
        public string PhoneType { get; set; }

        [Required]
        public  int PhoneNumber { get; set; }

        private string _socialPhone;
        public string SocialPhone
        {
            get { return _socialPhone; }
            set { _socialPhone = (value.Equals(null) ? "Não tem" : value); }
        }

        [Required]
        public Guid ClientId { get; set; }
        public ClientEntity Client { get; set; }
    }
}
