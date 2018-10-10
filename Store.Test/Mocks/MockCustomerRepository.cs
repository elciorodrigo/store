using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Domain.StoreContext.CustomerCommands.Input;
using Store.Domain.StoreContext.entities;
using Store.Domain.StoreContext.Repositories;
using Store.Domain.StoreContext.ValueObjects;

namespace Store.Test
{
    public class MockCustomerRepository : ICustomerRepository
    {
        public bool CheckDocument(string document)
        {
            return false;
        }

        public bool CheckEmail(string email)
        {
            return false;
        }

        public void Save(Customer customer)
        {
                
        }
    }
}
