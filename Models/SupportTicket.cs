namespace Grupo2.Models
{
    public class SupportTicket
    {
        public int Id { get; set; }  // PK
        public string Subject { get; set; } = string.Empty;
        public string RequesterEmail { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string Severity { get; set; } = "Low";   // Low, Medium, High
        public string Status { get; set; } = "Open";    // Open, InProgress, Closed
        public DateTime OpenedAt { get; set; } = DateTime.UtcNow;
        public DateTime? ClosedAt { get; set; }
        public string? AssignedTo { get; set; }
    }
}