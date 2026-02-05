namespace SmartLedger.API.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public required string Merchant { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
