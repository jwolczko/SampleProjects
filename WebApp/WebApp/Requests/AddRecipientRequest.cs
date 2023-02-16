using MediatR;
using WebApp.Dto;

namespace WebApp.Requests
{
    public class AddRecipientRequest : IRequest
    {
        public RecipientDto Recipient { get; set; }
    }
}
