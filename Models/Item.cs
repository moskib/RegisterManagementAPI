using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegisterManagement.Models
{
    /// <summary>
    /// Represents a generic Item in the system.
    /// Used in for Inventory and purchase amounts
    /// </summary>
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public bool IsRefundable { get; set; }

        [Required]
        public double Cost { get; set; }
    }
}
