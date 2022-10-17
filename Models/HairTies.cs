using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tini_HairTies.Models
{
    public class HairTies
    {
        public int Id { get; set; }

        [StringLength(25, MinimumLength = 2)]
        [Required]
        public string Material { get; set; }

        [StringLength(20, MinimumLength = 3)]
        [Required]
        public string Type { get; set; }
        [StringLength(15, MinimumLength = 5)]
        [Required]
        public string Colour { get; set; }
        [StringLength(25, MinimumLength = 4)]
        [Required]
        public string Company { get; set; }
        public int Quantity { get; set; }
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Range(1, 5)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Rating { get; set; }
    }
}
