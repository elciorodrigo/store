using FluentValidator;
using FluentValidator.Validation;

namespace Store.Domain.StoreContext.ValueObjects
{
    public class Name : Notifiable
    {
        public Name(string fistName, string lastName)
        {
            FirtName = fistName;
            LastName = lastName;

            AddNotifications(new ValidationContract()
            .Requires()
            .HasMinLen(FirtName, 3, "FirstName", "o nome deve pelo menos 3 caractesres")
            .HasMaxLen(FirtName, 40, "FirstName", "o campo possui mais que 40 caracteres" )
            .HasMinLen(LastName, 3, "LastName", "o nome deve pelo menos 3 caractesres")
            .HasMaxLen(LastName, 40, "LastName", "o campo possui mais que 40 caracteres" ));

            
            

        }
        public string FirtName { get; private set; }
        public string LastName { get; private set; }

        public override string ToString()
        {
            return $"{FirtName} {LastName}";
        }
    }
}
