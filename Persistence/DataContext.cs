using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Value> Values {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Value>()
                .HasData(
                    new Value { Id = 1, Name = "Teste 1" },
                    new Value { Id = 2, Name = "Teste 2" },
                    new Value { Id = 3, Name = "Teste 3" },
                    new Value { Id = 4, Name = "Teste 4" },
                    new Value { Id = 5, Name = "Teste 5" }
                );
        }
    }
}