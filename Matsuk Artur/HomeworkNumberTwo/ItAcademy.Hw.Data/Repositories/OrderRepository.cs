using ItAcademy.Hw.Data.Models;
using ItAcademy.Hw.Data.Repositories.Interfaces;
using System;
using System.Linq;

namespace ItAcademy.Hw.Data.Repositories
{
   public class OrderRepository : BaseRepository, IOrderRepository
    {
        public OrderData[] GetOrders()
        {
            var ordersdata = new OrderData[3];
            var booksdata = GetBooks();

            Random rand = new Random();

            for (int i=0; i<3;i++)
            {
                BookData book1 = booksdata[rand.Next(1, 10)];
                BookData book2 = booksdata[rand.Next(1, 10)];
                BookData book3 = booksdata[rand.Next(1, 10)];
                ordersdata[i] = new OrderData { books = new[] { book1, book2, book3 }, date = new DateTime(2020, 7, rand.Next(29, 31)), price = book1.price+book2.price+book3.price };
            }
            return ordersdata;
        }

        public OrderData[] GetTodaysOrders()
        {
            OrderData[] data = GetOrders();
            OrderData[] TodaysOrders = data.Where(d => d.date >= DateTime.Today).ToArray();
            return TodaysOrders;
        }
    }
}
