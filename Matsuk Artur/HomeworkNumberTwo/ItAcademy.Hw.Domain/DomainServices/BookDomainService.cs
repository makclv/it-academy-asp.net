using ItAcademy.Hw.Domain.DomainServices.Interfaces;
using ItAcademy.Hw.Domain.Models;
using ItAcademy.Hw.Data.Repositories.Interfaces;
using AutoMapper;
using ItAcademy.Hw.Data.Models;

namespace ItAcademy.Hw.Domain.DomainServices
{
   public class BookDomainService : IBookDomainService
    {
        private readonly IBookRepository bookRep;
        private readonly IOrderRepository orderRep;

        public BookDomainService(IBookRepository bookRep, IOrderRepository orderRep)
        {
            this.bookRep = bookRep;
            this.orderRep = orderRep;
        }

        public Book[] GetFivePopBooks()
        {
            var con = new MapperConfiguration(c => c.CreateMap<BookData, Book>());
            var map = new Mapper(con);
            BookData[] bookData = bookRep.GetFivePopBooks();
            Book[] FivePopBooks = map.Map<BookData[], Book[]>(bookData);
            return FivePopBooks;
        }

        public Book[] GetBooks()
        {
            var con = new MapperConfiguration(c => c.CreateMap<BookData, Book>());
            var map = new Mapper(con);
            BookData[] bookData = bookRep.GetBooks();
            Book[] books = map.Map<BookData[], Book[]>(bookData);
            return books;
        }

        public Order[] GetOrders()
        {
            var con = new MapperConfiguration(c => c.CreateMap<OrderData, Order>());
            var map = new Mapper(con);
            OrderData[] orderData = orderRep.GetOrders();
            Order[] orders = map.Map<OrderData[], Order[]>(orderData);
            return orders;
        }

        public Order[] GetTodaysOrders()
        {
            var con = new MapperConfiguration(c => c.CreateMap<OrderData, Order>());
            var mapper = new Mapper(con);
            OrderData[] orderData = orderRep.GetTodaysOrders();
            Order[] AllTodaysOrders = mapper.Map<OrderData[], Order[]>(orderData);
            return AllTodaysOrders;
        }
    }
}
