using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegisterManagement.Models
{
    public class Purchase
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PurchaseNo { get; set; }
        public ICollection<PurchaseItem> PurchaseItems { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public DateTime DateModified { get; set; } // for when an item was returned
    }
}
