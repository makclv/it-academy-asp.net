namespace Domain.Entites
{
    public class User
    {
        public int UserId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Title Title { get; set; }
        public Country Country { get; set; }
        public Sity Sity { get; set; }
        public string Comment { get; set; }
    }

    public enum Title
    {
        Mr,
        Mrs,
        Miss,
        Dr
    }
}
