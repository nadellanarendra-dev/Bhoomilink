namespace Bhoomilink.Models
{
    public class Property
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Type { get; set; } = "";
        public string Location { get; set; } = "";
        public decimal Price { get; set; }
        public string Area { get; set; } = "";
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public string Facing { get; set; } = "";
        public string Status { get; set; } = "";
        public string ImageUrl { get; set; } = "";
        public string Description { get; set; } = "";
        public bool OwnerVerified { get; set; }
        public bool LoanEligible { get; set; }
        public bool DTCPApproved { get; set; }
        public string OwnerName { get; set; } = "";
        public string OwnerPhone { get; set; } = "";
        public string OwnerEmail { get; set; } = "";
        public string OwnerType { get; set; } = "";   // Owner / Broker
    }
}