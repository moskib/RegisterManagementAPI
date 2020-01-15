using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterManagement.Models
{
    /// <summary>
    /// This model is only used internally.
    /// It is used to get statistic per month
    /// </summary>
    public class Statistic
    {
        public int Day { get; set; }
        public int Purchases { get; set; }
        public int Returns { get; set; }
    }
}
