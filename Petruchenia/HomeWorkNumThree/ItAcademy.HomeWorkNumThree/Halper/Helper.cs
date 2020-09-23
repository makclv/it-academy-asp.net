using ItAcademy.HomeWorkNumThree.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ItAcademy.HomeWorkNumThree.Halper
{
    public class Helper
    {
        public static void Delete (int i)
        {
            string writePath = @"C:\Users\yurqaa\source\repos\ItAcademy.HomeWorkNumThree\users.txt";
            var obj = JsonConvert.DeserializeObject<Item>
                (File.ReadAllText(writePath));

            Item item = new Item();

            foreach (User a in obj.items)
            {
                item.items.Add(a);
            }
            item.items.RemoveAt(i);

            string json = JsonConvert.SerializeObject(item, Formatting.Indented);
            File.Delete(writePath);

            using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(json);
            }
        }
        public static void AddToJson (User user)
        {
            string writePath = @"C:\Users\yurqaa\source\repos\ItAcademy.HomeWorkNumThree\users.txt";
            var obj = JsonConvert.DeserializeObject<Item>
                (File.ReadAllText(writePath));
            Item item = new Item();

            foreach (User a in obj.items)
            {
                item.items.Add(a);
            }

            item.items.Add(user);

            string json = JsonConvert.SerializeObject(item, Formatting.Indented);
            File.Delete(writePath);

            using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(json);
            }
        }

        public static object GetFromJson ()
        {
            string writePath = @"C:\Users\yurqaa\source\repos\ItAcademy.HomeWorkNumThree\users.txt";
            var obj = JsonConvert.DeserializeObject<Item>
                (File.ReadAllText(writePath));
            List<User> UL = new List<User>();
            foreach (var item in obj.items)
            {
                UL.Add(item);
            }
            return UL;
        }
    }
}