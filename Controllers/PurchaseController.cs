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
            var purchase =
                await _context
                    .Purchases
                    .Include(p => p.PurchaseItems)
                    .ThenInclude(pi => pi.Item)
                    .FirstOrDefaultAsync(p => p.PurchaseNo == id);

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
                return BadRequest();
            }

            PurchaseItem[] returnedItems = data["returnedItems"].ToObject<PurchaseItem[]>();

            var purchasedItems = await (from pi in _context.PurchaseItems
                                        from ri in returnedItems
                                        where pi.Id == ri.Id
                                        select pi).Include(p => p.Item).ToArrayAsync();
            if (purchasedItems.Any(pi => pi.Item.IsRefundable == false))
            {
                return BadRequest();
            }

            //purchase.DateModified = DateTime.Now;

            //_context.Entry(purchase).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PurchaseExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private async Task<bool> CheckIfCanBeRetuned(int purchaseNo, PurchaseItem[] purchaseItems)
        {


            // 1. check that none of the items have isRefundable == false
            //      - if there is an item that has isRefundable == false, return ReturnTypes.NonRefundable // badrequest
            // 2. check if the the current time no longer than 15 days since the purchse
            //      - if it is, return ReturnTypes.FullRefund // (SomeOtherFunctionToChangeReturnedToTrue()) and return message: "returned for full refund"
            // 3. check if the currentTime is between 15 to 30 days of purchase
            //      - if it is, return ReturnTypes.StoreCredit // (SomeOtherFunctionToChangeReturnedToTrue()) and return message: "returned for store credit"
            // 4. check if the current time is longer than 30 days
            //      - if it is, return ReturnTypes.NonRefundable // badrequest
            return true;
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
