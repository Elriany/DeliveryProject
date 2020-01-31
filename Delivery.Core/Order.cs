using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery.Core
{
    public class Order
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime DeleiveryDate { get; set; }
        public string Title { get; set; }
        public byte Review { get; set; }
        public double Price { get; set; }
        public double DeliveryPrice { get; set; }
        public bool IsApplicationOrder { get; set; }
        public int OrderStatusId { get; set; }
        public bool IsDeleted { get; set; }
        public Guid? DeliveryId { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public Delivery Delivery { get; set; }
    }
}
