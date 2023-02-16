using AutoMapper;
using MediatR;
using WebApp.Models;
using WebApp.Requests;

namespace WebApp.Handlers
{
    public class EditPackageRequestHandler : WebAppRequestHandlerBase, IRequestHandler<EditPackageRequest>
    {
        public EditPackageRequestHandler(IMapper mapper, IPackageContext packageContext) 
            : base(mapper, packageContext)
        {
        }

        public Task<Unit> Handle(EditPackageRequest request, CancellationToken cancellationToken)
        {
            var package = _packageContext.Packages.SingleOrDefault(p => p.Id == request.Package.Id);

            if(package == null)
                return Task.FromResult(new Unit());

            package.Name = request.Package.Name;
            package.Description= request.Package.Description;
            package.Status = request.Package.Status;
            package.LastUpdated = DateTime.Now;

            return Task.FromResult(new Unit());
        }
    }
}
