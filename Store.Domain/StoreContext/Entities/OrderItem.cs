using FluentValidator;
using System;
using System.Collections.Generic;

namespace Store.Domain.StoreContext.entities
{
    public class OrderItem : Notifiable
    {
        public OrderItem(Product product, decimal quantity)
        {
            Product = product;
            Quantity = quantity;
            Price = product.Price;

            if (product.QuantityOnHand < quantity)
                AddNotification("Quantity", "Produto fora de estoque");

            product.DecreaseQuantity(quantity);
            
        }
        public Product Product { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
     
    }
}