using MediatR;
using WebApp.Dto;

namespace WebApp.Requests
{
    public class GetForRecipientPackagesRequest:  IRequest<IEnumerable<PackageDto>>
    {
        public string RecipientName { get; set; }
        public GetForRecipientPackagesRequest(string recipientName) => RecipientName = recipientName;
    }
}
