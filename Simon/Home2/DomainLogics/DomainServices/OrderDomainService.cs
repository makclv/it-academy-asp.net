using DomainLogics.DomainServices.Interface;
using DomainLogics.Models;
using DomainLogics.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogics.DomainServices
{
    public class OrderDomainService : IOrderDomainService
    {
        private readonly IOrderRepository orderRepository;

        public OrderDomainService (IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public List<BookOrder> BookOrdersToday()
        {
          return orderRepository.BookOrdersToday();
        }

        public List<BookOrder> AllBookOrder()
        {
            return orderRepository.AllBookOrder();
        }
    }
}
