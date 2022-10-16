using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Tini_HairTies.Models
{
    public class HairTieColourViewModel
    {
        public List<HairTies> HairTies { get; set; }
        public SelectList Colour { get; set; }
        public string HairTieColour { get; set; }
        public string SearchString { get; set; }
    }
}
