using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Domain.StoreContext.entities;
using Store.Domain.StoreContext.ValueObjects;

namespace Store.Test.ValueObjects
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SholdReturnNotificationWhenDocumentIsNotValid()
        {
            var document = new Document("1234567890");
            Assert.AreEqual(false, document.IsValid);
        }

        [TestMethod]
        public void SholdNotReturnNotificationWhenDocumentIsNotValid()
        {
            Assert.Fail();
        }
    }
}
