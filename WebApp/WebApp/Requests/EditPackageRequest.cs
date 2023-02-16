using MediatR;
using WebApp.Dto;

namespace WebApp.Requests
{
    public class EditPackageRequest : IRequest
    {
        public PackageDto Package { get; set; }
    }
}