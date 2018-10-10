using System;
using System.Collections.Generic;
using Store.Domain.StoreContext.entities;
using Store.Domain.StoreContext.Queries;

namespace Store.Domain.StoreContext.Repositories
{
    public interface ICustomerRepository
    {
        bool CheckDocument(string document);
        bool CheckEmail(string email);
        void Save(Customer customer);
        CustomerOrdersCountResult GetCustomerOrdersCount(string document);
        IEnumerable<listCustomerQueryResult> GetList();
        GetCustomerQueryResult Get(Guid id);
        IEnumerable<ListCustomerOrdersQueryResult> GetOrders(Guid id);
                    


        
    }
}