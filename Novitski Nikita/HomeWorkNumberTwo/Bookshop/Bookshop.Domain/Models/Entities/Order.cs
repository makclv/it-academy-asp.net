using System;
using System.Collections.Generic;


namespace Bookshop.Domain.Models.Entities
{
    public class Order :BaseEntity
    {
        public string CustomerName { get; set; }

        public DateTime CreatedAt { get; set; }

        public List<OrdersBooks> OrdersBooks { get; set; }
         
    }
}
