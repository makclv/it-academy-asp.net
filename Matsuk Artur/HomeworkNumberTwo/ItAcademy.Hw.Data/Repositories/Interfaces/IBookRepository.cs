using ItAcademy.Hw.Data.Models;
namespace ItAcademy.Hw.Data.Repositories.Interfaces
{
   public  interface IBookRepository : IBaseRepository
    {
        BookData[] GetFivePopBooks();
    }
}
