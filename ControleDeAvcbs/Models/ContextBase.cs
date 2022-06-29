using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAvcbs.Models
{
    public class ContextBase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=.\\DB\\DataBase.db");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Clientes>().HasKey(x => x.ID);
            builder.Entity<Origem>().HasKey(x => x.Origens);
        }

        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Origem> Origem { get; set; }
    }
}
