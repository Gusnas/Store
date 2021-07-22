using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; } 

        public Order()
        {
        }

        public Order(DateTime moment)
        {
            Moment = moment;
        }

        public void AddItem(OrderItem item)
        {
            
        }
        
        public void RemoveItem(OrderItem item)
        {

        }

        public double Total()
        {
            
        }
    }
}
