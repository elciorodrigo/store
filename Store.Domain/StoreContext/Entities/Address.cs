using Store.Domain.StoreContext.Enums;
using Store.Shared.Entities;

namespace Store.Domain.StoreContext.Entities
{
    public class Address : Entity
    {

        public Address(
            string street, 
            string number,
            string complement, 
            string district, 
            string city, 
            string country, 
            string zipcode)
        {
            Street = street;
            Number = number;
            Complement = complement;
            District = district;
            City = city;
            Country = country;
            ZipCode = zipcode;
}

        public string Street { get; set; }
        public string Number{ get; set; }
        public string Complement{ get; set; }
        public string District{ get; set; }
        public string City{ get; set; }
        public string State{ get; set; }
        public string Country{ get; set; }
        public string ZipCode{ get; set; }
        public EAddressType Type { get; set; }

        public override string ToString()
        {
            return $"{Street}, {Number} - {City} / {State}";
        }
    }
}
