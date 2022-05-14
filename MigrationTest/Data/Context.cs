using Microsoft.EntityFrameworkCore;
using MigrationTest.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationTest.Data
{
    class Context : DbContext
    {
        public DbSet<Adventurer> Adventurers { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Race> Races { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(@"Server=localhost\sqlexpress;Database=DnDTest;Trusted_Connection=True;");
        }
    }
}
