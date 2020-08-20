using DomainLogics.Models;
using DomainLogics.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
   public class BookRepository :BaseRepository, IBookRepository
    {
        public List<Book> AllBooks()
        {

            BookOrder order = new BookOrder()
            {
                Book = new Book { BookAuthor = "author", BookPrice = 1, BookTitle = "title" },
                TimeOrder = DateTime.Now
            };

            var orders = new List<BookOrder>();
            orders.Add(order);
            var allBooks = orders.Select(x => x.Book).ToList();
            return allBooks;
        }

        public List<Book> GetMostPopular()
        {

            var order = new BookOrder()
            {
                Book = new Book { BookAuthor = "author", BookPrice = 1, BookTitle = "title" },
                TimeOrder = DateTime.Now
            };

            var orders = new List<BookOrder>();
            orders.Add(order);

            var fiveMostPopularBooks = orders.GroupBy(x => x.Book)
                .Select(g => new { Name = g.Key, Count = g.Count() })
                .OrderBy(x => x.Count)
                .Take(5)
                .Select(x => x.Name)
                .ToList<Book>();
            return fiveMostPopularBooks;
        }
    }
}
