using SimpleWPFApp.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleWPFApp.Repository
{
    public interface ICommandPackageRepository
    {        
        Task<bool> SavePackagesAsync(IEnumerable<Package> packages);
    }
}
