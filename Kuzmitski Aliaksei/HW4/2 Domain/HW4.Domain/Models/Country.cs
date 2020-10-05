using System.Collections.Generic;

namespace HW4.Domain.Models
{
    public class Country : BaseModel
    {
        public string Name { get; set; }
        public List<User> Users { get; set; }
        public List<City> Cities { get; set; }
    }
}
