using System.ComponentModel.DataAnnotations;

namespace Expense_Manager.Models
{
    public class Expense : Common
    {
        [Required]
        public string? Description { get; set; }

        [Required]
        public Category? Category { get; set; }
        [Required]

        public string? SendTo { get; set; }

        [Required]
        public long Amount { get; set; }
    }
}
