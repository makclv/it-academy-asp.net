using System;
using System.Collections.Generic;
using System.Text;

namespace ItAcademy.Hw.Data.Models
{
   public class OrderData
    {
        public int price { get; set; }

        public BookData[]  books { get; set; }

        public DateTime date { get; set; }
    }
}
