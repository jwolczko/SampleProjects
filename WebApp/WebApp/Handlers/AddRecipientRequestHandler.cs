using AutoMapper;
using MediatR;
using WebApp.Models;
using WebApp.Requests;

namespace WebApp.Handlers
{
    public class AddRecipientRequestHandler : WebAppRequestHandlerBase, IRequestHandler<AddRecipientRequest>
    {
        public AddRecipientRequestHandler(IMapper mapper, IPackageContext packageContext) 
            : base(mapper, packageContext)
        {
        }

        public Task<Unit> Handle(AddRecipientRequest request, CancellationToken cancellationToken)
        {
            var recipient = _mapper.Map<Recipient>( request.Recipient);

            _packageContext.Recipients.Add(recipient);

            return Task.FromResult(new Unit());
        }
    }
}