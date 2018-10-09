using Store.Domain.StoreContext.Entities;
using Store.Domain.StoreContext.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Store.Domain.StoreContext.entities
{
    public class Customer
    {
        private  readonly IList<Address> _addresses;

        public Customer(
            Name name,
            Document document,
            Email email,
            string phone,
            string adress)
        {   
            
            Email = email;
            Phone = phone;
            _addresses = new List<Address>();
            Name = name;
            Document = document;
        }


        public Name Name{ get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public string Phone { get; private set; }
        public IReadOnlyCollection<Address> Addresses => _addresses.ToArray(); 

        public void AddAddress(Address address)
        {
            _addresses.Add(address);
        }

        public override string ToString()
        {
            return Name.ToString();
        }

    }
}