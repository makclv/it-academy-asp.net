

namespace ItAcademy.Hw.Users.Domain.Models
{
 
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Country Country { get; set; }
        public City City { get; set; }
        public Title Title { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Comments { get; set; }
    }
}
