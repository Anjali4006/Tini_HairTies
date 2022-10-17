using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Tini_HairTies.Data;


namespace Tini_HairTies.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new HairTiesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<HairTiesContext>>()))
            {
                // Look for any movies.
                if (context.HairTie.Any())
                {
                    return;   // DB has been seeded
                }

                context.HairTie.AddRange(
                    new HairTies
                    {
                        Material = "Silk",
                        Type = "Scrunchie",
                        Colour = "Lilac",
                        Company = "Tini Hair Ties",
                        Quantity = 5,
                        Price = 10,
                        Rating = 4.5M
                    },

                    new HairTies
                    {
                        Material = "Cotton",
                        Type = "Scrunchie",
                        Colour = "Teal blue",
                        Company = "Tini Hair Ties",
                        Quantity = 8,
                        Price = 15,
                        Rating = 3.0M
                    },

                    new HairTies
                    {
                        Material = "Plastic",
                        Type = "Wired Rubber",
                        Colour = "Baby Pink",
                        Company = "Tini Hair Ties",
                        Quantity = 7,
                        Price = 7,
                        Rating = 5.5M
                    },

                    new HairTies
                    {
                        Material = "Silk",
                        Type = "Scrunchie",
                        Colour = "White",
                        Company = "Tini Hair Ties",
                        Quantity = 13,
                        Price = 10,
                        Rating =4.0M

                    },
                    new HairTies
                    {
                        Material = "Plastic",
                        Type = "Wired Rubber",
                        Colour = "Transperent",
                        Company = "Tini Hair Ties",
                        Quantity = 20,
                        Price = 7,
                        Rating = 2.0M
                    },
                    new HairTies
                    {
                        Material = "Cotton",
                        Type = "Scrunchie",
                        Colour = "Floral Violet",
                        Company = "Tini Hair Ties",
                        Quantity = 25,
                        Price = 10,
                        Rating =5.0M 
                    },
                    new HairTies
                    {
                        Material = "Plastic",
                        Type = "Simple rubber",
                        Colour = "Black",
                        Company = "Tini Hair Ties",
                        Quantity = 50,
                        Price = 5,
                        Rating = 3.5M
                    },
                    new HairTies
                    {
                        Material = "Cotton",
                        Type = "Thin Rubber",
                        Colour = "Pink",
                        Company = "Tini Hair Ties",
                        Quantity = 45,
                        Price = 12,
                        Rating = 4.0M
                    },
                    new HairTies
                    {
                        Material = "Plastic",
                        Type = "Rubber",
                        Colour = "Orange",
                        Company = "Tini Hair Ties",
                        Quantity = 25,
                        Price = 7,
                        Rating = 2.5M
                    },
                    new HairTies
                    {
                        Material = "Silk",
                        Type = "Scrunchie",
                        Colour = "Red",
                        Company = "Tini Hair Ties",
                        Quantity = 70,
                        Price = 10,
                        Rating =3.5M
                    }
                ) ;
                context.SaveChanges();
            }
        }
    }
}

