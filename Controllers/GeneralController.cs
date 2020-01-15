using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegisterManagement.Data;
using RegisterManagement.Models;

namespace RegisterManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneralController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GeneralController(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// NOTE!!
        /// This seed endpoint is used only because there is currently a problem with seeding
        /// data through the application db context - the database doesn't increment the Id
        /// of entities. This is a workaround.
        /// </summary>
        /// <returns></returns>
        [HttpGet("seed")]
        public async Task<ActionResult<object>> SeedDb()
        {
            if (_context.Items.Count() == 0)
            {
                var items = new Item[]
               {
                    new Item
                    {
                        Name = "T-Shirt",
                        Cost = 15.99,
                        IsRefundable = true
                    },
                    new Item
                    {
                        Name = "Underwear",
                        Cost = 5.99,
                        IsRefundable = false
                    },
                    new Item
                    {
                        Name = "Denim jeans",
                        Cost = 60.99,
                        IsRefundable = true
                    },
                    new Item
                    {
                        Name = "Coat",
                        Cost = 99.99,
                        IsRefundable = true
                    },
                    new Item
                    {
                        Name = "Sweater",
                        Cost = 19.99,
                        IsRefundable = true
                    }
               };

                foreach (Item item in items)
                    _context.Add(item);

                await _context.SaveChangesAsync();

            }

            if (_context.Inventory.Count() == 0)
            {

                var inventory = new Inventory[]
                {
                    new Inventory
                    {
                        ItemId = 1,
                        Amount = 500,
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Now
                    },
                    new Inventory
                    {
                        ItemId = 2,
                        Amount = 200,
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Now
                    },
                    new Inventory
                    {
                        ItemId = 3,
                        Amount = 700, DateCreated = DateTime.Now,
                        DateModified = DateTime.Now },
                    new Inventory
                    {
                        ItemId = 4,
                        Amount = 1000,
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Now
                    },
                    new Inventory
                    {
                        ItemId = 5,
                        Amount = 1234,
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Now
                    }
                };

                foreach (Inventory inv in inventory)
                    _context.Add(inv);

                await _context.SaveChangesAsync();
            }


            if (_context.Purchases.Count() == 0)
            {
                var purchases = new Purchase[]
                {
                    new Purchase
                    {
                        DateOfPurchase = new DateTime(2019, 12, 1),
                        DateModified = new DateTime(2019,12,1)
                    },
                    new Purchase
                    {
                        VisaNo = "371349659706917",
                        DateOfPurchase = new DateTime(2019, 12, 1),
                        DateModified = new DateTime(2019,12,2)
                    },
                    new Purchase
                    {
                        VisaNo = "341471579286296",
                        DateOfPurchase = new DateTime(2019, 12, 2),
                        DateModified = new DateTime(2019,12,2)
                    },
                    new Purchase
                    {
                        DateOfPurchase = new DateTime(2019, 12, 3),
                        DateModified = new DateTime(2019,12,3)
                    },
                    new Purchase
                    {
                        VisaNo = "371172473010823",
                        DateOfPurchase = new DateTime(2019, 12, 4),
                        DateModified = new DateTime(2019,12,4)
                    },
                    new Purchase
                    {
                        VisaNo = "340921234554117",
                        DateOfPurchase = new DateTime(2019, 12, 5),
                        DateModified = new DateTime(2019,12,5)
                    },
                    new Purchase
                    {
                        DateOfPurchase = new DateTime(2019, 12, 6),
                        DateModified = new DateTime(2019,12,6)
                    },
                    new Purchase
                    {
                        VisaNo = "378666663860619",
                        DateOfPurchase = new DateTime(2019, 12, 7),
                        DateModified = new DateTime(2019,12,7)
                    },
                    new Purchase
                    {
                        VisaNo = "372675903118544",
                        DateOfPurchase = new DateTime(2019, 12, 8),
                        DateModified = new DateTime(2019,12,8)
                    },
                    new Purchase
                    {
                        VisaNo = "346369552078109",
                        DateOfPurchase = new DateTime(2019, 12, 9),
                        DateModified = new DateTime(2019,12,9)
                    },
                    new Purchase
                    {
                        VisaNo = "379811816360062",
                        DateOfPurchase = new DateTime(2019, 12, 10),
                        DateModified = new DateTime(2019,12,10)
                    },
                };

                foreach (Purchase purchase in purchases)
                    _context.Add(purchase);

                await _context.SaveChangesAsync();
            }


            if (_context.PurchaseItems.Count() == 0)
            {
                var purchaseItems = new PurchaseItem[]
               {
                    new PurchaseItem
                    {

                        PurchaseId=1,
                        ItemId=1,
                        Amount=54,
                        Returned = false
                    },
                    new PurchaseItem
                    {
                        PurchaseId=1,
                        ItemId=2,
                        Amount=32,
                        Returned = false
                    },
                     new PurchaseItem
                    {
                        PurchaseId=2,
                        ItemId=1,
                        Amount=54,
                        Returned = false
                    },
                    new PurchaseItem
                    {
                        PurchaseId=2,
                        ItemId=2,
                        Amount=32,
                        Returned = false
                    },
                    new PurchaseItem
                    {
                        PurchaseId=3,
                        ItemId=3,
                        Amount=55,
                        Returned = false
                    },
                    new PurchaseItem
                    {
                        PurchaseId=3,
                        ItemId=4,
                        Amount=66,
                        Returned = false
                    },
                    new PurchaseItem
                    {
                        PurchaseId=4,
                        ItemId=5,
                        Amount=16,
                        Returned = false
                    },
                    new PurchaseItem
                    {
                        PurchaseId=4,
                        ItemId=1,
                        Amount=50,
                        Returned = false
                    },
                    new PurchaseItem
                    {
                        PurchaseId=5,
                        ItemId=2,
                        Amount=43,
                        Returned = false
                    },
                    new PurchaseItem
                    {
                        PurchaseId=5,
                        ItemId=3,
                        Amount=9,
                        Returned = false
                    },
                    new PurchaseItem
                    {
                        PurchaseId=6,
                        ItemId=4,
                        Amount=22,
                        Returned = false
                    },
                    new PurchaseItem
                    {
                        PurchaseId=6,
                        ItemId=5,
                        Amount=21,
                        Returned = false
                    },
                    new PurchaseItem
                    {
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
                        PurchaseId=8,
                        ItemId=3,
                        Amount=23,
                        Returned = false
                    },
                    new PurchaseItem
                    {
                        PurchaseId=8,
                        ItemId=4,
                        Amount=14,
                        Returned = false
                    },
                    new PurchaseItem
                    {
                        PurchaseId=9,
                        ItemId=5,
                        Amount=3,
                        Returned = false
                    },
                    new PurchaseItem
                    {
                        PurchaseId=9,
                        ItemId=1,
                        Amount=30,
                        Returned = false
                    },
                    new PurchaseItem
                    {
                        PurchaseId=10,
                        ItemId=2,
                        Amount=20,
                        Returned = false
                    },
                    new PurchaseItem
                    {
                        PurchaseId=10,
                        ItemId=3,
                        Amount=14,
                        Returned = false
                    },
                    new PurchaseItem
                    {
                        PurchaseId=11,
                        ItemId=4,
                        Amount=7,
                        Returned = false
                    },
                    new PurchaseItem
                    {
                        PurchaseId=11,
                        ItemId=5,
                        Amount=12,
                        Returned = false
                    }
               };

                foreach (PurchaseItem pi in purchaseItems)
                    _context.Add(pi);

                await _context.SaveChangesAsync();
            }



            return Ok("Seeded");

        }
    }
}