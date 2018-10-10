using System;

namespace Store.Domain.StoreContext.Queries{
    public class ListCustomerOrdersQueryResult
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public decimal Total { get; set; }
        
    }
}
