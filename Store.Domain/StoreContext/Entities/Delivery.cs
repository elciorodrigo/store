using System;

namespace Store.Domain.StoreContext.entities
{
    public class Delivery
    {
        private DateTime dateTime;

        public Delivery(DateTime dateTime)
        {
            this.dateTime = dateTime;
        }

        public DateTime CreateDate { get; set; }
        public DateTime EstimatedDeliveryDate { get; set; }
        public string Status { get; set; }

        internal void Ship()
        {
           
        }

        internal void Cancel()
        {
           
        }
    }
}