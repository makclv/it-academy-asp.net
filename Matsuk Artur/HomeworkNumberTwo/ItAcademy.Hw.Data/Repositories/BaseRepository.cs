using ItAcademy.Hw.Data.Models;
using ItAcademy.Hw.Data.Repositories.Interfaces;

namespace ItAcademy.Hw.Data.Repositories
{
   public  class BaseRepository : IBaseRepository
    {
        public BookData[] GetBooks()
        {
            var booksdata = new BookData[10];

            for(int i=0;i<10;i++)
            {
                booksdata[i] = new BookData { name = "Awesome Book Part " + (i + 1), price = i+5};
            }
            return booksdata;
        }
    }

}
