using SimpleWPFApp.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleWPFApp.Repository
{
    public interface IQueryPackageRepository
    {
        Task<IEnumerable<Package>> GetPackagesAsync();
    }
}
