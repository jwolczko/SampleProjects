using AutoMapper;
using MediatR;
using WebApp.Dto;
using WebApp.Models;
using WebApp.Requests;

namespace WebApp.Handlers
{
    public class PackageByIdRequestHandler : WebAppRequestHandlerBase, IRequestHandler<PackageByIdRequest, PackageDto>
    {
        public PackageByIdRequestHandler(IMapper mapper, IPackageContext packageContext): base(mapper, packageContext) { }
                
        public Task<PackageDto> Handle(PackageByIdRequest request, CancellationToken cancellationToken)
        {
            var package = _packageContext.Packages.FirstOrDefault(p => p.Id == request.Id);

            if(package == null)
            {
                return null;
            }

            return Task.FromResult(_mapper.Map<PackageDto>(package)); 
        }
    }
}
