using AutoMapper;
using MediatR;
using WebApp.Models;
using WebApp.Requests;

namespace WebApp.Handlers
{
    public class EditRecipientRequestHandler : WebAppRequestHandlerBase, IRequestHandler<EditRecipientRequest>
    {
        public EditRecipientRequestHandler(IMapper mapper, IPackageContext packageContext) 
            : base(mapper, packageContext)
        {
        }

        public Task<Unit> Handle(EditRecipientRequest request, CancellationToken cancellationToken)
        {
            var recipient = _packageContext.Recipients.FirstOrDefault(r => r.Id == request.Recipient.Id);

            if(recipient != null) 
            {
                recipient.Address = request.Recipient.Address;
                recipient.Name= request.Recipient.Name;
            }

            return Task.FromResult(new Unit());
        }
    }
}
