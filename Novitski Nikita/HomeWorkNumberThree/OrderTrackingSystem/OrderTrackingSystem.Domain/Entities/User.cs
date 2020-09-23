using OrderTrackingSystem.Domain.Entities;

namespace OrderTrackingSystem.Domain.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Comments { get; set; }



        //  public Guid CityId { get; set; }
        public City City { get; set; }


        // public Guid CountryId { get; set; }
        public Country Country { get; set; }

        public Title Title { get; set; }
    }
}
