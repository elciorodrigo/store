using System;
using System.Collections.Generic;
using System.Text;
using FluentValidator;
using FluentValidator.Validation;

namespace Store.Domain.StoreContext.ValueObjects
{
    public class Email : Notifiable
    {
        public Email(string address)
        {
            Address = address;

            
            AddNotifications(new ValidationContract()
            .IsEmail(Address, "Email", "O Email é invlido")
            );

        }
        public string Address{ get; set; }

        public override string ToString()
        {
            return Address;
        }
    }
}
