using System;
using System.Collections.Generic;
using FluentValidator;
using FluentValidator.Validation;
using Store.Domain.StoreContext.Enums;
using Store.Shared.Commands;

namespace Store.Domain.StoreContext.OrderCommand.Input

{
    public class PlaceOrderCommand : Notifiable, ICommand
    {

        public PlaceOrderCommand()
        {
            OrderItems = new List<OrderitemCommand>();
        }
        public Guid Customer { get; set; }
        public List<OrderitemCommand> OrderItems { get; set; }

        public bool Valid()
        {
            //.(OrderItems.Count, 0, "Nenhum item do pedido foi encontrado")
            AddNotifications(new ValidationContract()
                .HasLen(Customer.ToString(), 36, "FirstName", "Identificador do Cliente inválido")
                .IsGreaterThan(OrderItems.Count, 0, "Itens","Nenhum item do pedido foi encontrado")
           );

            return IsValid;
        }
    }

    public class OrderitemCommand
    {
        public Guid Product { get; set; }
        public decimal Quantity { get; set; }
    }
}