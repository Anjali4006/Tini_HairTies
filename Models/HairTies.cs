using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tini_HairTies.Models
{
    public class HairTies
    {
        public int Id { get; set; }
        public string Material { get; set; }

        public string Type { get; set; }
        public string Colour { get; set; }
        public string Company { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
