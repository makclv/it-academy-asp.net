using ItAcademy.Hw.Domain.Models;

namespace ItAcademy.Hw.Domain.DomainServices.Interfaces
{
   public interface IBookDomainService
    {
        Book[] GetBooks();

        Book[] GetFivePopBooks();

        Order[] GetOrders();

        Order[] GetTodaysOrders();
    }
}
