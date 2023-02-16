using MediatR;
using WebApp.Dto;

namespace WebApp.Requests
{
    public class EditRecipientRequest : IRequest
    {
        public RecipientDto Recipient { get; set; }
    }
}
