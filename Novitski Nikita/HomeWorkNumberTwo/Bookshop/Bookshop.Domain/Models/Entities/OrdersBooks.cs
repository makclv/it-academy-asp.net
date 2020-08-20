using System;

namespace Bookshop.Domain.Models.Entities
{
    public class OrdersBooks
    {
        public Guid OrderId { get; set; }
        public Guid BookId { get; set; }
        public int Count { get; set; }

    }
}
