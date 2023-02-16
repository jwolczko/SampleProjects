using SimpleWPFApp.Data;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Threading.Tasks;

namespace SimpleWPFApp.Repository
{
    public class CommandPackageRepository : ICommandPackageRepository
    {
        public async Task<bool> SavePackagesAsync(IEnumerable<Model.Package> packages)
        {
            using (TaskDb db = new TaskDb())
            {
                foreach (var package in packages)
                {
                    db.Package.AddOrUpdate(new Package
                    {
                        Id = package.Id,
                        Name = package.Name,
                        Description = package.Description,
                        Weight = package.Weight
                    });
                }
                
                await db.SaveChangesAsync();
            }
            
            return true;
        }
    }
}
