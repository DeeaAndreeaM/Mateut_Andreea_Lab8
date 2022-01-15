using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mateut_Andreea_Lab8.Models;

namespace Mateut_Andreea_Lab8.Data
{
    public class Mateut_Andreea_Lab8Context : DbContext
    {
        public Mateut_Andreea_Lab8Context (DbContextOptions<Mateut_Andreea_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Mateut_Andreea_Lab8.Models.Book> Book { get; set; }

        public DbSet<Mateut_Andreea_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Mateut_Andreea_Lab8.Models.Category> Category { get; set; }
    }
}
