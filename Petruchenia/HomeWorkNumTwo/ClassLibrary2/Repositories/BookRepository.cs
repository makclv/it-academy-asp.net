using ClassLibrary2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Repositories
{
    public class BookRepository : BaseRepository, IBookRepository
    {
        private BookContext db;
        public BookRepository(BookContext context)
        {
            db = context;
        }

        public BookContext Context
        {
            get { return db; }
            set { db = value; }
        }

        public BookData ShowAllOrders()
        {
            throw new NotImplementedException();
        }

        public BookData ShowAllBooks()
        {
            throw new NotImplementedException();
        }

        public BookData ShowAllOrdersFromToday()
        {
            throw new NotImplementedException();
        }

        public BookData Show5MostPopular()
        {
            throw new NotImplementedException();
        }
    }
}
//все заказы
//все книги
//заказы сделанные сегодня
//топ 5 популярных книг