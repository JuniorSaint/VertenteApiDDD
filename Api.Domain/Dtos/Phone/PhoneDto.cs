using System;

namespace Api.Domain.Dtos.Phone
{
    public class PhoneDto
    {
        public Guid Id { get; set; }
        public string PhoneType { get; set; }
        public int PhoneNumber { get; set; }
        public string SocialPhone { get; set; }
    }
}
