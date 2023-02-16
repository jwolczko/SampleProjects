namespace WebApp.Models
{
    public interface IPackageContext
    {
        List<Package> Packages { get; set; }
        List<Recipient> Recipients { get; set; }
    }
}