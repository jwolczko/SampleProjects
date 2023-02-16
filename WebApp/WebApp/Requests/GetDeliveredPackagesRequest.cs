using MediatR;
using WebApp.Dto;

namespace WebApp.Requests
{
    public class GetDeliveredPackagesRequest: IRequest<IEnumerable<PackageDto>>
    {
        public string Status => "DELIVERED";
    }


}