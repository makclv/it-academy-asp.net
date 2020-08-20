using Bookshop.Domain.Models.Entities;
using System.Collections.Generic;

namespace Bookshop.Domain.DomainServices.OrderDomainService.OrderInterfaces
{
    public interface IOrdersDomainService
    {
        List<Order> GetAllOrders();
        List<Order> GetOrdersMadeToday();
    }
}
