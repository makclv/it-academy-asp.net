using Bookshop.Domain.Models.Entities;
using System.Collections.Generic;

namespace Bookshop.Data.Context
{
    public interface IVirtualDb
    {
        List<Book> GetBooks();
        List<Order> GetOrders();
        List<OrdersBooks> GetOrdersBooks();

    }
}
