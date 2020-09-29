namespace ItAcademy.HomeWorkNumFour.Models.CRUD
{
    public class UserViewModel
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Title Title { get; set; }
        public ViewCountry Country { get; set; }
        public ViewCity City { get; set; }
        public string Comment { get; set; }
    }
}