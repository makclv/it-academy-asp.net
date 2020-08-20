using Bookshop.Data.Context;
using Bookshop.Domain.Models.Entities;
using Bookshop.Domain.Repositories;
using System;
using System.Collections.Generic;


namespace Bookshop.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private IVirtualDb db;

        public OrderRepository(IVirtualDb context)
        {
            db = context;
        }

        public List<Order> GetAllOrders()
        {
            return db.GetOrders();
        }

        public List<Order> GetOrdersMadeToday()
        {
            List<Order> orders = db.GetOrders();

            return WriteOrderMadeToday(orders);
        }

        private List<Order> WriteOrderMadeToday(List<Order> orders)
        {
            List<Order> ordersMadeToday = new List<Order>();

            orders.ForEach(order => {
                if (order.CreatedAt.ToString("dd.MM.yyyy") == DateTime.Today.ToString("dd.MM.yyyy"))
                {
                    ordersMadeToday.Add(order);
                }
            });
            return ordersMadeToday;
        }


    }
}
