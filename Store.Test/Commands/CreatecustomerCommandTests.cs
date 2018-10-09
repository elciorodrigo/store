using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Domain.StoreContext.CustomerCommands.Input;
using Store.Domain.StoreContext.entities;
using Store.Domain.StoreContext.ValueObjects;

namespace Store.Test
{
    [TestClass]
    public class CreateCustomerCommandTests
    {
        [TestMethod]
        public void ShouldValidateWhenCommandIsValid()
        {
            var command = new CreateCustomerCommand();
            command.FirtName = "Elcio";
            command.LastName = "Rodrigo";
            command.Document = "12132132132";
            command.Email = "elciorodrigo@gmail.com";
            command.Phone = "16982174838";

            Assert.AreEqual(true, command.Valid());

            

        }

    }
}
