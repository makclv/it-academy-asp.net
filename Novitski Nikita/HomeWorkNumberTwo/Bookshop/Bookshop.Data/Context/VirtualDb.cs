using Bookshop.Domain.Models.Entities;
using System;
using System.Collections.Generic;


namespace Bookshop.Data.Context
{
    public class VirtualDb : IVirtualDb
    {

        public List<Book> Books { get; set; }
        public List<Order> Orders { get; set; }
        public List<OrdersBooks> OrdersBooks { get; set; }


        public VirtualDb()
        {
            Books = new List<Book>();
            Orders = new List<Order>();
            OrdersBooks = new List<OrdersBooks>();

            TableInitialization();
        }

        private void TableInitialization()
        {
            if (Books.Count== 0)
            {
                CreateBooks();
                CreateOrders();
                CreateOrdersBooks();
            }
        }


        public List<Book> GetBooks()
        {
            return Books;
        }

        public List<Order> GetOrders()
        {
            return Orders;
        }

        public List<OrdersBooks> GetOrdersBooks()
        {
            return OrdersBooks;
        }

        private void CreateBooks()
        {
            Book book0 = new Book() { Id = GetGuid(), Title = "Книга 0", Price = 112.3M };
            Book book1 = new Book() { Id = GetGuid(), Title = "Книга 1", Price = 122.3M };
            Book book2 = new Book() { Id = GetGuid(), Title = "Книга 2", Price = 142.3M };
            Book book3 = new Book() { Id = GetGuid(), Title = "Книга 3", Price = 1532.3M };
            Book book4 = new Book() { Id = GetGuid(), Title = "Книга 4", Price = 11232.3M };
            Book book5 = new Book() { Id = GetGuid(), Title = "Книга 5", Price = 1312.3M };
            Books.AddRange(new List<Book> { book0, book1, book2, book3, book4, book5 });
        }

        private void CreateOrders()
        {
            Order order0 = new Order() { Id = GetGuid(), CustomerName = "Customer Nikita", CreatedAt = new DateTime(2001, 12, 02) };
            Order order1 = new Order() { Id = GetGuid(), CustomerName = "Customer Vitalia", CreatedAt = DateTime.Now };
            Order order2 = new Order() { Id = GetGuid(), CustomerName = "Customer Petr", CreatedAt = new DateTime(2001, 12, 02) };
            Order order3 = new Order() { Id = GetGuid(), CustomerName = "Customer Sania", CreatedAt = DateTime.Now };
            Orders.AddRange(new List<Order> { order0, order1, order2, order3 });
        }


        private void CreateOrdersBooks()
        {
            OrdersBooks ordersBooks0 = new OrdersBooks() { BookId = Books[0].Id, OrderId = Orders[0].Id, Count = 3 };
            OrdersBooks ordersBooks1 = new OrdersBooks() { BookId = Books[1].Id, OrderId = Orders[0].Id, Count = 1 };
            OrdersBooks ordersBooks2 = new OrdersBooks() { BookId = Books[2].Id, OrderId = Orders[0].Id, Count = 4 };
            OrdersBooks ordersBooks3 = new OrdersBooks() { BookId = Books[4].Id, OrderId = Orders[1].Id, Count = 6 };
            OrdersBooks ordersBooks4 = new OrdersBooks() { BookId = Books[5].Id, OrderId = Orders[1].Id, Count = 3 };
            OrdersBooks ordersBooks5 = new OrdersBooks() { BookId = Books[3].Id, OrderId = Orders[2].Id, Count = 4 };
            OrdersBooks ordersBooks6 = new OrdersBooks() { BookId = Books[3].Id, OrderId = Orders[2].Id, Count = 4 };
            OrdersBooks ordersBooks7 = new OrdersBooks() { BookId = Books[2].Id, OrderId = Orders[3].Id, Count = 8 };
            OrdersBooks ordersBooks8 = new OrdersBooks() { BookId = Books[1].Id, OrderId = Orders[3].Id, Count = 4 };
            OrdersBooks ordersBooks9 = new OrdersBooks() { BookId = Books[3].Id, OrderId = Orders[3].Id, Count = 4 };
            OrdersBooks.AddRange(new List<OrdersBooks> { ordersBooks0, ordersBooks1, ordersBooks2, ordersBooks3, ordersBooks4, ordersBooks5, ordersBooks6, ordersBooks7, ordersBooks8, ordersBooks9 });
        }
       
        private Guid GetGuid()
        {
            return Guid.NewGuid();
        }

        
    }
}
