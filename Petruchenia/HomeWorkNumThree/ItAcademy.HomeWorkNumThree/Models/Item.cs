using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ItAcademy.HomeWorkNumThree.Models
{
    public class Item
    {
        [JsonProperty("Header")]
        public string Header { get; set; }

        [JsonProperty("items")]
        public List<User> items { get; set; }
        public Item()
        {
            items = new List<User>();
        }
    }
}