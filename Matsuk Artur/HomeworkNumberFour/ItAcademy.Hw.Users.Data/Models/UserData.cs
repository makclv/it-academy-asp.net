

namespace ItAcademy.Hw.Users.Data.Models
{
    public enum Country

    {
           
        USA=1,
     Russia,
     Germany

    }

    public enum City
    {
        NewYork=1,
        Moscow,
        Berlin
        
        

    }
    public enum Title
    {
        TitleOne = 1,
        TitleTwo,
        TitleThree

    }
    public class UserData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Country Country { get; set; }
        public City City { get; set; }
        public Title Title { get; set; }
        public string Phone { get; set; }
        public  string Email { get; set; }
        public string Comments { get; set; }

        

    }
}
