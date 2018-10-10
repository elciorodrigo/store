using System;
using FluentValidator;
using Store.Domain.StoreContext.CustomerCommands.Input;
using Store.Domain.StoreContext.entities;
using Store.Domain.StoreContext.Repositories;
using Store.Domain.StoreContext.Services;
using Store.Domain.StoreContext.ValueObjects;
using Store.Shared.Commands;

namespace Store.Domain.StoreContext

{
    public class CustomerHandler : 
    Notifiable, 
    ICommandHandler<CreateCustomerCommand>, 
    ICommandHandler<AddAddressCommand>
    {
 
        private readonly ICustomerRepository _repository;
        private readonly IEmailService _emailService;
        
        public CustomerHandler(ICustomerRepository repository, IEmailService emailService)
        {
            _repository = repository;
            _emailService = emailService;
                
        }
        public ICommandResult handle(CreateCustomerCommand command)
        {

            if(_repository.CheckDocument(command.Document))
                AddNotification("Document", "Este Cpf já está em uso");
                
            if(_repository.CheckDocument(command.Email)) 
                AddNotification("Document", "Este Cpf já está em uso");   
            

            var name = new  Name(command.FirtName, command.LastName);
            var document = new Document(command.Document);
            var email = new Email(command.Email);

            var customer = new Customer(name, document, email, command.Phone);

            AddNotifications(name.Notifications);
            AddNotifications(document.Notifications);
            AddNotifications(email.Notifications);
            AddNotifications(customer.Notifications);

            if(Invalid)
                return null;

            _repository.Save(customer);
            _emailService.Send(email.Address, "teste@teste.com.br", "olá", "bem vindo");

            return new CreateCustomerCommandResult(customer.Id, name.ToString(), email.Address, command.Phone);
        }

        public ICommandResult handle(AddAddressCommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}
