using System;

using ItAcademy.Hw.Data.Models;

namespace ItAcademy.Hw.Client.Models
{
    public class OrderView
    {
        public int price { get; set; }

        public BookData[] books { get; set; }

        public DateTime date { get; set; }
    }
}