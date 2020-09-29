using ClassLibrary1.Entities;

namespace Domain.Entites
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Title Title { get; set; }
        public Country Country { get; set; }
        public City City { get; set; }
        public string Comment { get; set; }
    }
}
