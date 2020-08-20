using Bookshop.Data.Context;
using Bookshop.Domain.Models.Entities;
using Bookshop.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bookshop.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private IVirtualDb db;
        public ProductRepository(IVirtualDb context)
        {
            db = context;
        }
        
        public List<Book> GetAllBooks()
        {
            return db.GetBooks();   
        }

        public List<Book> GetTopBooks(int count)
        {
            CountAllOrderBooks();

            return GetBooks(GetFivePairsPopularBooks(count));
        }

        private Dictionary<Guid, int> numberBooksOrdered = new Dictionary<Guid, int>();

        private IEnumerable<KeyValuePair<Guid, int>> GetFivePairsPopularBooks(int count)
        {
            var list = numberBooksOrdered.ToList();
            list.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));

            return list.Take(count);
        }

        private void CountAllOrderBooks()
        {
            foreach (var ordersBooks in db.GetOrdersBooks())
            {
                AddBooksOrdered(ordersBooks);
            }
        }
        private void AddBooksOrdered(OrdersBooks ordersBooks)
        {
            if (numberBooksOrdered.ContainsKey(ordersBooks.BookId))
            {
                numberBooksOrdered[ordersBooks.BookId] += ordersBooks.Count;
            }
            else
            {
                numberBooksOrdered.Add(ordersBooks.BookId, ordersBooks.Count);
            }
        }
       
        private List<Book> GetBooks(IEnumerable<KeyValuePair<Guid, int>> valuePair)
        {
            List<Book> books = new List<Book>();
            foreach (var book in valuePair)
            {
                books.Add(db.GetBooks().Find(b => b.Id == book.Key));
            }

            return books;
        }

    }
}
