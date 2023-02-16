namespace WebApp.Models
{
    public class PackageContext : IPackageContext
    {
        public List<Package> Packages { get; set; }
        public List<Recipient> Recipients { get; set; }

        public PackageContext()
        {
            Packages = new List<Package>
            {
                new Package { Id = 1, PackageIdentifier = "5BFB2A4A-C8FD-4ED5-BA7B-A4C6D05A6272", Name = "Package 1", Description = "Test Package 1", Status = "RECEIVED", RecipientId = 1, LastUpdated = DateTime.Now },
                new Package { Id = 2, PackageIdentifier = "FC925F88-CCD0-4D30-9BD5-42DFB8A17345", Name = "Package 2", Description = "Test Package 2", Status = "DELIVERED", RecipientId = 2, LastUpdated = DateTime.Now },
                new Package { Id = 3, PackageIdentifier = "5FCFA7B5-C54E-492F-92A5-FD897759B5C8", Name = "Package 3", Description = "Test Package 3", Status = "RECEIVED", RecipientId = 1, LastUpdated = DateTime.Now },
                new Package { Id = 2, PackageIdentifier = "BF11A13F-932B-421C-9746-3EED17247240", Name = "Package 2", Description = "Test Package 2", Status = "DELIVERED", RecipientId = 3, LastUpdated = DateTime.Now },
                new Package { Id = 3, PackageIdentifier = "9B794106-0951-405F-869E-7DA973132BF7", Name = "Package 3", Description = "Test Package 3", Status = "RECEIVED", RecipientId = 3, LastUpdated = DateTime.Now }
            };

            Recipients = new List<Recipient>
            {
                new Recipient { Id = 1, Name = "Recipient 1", Address = "Address 1" },
                new Recipient { Id = 2, Name = "Recipient 2", Address = "Address 2" },
                new Recipient { Id = 3, Name = "Recipient 3", Address = "Address 3" }
            };
        }
    }
}
