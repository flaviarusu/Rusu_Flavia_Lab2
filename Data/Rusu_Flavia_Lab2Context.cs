using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rusu_Flavia_Lab2.Models;

namespace Rusu_Flavia_Lab2.Data
{
    public class Rusu_Flavia_Lab2Context : DbContext
    {
        public Rusu_Flavia_Lab2Context (DbContextOptions<Rusu_Flavia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Rusu_Flavia_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Rusu_Flavia_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Rusu_Flavia_Lab2.Models.Author>? Author { get; set; }
    }
}
