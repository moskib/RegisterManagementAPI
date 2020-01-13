using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        // PUT: api/Purchase/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPurchase(int id, Purchase purchase)
        {
            if (id != purchase.PurchaseNo)
            {
                return BadRequest();
            }

            purchase.DateModified = DateTime.Now;

            _context.Entry(purchase).State = EntityState.Modified;

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
