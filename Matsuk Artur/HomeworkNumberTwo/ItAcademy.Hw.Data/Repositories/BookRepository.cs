
using ItAcademy.Hw.Data.Models;
using ItAcademy.Hw.Data.Repositories.Interfaces;

namespace ItAcademy.Hw.Data.Repositories
{
   public class BookRepository : BaseRepository, IBookRepository 
    {
        public BookData[] GetFivePopBooks()
        {
            var data = GetBooks();
            var FivePopBooks = new BookData[] { data[0], data[1], data[2], data[3], data[4] };
            return FivePopBooks;
        }
    }
}
