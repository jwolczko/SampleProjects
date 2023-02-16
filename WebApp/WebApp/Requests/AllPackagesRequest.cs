using MediatR;
using WebApp.Dto;
using WebApp.Models;

namespace WebApp.Requests
{
    public class AllPackagesRequest : IRequest<IEnumerable<PackageDto>>
    {
    }
}
