using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ItAcademy.HomeWorkNumThree.Models
{
    public class User
    {
        //public List<User> usersList;
        [JsonProperty("Id")]
        public int Id { get; set; }
        [JsonProperty("FirstName")]
        public string FirstName { get; set; }
        [JsonProperty("LastName")]
        public string LastName { get; set; }
        [JsonProperty("UserTitle")]
        public Title UserTitle { get; set; }
        [JsonProperty("Country")]
        public string Country { get; set; }
        [JsonProperty("Sity")]
        public string Sity { get; set; }
        [JsonProperty("Phone")]
        public long Phone { get; set; }
        [JsonProperty("Email")]
        public string Email { get; set; }

    }

    public enum Title
        {
            Mr,
            Mrs
        }
}
