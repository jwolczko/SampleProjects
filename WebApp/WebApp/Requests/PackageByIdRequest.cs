using MediatR;
using WebApp.Dto;

namespace WebApp.Requests
{
    public class PackageByIdRequest : IRequest<PackageDto>
    {
        public int Id { get; set; }
    }
}
