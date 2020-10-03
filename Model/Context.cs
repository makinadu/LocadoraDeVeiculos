using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Model
{
    class Context : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer
                (@"Server=(localdb)\mssqllocaldb;
                    Database=LocadoraDeVeiculos;
                       Trusted_Connection=true");
        }
    }
}
