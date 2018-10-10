using System;

namespace Store.Domain.StoreContext.Queries
{
    public class CustomerOrdersCountResult
    {
        public Guid Id { get; set; }
        public string name { get; set; }
        public string Document { get; set; }
        public int Orders { get; set; }
        
    }
}