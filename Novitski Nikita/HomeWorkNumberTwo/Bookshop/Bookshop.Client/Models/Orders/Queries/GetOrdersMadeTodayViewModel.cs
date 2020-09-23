using Bookshop.Domain.Models.Entities;
using System.Collections.Generic;

namespace Bookshop.Client.Models.Orders.Queries
{
    public class GetOrdersMadeTodayViewModel
    {
        public List<Order> Orders { get; set; }
    }
}