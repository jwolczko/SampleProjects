using AutoMapper;
using MediatR;
using WebApp.Models;
using WebApp.Requests;

namespace WebApp.Handlers
{
    public class AddPackageRequestHandler : WebAppRequestHandlerBase, IRequestHandler<AddPackageRequest>
    {
        public AddPackageRequestHandler(IMapper mapper, IPackageContext packageContext) 
            : base(mapper, packageContext)
        {
        }

        public Task<Unit> Handle(AddPackageRequest request, CancellationToken cancellationToken)
        {
            var package = _mapper.Map<Package>(request.Package);

            if(package != null) 
            {
                package.Status = "RECEIVED";
                _packageContext.Packages.Add(package);            
            }

            return Task.FromResult(new Unit());
        }
    }
}
