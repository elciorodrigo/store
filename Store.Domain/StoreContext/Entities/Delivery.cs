using System;
using Store.Domain.StoreContext.Enums;

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
        public EDeliveryStatus Status { get; set; }

        public void Ship()
        {
            // Se a Data estimada de entrega for no passado, n�o entregar
            Status = EDeliveryStatus.Shipped;
        }

        public void Cancel()
        {
            // Se o status j� estiver entregue, n�o pode cancelar
            Status = EDeliveryStatus.Canceled;
        }
    }
}