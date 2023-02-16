using AutoMapper;
using MediatR;
using WebApp.Dto;
using WebApp.Models;
using WebApp.Requests;

namespace WebApp.Handlers
{
    public class GetForRecipientPackagesRequestHandler 
        : WebAppRequestHandlerBase, 
        IRequestHandler<GetForRecipientPackagesRequest, IEnumerable<PackageDto>>
    {
        public GetForRecipientPackagesRequestHandler(IMapper mapper, IPackageContext packageContext) 
            : base(mapper, packageContext)
        {
        }

        public Task<IEnumerable<PackageDto>> Handle(GetForRecipientPackagesRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<PackageDto> emptyList = new List<PackageDto>();
            var recipient = _packageContext.Recipients.FirstOrDefault(r => string.Equals(r.Name, request.RecipientName, StringComparison.InvariantCultureIgnoreCase));

            if (recipient == null)
            {
                return Task.FromResult(emptyList);
            }

            var result = _packageContext.Packages.Where(p => p.RecipientId == recipient.Id);
            if (!result.Any()) {
                return Task.FromResult(emptyList);
            }

            var packages = _mapper.Map<List<PackageDto>>(result);
            return Task.FromResult(packages.AsEnumerable());
        }
    }
}
