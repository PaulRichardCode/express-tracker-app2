using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace express_tracker_app2.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        //Category id
        //foregn key
        public int CategoryId { get; set; }
        public Category Catogory { get; set; }
        public int Amount { get; set; }
        [Column(TypeName = "nvarchar(75)")]
        public string? Note { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
