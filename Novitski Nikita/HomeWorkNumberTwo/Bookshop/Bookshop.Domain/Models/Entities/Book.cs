using System.Collections.Generic;


namespace Bookshop.Domain.Models.Entities
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public List<OrdersBooks> OrdersBooks { get; set; }
 
    }
}
