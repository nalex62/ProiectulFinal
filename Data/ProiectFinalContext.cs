#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProiectFinal.Models;

namespace ProiectFinal.Data
{
    public class ProiectFinalContext : DbContext
    {
        public ProiectFinalContext (DbContextOptions<ProiectFinalContext> options)
            : base(options)
        {
        }

        public DbSet<ProiectFinal.Models.Game> Game { get; set; }

        public DbSet<ProiectFinal.Models.Category> Category { get; set; }

        public DbSet<ProiectFinal.Models.GameCategory> GameCategory { get; set; }
    }
}
