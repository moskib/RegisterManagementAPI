using System;
using System.Collections.Generic;
using System.Linq;
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
                await (from p in _context.Purchases
                       join pi in _context.PurchaseItems 
                        on p.PurchaseNo equals pi.PurchaseId
                       where p.DateOfPurchase >= startDate &&
                        p.DateOfPurchase < endDate
                       group pi by p.DateOfPurchase.Day into g
                       select new Statistic
                       {
                           Day = g.Key,
                           Purchases = g.Sum(pi => pi.Amount),
                           Returns = g.Sum(pi => pi.AmountReturned)
                       }).ToArrayAsync();


            return purchaseForMonth;
        }

       
    }
}