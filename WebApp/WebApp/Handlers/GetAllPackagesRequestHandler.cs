using MediatR;
using WebApp.Dto;
using WebApp.Models;
using WebApp.Requests;
using AutoMapper;

namespace WebApp.Handlers
{
    public class GetAllPackagesRequestHandler : WebAppRequestHandlerBase, IRequestHandler<AllPackagesRequest, IEnumerable<PackageDto>>
    {
        public GetAllPackagesRequestHandler(IMapper mapper, IPackageContext packageContext):base(mapper,packageContext)
        {
        }
        
        public Task<IEnumerable<PackageDto>> Handle(AllPackagesRequest request, CancellationToken cancellationToken)
        {
            var result = _mapper.Map<List<PackageDto>>(_packageContext.Packages);
            return Task.FromResult(result.AsEnumerable());
        }
    }
}
