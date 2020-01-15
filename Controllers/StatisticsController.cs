using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using RegisterManagement.Data;

namespace RegisterManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public StatisticsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // POST: api/Statistics
        [HttpPost]
        public async Task<ActionResult<object>> GetStatisticsForDate([FromBody]JObject data)
        {
            if(data == null)
            {
                return BadRequest("No date provided");
            }

            int month = data["month"].ToObject<int>();
            int year = data["year"].ToObject<int>();

            DateTime startDate = new DateTime(year, month, 1);
            DateTime endDate = startDate.AddMonths(1);

            var purchaseForMonth =
                await _context.Purchases
                .Where(
                    p =>
                    p.DateOfPurchase >= startDate && // start day starts at 00:00:00
                    p.DateOfPurchase < endDate // end date will equal to the first day of the next month. But it starts at 00:00:00
                 )
                .Include(p => p.PurchaseItems)
                .ThenInclude(pi => pi.Item)
                .Select(p => new
                {
                    p.DateOfPurchase.Day,
                    Purchases = p.PurchaseItems.Sum(p => p.Amount),
                    Returns = p.PurchaseItems.Sum(p => p.AmountReturned)
                }).ToArrayAsync();

            //var purchaseForMonth =
            //    await (from p in _context.Purchases
            //               .Include(p => p.PurchaseItems)
            //               .ThenInclude(pi => pi.Item)
            //           where p.DateOfPurchase >= startDate &&
            //                 p.DateOfPurchase < endDate
            //           group p by new { 
            //               Day = p.DateOfPurchase.Day, 
            //               Purchases = p.PurchaseItems, 
            //               Returns = p.PurchaseItems.Sum(pi => pi.AmountReturned)
            //           } into g
            //           select new { 
            //               g.Key.Day,
            //               Purchases = g.Key.Purchases,
            //               g.Key.Returns
            //           }).ToArrayAsync();

            return purchaseForMonth;
        }
    }
}