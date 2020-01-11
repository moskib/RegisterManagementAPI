using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RegisterManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var items = new Item[]
            {
                new Item
                {
                    Id = 1,
                    Name = "T-Shirt",
                    Cost = 15.99,
                    IsRefundable = true
                },
                new Item
                {
                    Id = 2,
                    Name = "Underwear",
                    Cost = 5.99,
                    IsRefundable = false
                },
                new Item
                {
                    Id = 3,
                    Name = "Denim jeans",
                    Cost = 60.99,
                    IsRefundable = true
                },
                new Item
                {
                    Id = 4,
                    Name = "Coat",
                    Cost = 99.99,
                    IsRefundable = true
                },
                new Item
                {
                    Id = 5,
                    Name = "Sweater",
                    Cost = 19.99,
                    IsRefundable = true
                }
            };

            modelBuilder.Entity<Item>().HasData(items);


            var inventory = new Inventory[]
            {
                new Inventory
                {
                    Id = 1,
                    ItemId = items[0].Id,
                    Amount = 500,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                },
                new Inventory
                {
                    Id = 2,
                    ItemId = items[1].Id,
                    Amount = 200,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                },
                new Inventory {
                    Id = 3,
                    ItemId = items[2].Id,
                    Amount = 700, DateCreated = DateTime.Now,
                    DateModified = DateTime.Now },
                new Inventory {
                    Id = 4,
                    ItemId = items[3].Id,
                    Amount = 1000,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                },
                new Inventory
                {
                    Id = 5,
                    ItemId = items[4].Id,
                    Amount = 1234,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                }
            };

            modelBuilder.Entity<Inventory>().HasData(inventory);
        }
    }
}
