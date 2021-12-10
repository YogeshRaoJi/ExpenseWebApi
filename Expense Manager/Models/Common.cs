using System.ComponentModel.DataAnnotations;

namespace Expense_Manager.Models
{
    public class Common
    {
        public int Id { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedOn { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime UpdatedOn { get; set; }
    }
}
