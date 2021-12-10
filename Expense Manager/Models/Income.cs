using System.ComponentModel.DataAnnotations;

namespace Expense_Manager.Models
{
    public class Income : Common
    {
        [Required]
        public string? Description { get; set; }

        [Required]
        public Category? Category { get; set; }
        [Required]
        public string? GiveTo { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public long Amount { get; set; }
    }
}
