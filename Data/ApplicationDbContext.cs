using System;
using Microsoft.EntityFrameworkCore;
using RegisterManagement.Models;

namespace RegisterManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseItem> PurchaseItems { get; set; }



        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options) :
            base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
