using MediatR;
using WebApp.Dto;

namespace WebApp.Requests
{
    public class AddPackageRequest: IRequest
    {
        public PackageDto Package { get; set; }
    }
}
