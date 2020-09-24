using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entites
{
    public class Sity
    {
        public int SityId { get; set; }
        public string SityName { get; set; }
        public Country Country { get; set; }
        public List<User> Users { get; set; }
    }
}
