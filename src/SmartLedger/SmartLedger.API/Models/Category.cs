namespace SmartLedger.API.Models
{
    public class Category
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public decimal BudgetLimit { get; set; }
    }
}
