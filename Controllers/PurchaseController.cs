using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using RegisterManagement.Data;
using RegisterManagement.Enums;
using RegisterManagement.Models;

namespace RegisterManagement.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PurchaseController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Purchase
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Purchase>>> GetPurchases()
        {
            // TO DO:
            // do not include purchase items where retuned == true
            return
                await _context
                    .Purchases
                    .Include(p => p.PurchaseItems)
                    .ThenInclude(pi => pi.Item)
                    .ToListAsync();
        }

        // GET: api/Purchase/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Purchase>> GetPurchase(int id)
        {
            // TO DO:
            // do not include purchase items where retuned == true
            //var purchase =
            //    await _context
            //        .Purchases
            //        .Include(p => p.PurchaseItems)
            //        .ThenInclude(pi => pi.Item)
            //        .FirstOrDefaultAsync(p => p.PurchaseNo == id);

            // CHECK THIS!!
            var purchase =
                await (from p in _context.Purchases
                 from pi in _context.PurchaseItems
                 where p.PurchaseNo == id && 
                     p.PurchaseNo == pi.PurchaseId && 
                     pi.Returned == false
                 select p)
                 .Include(p => p.PurchaseItems)
                 .ThenInclude(pi => pi.Item)
                 .SingleOrDefaultAsync();

            if (purchase == null)
            {
                return NotFound();
            }

            return purchase;
        }

        // PUT: api/Purchase/returns/5
        [HttpPut("returns/{id}")]
        public async Task<IActionResult> PutPurchase(int id, [FromBody]JObject data)
        {

            if (!PurchaseExists(id))
            {
                return BadRequest("This purchase doesn't exist");
            }

            if(data["returnedItems"] == null)
            {
                return BadRequest("No return items provided");
            }

            // get purchase and items being returned.
            var purchase = await _context.Purchases.FindAsync(id);
            PurchaseItem[] returnedItems = data["returnedItems"].ToObject<PurchaseItem[]>();

            if (returnedItems.Any(i => i.Amount == 0))
            {
                return BadRequest("One or more of the specified items doesn't have an amount being returned");
            }

            // get return condition based on the date, and whether it meets store policy (item.IsRefundable != false)
            ReturnTypes returnCondition = GetReturnType(purchase, returnedItems);

            string returnMessage = "";

            switch (returnCondition)
            {
                case ReturnTypes.NonRefundable:
                    return BadRequest("One or more of the passed items are non-refundable");
                case ReturnTypes.FullRefund:
                    returnMessage = "Returned for a full refund";
                    break;
                case ReturnTypes.StoreCredit:
                    returnMessage = "Returned for store credit";
                    break;
            }

            ReturnItems(id, returnedItems);

            purchase.DateModified = DateTime.Now;

            _context.Entry(purchase).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return Ok(returnMessage);
        }

        public void ReturnItems(int purchaseId, PurchaseItem[] returnedItems)
        {
            var inventory =  (from ri in returnedItems
                              from i in _context.Inventory.Where(i => ri.ItemId == i.ItemId)
                              where i.ItemId == ri.ItemId
                              orderby i.ItemId
                              select i).ToArray();

            // order by item Id to not get mixed amounts.
            returnedItems = returnedItems.OrderBy(p => p.ItemId).ToArray();

            var recordsToUpdate = (from ri in returnedItems
                                   from pi in _context.PurchaseItems
                                   .Where(
                                       p => p.ItemId == ri.ItemId &&
                                       p.PurchaseId == purchaseId)
                                   orderby pi.ItemId
                                   select pi).ToArray();

            // change item status to returned = true
            for(int i = 0; i < returnedItems.Length; i++)
            {
                recordsToUpdate[i].Returned = true;
                recordsToUpdate[i].AmountReturned = returnedItems[i].Amount;
                recordsToUpdate[i].Amount -= returnedItems[i].Amount;
                inventory[i].Amount += returnedItems[i].Amount;

                _context.Entry(recordsToUpdate[i]).State = EntityState.Modified;
                _context.Entry(inventory[i]).State = EntityState.Modified;
            }
        }

        private ReturnTypes GetReturnType(Purchase purchase, PurchaseItem[] returnItems)
        {

            var totalDaysSincePurchase = (DateTime.Now - purchase.DateOfPurchase).TotalDays;

            if(totalDaysSincePurchase > 30.00)
            {
                return ReturnTypes.NonRefundable;
            }


            var items = (from ri in returnItems
                         from i in _context.Items.Where(i => ri.ItemId == i.Id)
                         select i).ToArray();


            if (items.Any(item => item.IsRefundable == false))
            {
                return ReturnTypes.NonRefundable;
            }

            if (totalDaysSincePurchase <= 15)
            {
                return ReturnTypes.FullRefund;
            }

            if(totalDaysSincePurchase > 15 && totalDaysSincePurchase <= 30)
            {
                return ReturnTypes.FullRefund;
            }

            return ReturnTypes.NonRefundable;
        }

        // POST: api/Purchase/visa <- lookup a purchase via visa
        [HttpPost("visa")]
        public async Task<ActionResult<Purchase[]>> GetPurchasesByVisa(Purchase purchase)
        {
            if (purchase.VisaNo == null)
            {
                return NotFound();
            }

            return await (from p in _context.Purchases
                          where p.VisaNo == purchase.VisaNo
                          orderby p.DateOfPurchase
                          select p)
                          .Include(p => p.PurchaseItems)
                          .ThenInclude(p => p.Item)
                          .ToArrayAsync();
        }

        // POST: api/Purchase
        [HttpPost]
        public async Task<ActionResult<Purchase>> PostPurchase(Purchase purchase)
        {
            // check if there's a visa number, if so, check if it is valid.
            if (purchase.VisaNo != null)
            {
                if (!ValidVisa(purchase.VisaNo))
                {
                    return BadRequest("Invalid visa number");
                }
            }

            purchase.DateOfPurchase = DateTime.Now;
            purchase.DateModified = DateTime.Now;

            UpdateInventoryAmounts(purchase);

            _context.Purchases.Add(purchase);
            await _context.SaveChangesAsync();

            return
                CreatedAtAction
                (
                    "GetPurchase",
                    new { id = purchase.PurchaseNo },
                    purchase
                );
        }

        public bool ValidVisa(string visa)
        {
            string regexPattern =
                    @"\b4[0-9]{12}(?:[0-9]{3})?\b|\b5[1-5][0-9]{14}\b|\b3[47][0-9]{13}\b|\b3(?:0[0-5]|[68][0-9])[0-9]{11}\b|\b6(?:011|5[0-9]{2})[0-9]{12}\b|\b(?:2131|1800|35\d{3})\d{11}\b";
            return Regex.IsMatch(visa, regexPattern);
        }

        //TODO: Test this!!!
        public async void UpdateInventoryAmounts(Purchase purchase) 
        {
            var allInventoryItems = await _context.Inventory.ToArrayAsync();
            var purchaseItems = purchase.PurchaseItems.ToArray();

            var inventoryItems = (from pi in purchaseItems
                                 from ii in allInventoryItems
                                 where pi.ItemId == ii.ItemId
                                 select ii).ToArray();

            for(int i = 0; i < inventoryItems.Length; i++)
            {
                inventoryItems[i].Amount -= purchaseItems[i].Amount;
                inventoryItems[i].DateModified = DateTime.Now;
                _context.Entry(inventoryItems[i]).State = EntityState.Modified;
            }

        }

        // DELETE: api/Purchase/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Purchase>> DeletePurchase(int id)
        {
            var purchase = await _context.Purchases.FindAsync(id);
            if (purchase == null)
            {
                return NotFound();
            }

            _context.Purchases.Remove(purchase);
            await _context.SaveChangesAsync();

            return purchase;
        }

        private bool PurchaseExists(int id)
        {
            return _context.Purchases.Any(e => e.PurchaseNo == id);
        }
    }
}
