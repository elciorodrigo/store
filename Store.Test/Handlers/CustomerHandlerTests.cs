using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Domain.StoreContext;
using Store.Domain.StoreContext.CustomerCommands.Input;
using Store.Domain.StoreContext.entities;
using Store.Domain.StoreContext.ValueObjects;

namespace Store.Test
{
    [TestClass]
    public class CustomerHandlerTests
    {
        public void ShouldRegisterCustomerWhenCommandIsValid()
        {
            var command = new CreateCustomerCommand();
            command.FirtName = "Elcio";
            command.LastName = "Rodrigo";
            command.Document = "12132132132";
            command.Email = "elciorodrigo@gmail.com";
            command.Phone = "16982174838";

            Assert.AreEqual(true, command.Valid());

            var handler = new CustomerHandler(new MockCustomerRepository(), new MockEmailService());
            var result = handler.handle(command);

            Assert.AreNotEqual(null, result);
            Assert.AreEqual(true, handler.IsValid);
        }
        

    }
}
