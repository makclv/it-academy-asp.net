using OrderTrackingSystem.Domain.Entities;
using System.Collections.Generic;

namespace OrderTrackingSystem.Domain.Models
{
    public class City : BaseEntity
    {
        public string Name { get; set; }
        public List<User> Users { get; set; }
        public Country Country { get; set; }
    }
}
