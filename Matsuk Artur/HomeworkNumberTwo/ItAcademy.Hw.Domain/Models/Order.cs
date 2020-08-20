using System;
using ItAcademy.Hw.Data.Models;

namespace ItAcademy.Hw.Domain.Models
{
   public class Order
    {
        public int price { get; set; }

        public BookData[] books { get; set; }

        public DateTime date { get; set; }
    }
}
