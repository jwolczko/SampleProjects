using SimpleWPFApp.Data;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace SimpleWPFApp.Repository
{
    public class QueryPackageRepository : IQueryPackageRepository
    {
        public async Task<IEnumerable<Model.Package>> GetPackagesAsync()
        {
            List<Model.Package> packages = new List<Model.Package>();
            using(TaskDb db = new TaskDb())
            {
                var dbPackages = await db.Package.ToListAsync();
                foreach (var package in dbPackages)
                {
                    packages.Add(new Model.Package
                    {
                        Name = package.Name,
                        Description = package.Description,
                        Id = package.Id,
                        Weight = package.Weight
                    });
                }
            }
            return packages;
        }
    }
}
