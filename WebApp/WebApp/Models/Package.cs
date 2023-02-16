namespace WebApp.Models
{
    public class Package
    {
        public int Id { get; set; } 
        public string PackageIdentifier { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; } //( possible statuses: DELIVERED, RECEIVED)
        public int RecipientId { get; set; } //(create relationship with Recipient model) 
        public DateTime LastUpdated { get; set; }
    }
}