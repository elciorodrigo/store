using FluentValidator;
using FluentValidator.Validation;
using Store.Shared.Commands;

namespace Store.Domain.StoreContext.CustomerCommands.Input

{
    public class CreateCustomerCommand : Notifiable, ICommand
    {
        public string FirtName { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }


        public bool Valid()
        {
            AddNotifications(new ValidationContract()
            .Requires()
            .HasMinLen(FirtName, 3, "FirstName", "o nome deve pelo menos 3 caractesres")
            .HasMaxLen(FirtName, 40, "FirstName", "o campo possui mais que 40 caracteres")
            .HasMinLen(LastName, 3, "LastName", "o nome deve pelo menos 3 caractesres")
            .HasMaxLen(LastName, 40, "LastName", "o campo possui mais que 40 caracteres")
            .IsEmail(Email, "Email", "E E-mail é invalido")
            .HasLen(Document, 11, "Document", "Cpf invalido'"));

            return IsValid;

        }

    }
}

