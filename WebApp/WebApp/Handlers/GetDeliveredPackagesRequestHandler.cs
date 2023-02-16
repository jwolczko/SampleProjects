using AutoMapper;
using MediatR;
using WebApp.Dto;
using WebApp.Models;
using WebApp.Requests;

namespace WebApp.Handlers
{
    public class GetDeliveredPackagesRequestHandler : WebAppRequestHandlerBase, IRequestHandler<GetDeliveredPackagesRequest, IEnumerable<PackageDto>>
    {
        public GetDeliveredPackagesRequestHandler(IMapper mapper, IPackageContext packageContext) : base(mapper, packageContext)
        {
        }

        public Task<IEnumerable<PackageDto>> Handle(GetDeliveredPackagesRequest request, CancellationToken cancellationToken)
        {
            var result = _mapper.Map<List<PackageDto>>(_packageContext.Packages.Where(p => request.Status.Equals(p.Status, StringComparison.InvariantCultureIgnoreCase)));
            return Task.FromResult(result.AsEnumerable());
        }
    }
}
