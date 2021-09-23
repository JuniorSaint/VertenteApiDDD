using System;
namespace Api.Domain.Dtos.Address

{
    public class AddressDto
    {
        public Guid Id { get; set; }
        public string Street { get; set; }
        public string AddressType { get; set; }
        public string Number { get; set; }
        public string District { get; set; }
        public string Complement { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public string State { get; set; }
        public Guid ClientId { get; set; }
    }
}
