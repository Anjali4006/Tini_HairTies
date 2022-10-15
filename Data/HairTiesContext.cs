using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tini_HairTies.Models;

namespace Tini_HairTies.Data
{
    public class HairTiesContext : DbContext
    {
            public HairTiesContext(DbContextOptions<HairTiesContext> options) : base(options)
            {
            }
            public DbSet<HairTies> HairTie { get; set; }
        }
}
