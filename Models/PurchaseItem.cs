using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegisterManagement.Models
{
    /// <summary>
    /// Represents a multiple items in a purchase
    /// </summary>
    public class PurchaseItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        private int PurchaseId { get; set; }

        [ForeignKey("PurchaseId")]
        public Purchase Purchase { get; set; }

        [Required]
        public int ItemId { get; set; }

        [ForeignKey("ItemId")]
        public Item Item { get; set; }

        [Required]
        public int Amount { get; set; }
    }
}
