using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Day6_Truongthihamy.Models;

namespace Day6_Truongthihamy.Data
{
    public class Day6_TruongthihamyContext : DbContext
    {
        public Day6_TruongthihamyContext (DbContextOptions<Day6_TruongthihamyContext> options)
            : base(options)
        {
        }

        public DbSet<Day6_Truongthihamy.Models.Product> Product { get; set; } = default!;
    }
}
