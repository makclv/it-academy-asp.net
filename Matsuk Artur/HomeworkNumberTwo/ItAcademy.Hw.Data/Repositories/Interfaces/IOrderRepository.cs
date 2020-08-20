using ItAcademy.Hw.Data.Models;

namespace ItAcademy.Hw.Data.Repositories.Interfaces
{
   public interface IOrderRepository : IBaseRepository
    {
        OrderData[] GetOrders();

        OrderData[] GetTodaysOrders();
    }
}
