using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Domain.StoreContext.entities;
using Store.Domain.StoreContext.ValueObjects;

namespace Store.Test.ValueObjects
{
    [TestClass]
    public class DocumentTests
    {
        private Document ValidDocument;
        private Document invalidDocument;

        public DocumentTests()
        {
            ValidDocument = new Document("39965318000");
            invalidDocument = new Document("123412341234");
        }

        [TestMethod]
        public void SholdReturnNotificationWhenDocumentIsNotValid()
        {
            Assert.AreEqual(false, invalidDocument.IsValid);
            Assert.AreEqual(1, invalidDocument.Notifications.Count);
        }

        [TestMethod]
        public void SholdNotReturnNotificationWhenDocumentIsNotValid()
        {
            Assert.AreEqual(true, ValidDocument.IsValid);
            Assert.AreEqual(0, ValidDocument.Notifications.Count);
        }
    }
}
