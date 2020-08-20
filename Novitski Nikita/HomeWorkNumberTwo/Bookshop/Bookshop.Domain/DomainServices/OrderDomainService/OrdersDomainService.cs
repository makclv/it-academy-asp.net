using Bookshop.Domain.DomainServices.OrderDomainService.OrderInterfaces;
using Bookshop.Domain.Models.Entities;
using Bookshop.Domain.Repositories;
using System.Collections.Generic;

namespace Bookshop.Domain.DomainServices.OrderDomainService
{
    public class OrdersDomainService : IOrdersDomainService
    {
        private readonly IOrderRepository orderRepository;
        public OrdersDomainService(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public List<Order> GetAllOrders()
        {
            return orderRepository.GetAllOrders();
        }
        public List<Order> GetOrdersMadeToday()
        {
            return orderRepository.GetOrdersMadeToday();
        }

    }
}
