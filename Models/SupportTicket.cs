namespace PrimerParcialProgra.Models   // <- corregir namespace
{
    public class SupportTicket
    {
        public int Id { get; set; }
        public string Subject { get; set; } = string.Empty;
        public string RequesterEmail { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string Severity { get; set; } = "Low";
        public string Status { get; set; } = "Open";
        public DateTime OpenedAt { get; set; } = DateTime.UtcNow;
        public DateTime? ClosedAt { get; set; }
        public string? AssignedTo { get; set; }
    }
}