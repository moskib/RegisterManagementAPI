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

            var purchases = new Purchase[]
            {
                new Purchase
                {
                    PurchaseNo = 1,
                    DateOfPurchase = new DateTime(2019, 12, 1),
                    DateModified = new DateTime(2019,12,1)
                },
                new Purchase
                {
                    PurchaseNo = 2,
                    VisaNo = "371349659706917",
                    DateOfPurchase = new DateTime(2019, 12, 1),
                    DateModified = new DateTime(2019,12,2)
                }, 
                new Purchase
                {
                    PurchaseNo = 3,
                    VisaNo = "341471579286296",
                    DateOfPurchase = new DateTime(2019, 12, 2),
                    DateModified = new DateTime(2019,12,2)
                },
                new Purchase
                {
                    PurchaseNo = 4,
                    DateOfPurchase = new DateTime(2019, 12, 3),
                    DateModified = new DateTime(2019,12,3)
                },
                new Purchase
                {
                    PurchaseNo = 5,
                    VisaNo = "371172473010823",
                    DateOfPurchase = new DateTime(2019, 12, 4),
                    DateModified = new DateTime(2019,12,4)
                },
                new Purchase
                {
                    PurchaseNo = 6,
                    VisaNo = "340921234554117",
                    DateOfPurchase = new DateTime(2019, 12, 5),
                    DateModified = new DateTime(2019,12,5)
                },
                new Purchase
                {
                    PurchaseNo = 7,
                    DateOfPurchase = new DateTime(2019, 12, 6),
                    DateModified = new DateTime(2019,12,6)
                },
                new Purchase
                {
                    PurchaseNo = 8,
                    VisaNo = "378666663860619",
                    DateOfPurchase = new DateTime(2019, 12, 7),
                    DateModified = new DateTime(2019,12,7)
                },
                new Purchase
                {
                    PurchaseNo = 9,
                    VisaNo = "372675903118544",
                    DateOfPurchase = new DateTime(2019, 12, 8),
                    DateModified = new DateTime(2019,12,8)
                },
                new Purchase
                {
                    PurchaseNo = 10,
                    VisaNo = "346369552078109",
                    DateOfPurchase = new DateTime(2019, 12, 9),
                    DateModified = new DateTime(2019,12,9)
                },
                new Purchase
                {
                    PurchaseNo = 11,
                    VisaNo = "379811816360062",
                    DateOfPurchase = new DateTime(2019, 12, 10),
                    DateModified = new DateTime(2019,12,10)
                },
            };

            modelBuilder.Entity<Purchase>().HasData(purchases);

            var purchaseItems = new PurchaseItem[]
            {
                new PurchaseItem
                {
                    Id=1,
                    PurchaseId=1,
                    ItemId=1,
                    Amount=54,
                    Returned = false
                },
                new PurchaseItem
                {
                    Id=2,
                    PurchaseId=1,
                    ItemId=2,
                    Amount=32,
                    Returned = false
                },
                 new PurchaseItem
                {
                    Id=3,
                    PurchaseId=2,
                    ItemId=1,
                    Amount=54,
                    Returned = false
                },
                new PurchaseItem
                {
                    Id=4,
                    PurchaseId=2,
                    ItemId=2,
                    Amount=32,
                    Returned = false
                },
                new PurchaseItem
                {
                    Id=5,
                    PurchaseId=3,
                    ItemId=3,
                    Amount=55,
                    Returned = false
                },
                new PurchaseItem
                {
                    Id=6,
                    PurchaseId=3,
                    ItemId=4,
                    Amount=66,
                    Returned = false
                },
                new PurchaseItem
                {
                    Id=7,
                    PurchaseId=4,
                    ItemId=5,
                    Amount=16,
                    Returned = false
                },
                new PurchaseItem
                {
                    Id=8,
                    PurchaseId=4,
                    ItemId=1,
                    Amount=50,
                    Returned = false
                },
                new PurchaseItem
                {
                    Id=9,
                    PurchaseId=5,
                    ItemId=2,
                    Amount=43,
                    Returned = false
                },
                new PurchaseItem
                {
                    Id=10,
                    PurchaseId=5,
                    ItemId=3,
                    Amount=9,
                    Returned = false
                },
                new PurchaseItem
                {
                    Id=11,
                    PurchaseId=6,
                    ItemId=4,
                    Amount=22,
                    Returned = false
                },
                new PurchaseItem
                {
                    Id=12,
                    PurchaseId=6,
                    ItemId=5,
                    Amount=21,
                    Returned = false
                },
                new PurchaseItem
                {
                    Id=13,
                    PurchaseId=7,
                    ItemId=2,
                    Amount=15,
                    Returned = false
                },
                new PurchaseItem
                {
                    Id=14,
                    PurchaseId=7,
                    ItemId=1,
                    Amount=7,
                    Returned = false
                },
                new PurchaseItem
                {
                    Id=15,
                    PurchaseId=8,
                    ItemId=3,
                    Amount=23,
                    Returned = false
                },
                new PurchaseItem
                {
                    Id=16,
                    PurchaseId=8,
                    ItemId=4,
                    Amount=14,
                    Returned = false
                },
                new PurchaseItem
                {
                    Id=17,
                    PurchaseId=9,
                    ItemId=5,
                    Amount=3,
                    Returned = false
                },
                new PurchaseItem
                {
                    Id=18,
                    PurchaseId=9,
                    ItemId=1,
                    Amount=30,
                    Returned = false
                },
                new PurchaseItem
                {
                    Id=19,
                    PurchaseId=10,
                    ItemId=2,
                    Amount=20,
                    Returned = false
                },
                new PurchaseItem
                {
                    Id=20,
                    PurchaseId=10,
                    ItemId=3,
                    Amount=14,
                    Returned = false
                },
                new PurchaseItem
                {
                    Id=21,
                    PurchaseId=11,
                    ItemId=4,
                    Amount=7,
                    Returned = false
                },
                new PurchaseItem
                {
                    Id=22,
                    PurchaseId=11,
                    ItemId=5,
                    Amount=12,
                    Returned = false
                }
            };

            modelBuilder.Entity<PurchaseItem>().HasData(purchaseItems);

        }
    }
}
