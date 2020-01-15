using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
            DateTime endDate = startDate.AddMonths(1).AddDays(-1);

            //var statistics =
            //    (from p in _context.Purchases
            //    where p.DateOfPurchase > startDate &&
            //        p.DateOfPurchase < endDate
            //    select new
            //    {
            //        p.DateOfPurchase
            //    }).ToArray();


            return null;
        }
    }
}