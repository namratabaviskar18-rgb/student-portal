namespace ComplaintMonitoringSystem.Models
{
    public class Complaint
    {
        public int ComplaintID { get; set; }
        public int UserID { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string Status { get; set; } = "Pending";
        public string AdminReply { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? RepliedAt { get; set; }

        // Extra for display
        public string FullName { get; set; }
        public string Username { get; set; }
    }

    public class PostComplaintRequest
    {
        public int UserID { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
    }

    public class ReplyRequest
    {
        public int ComplaintID { get; set; }
        public string AdminReply { get; set; }
        public string Status { get; set; } = "Resolved";
    }
}
