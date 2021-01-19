using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppConnection.Connection
{
    public class DbAppContext : DbContext
    {
        public string _connection { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }

        public DbAppContext(DbContextOptions options, string Connection) : base(options)
        {
            _connection = Connection;
            Database.Migrate();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_connection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Product>().Ignore();
        }
    }
}
