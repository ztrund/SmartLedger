namespace SmartLedger.API.Models
{
    public class AuditLog
    {
        public int Id { get; set; }
        public required string Action { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public string? Details { get; set; }
    }
}
