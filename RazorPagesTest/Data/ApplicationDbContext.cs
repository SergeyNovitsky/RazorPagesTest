using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesTest.Data.Models;

namespace RazorPagesTest.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Inventory> Inventories { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inventory>().ToTable("Inventory");
            modelBuilder.Entity<Inventory>().HasKey(x => x.CarId);
        }

    }
}
