using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hitmans.Models
{
    public class Hitmany
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public decimal Price { get; set; }

        public List<string> Description { get; set; }

        public string PicLink { get; set; }

        public Hitmany()
        {
            Description = new List<string>();
        }
    }
}