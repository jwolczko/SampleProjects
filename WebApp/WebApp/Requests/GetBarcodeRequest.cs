using MediatR;

namespace WebApp.Requests
{
    public class GetBarcodeRequest : IRequest<byte[]>
    {
        public int PackageId { get; set; }

        public GetBarcodeRequest(int packageId) => PackageId = packageId;
    }
}
