using OrderTrackingSystem.Domain.Entities;
using System.Collections.Generic;

namespace OrderTrackingSystem.Domain.Models
{
    public class Country : BaseEntity
    {
        public string Name { get; set; }
        public List<User> Users { get; set; }
        public List<City> Cities { get; set; }
    }
}
