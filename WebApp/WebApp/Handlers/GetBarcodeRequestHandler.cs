using AutoMapper;
using BarcodeLib;
using MediatR;
using System.Drawing;
using System.Text;
using WebApp.Models;
using WebApp.Requests;

namespace WebApp.Handlers
{
    public class GetBarcodeRequestHandler : WebAppRequestHandlerBase, IRequestHandler<GetBarcodeRequest, byte[]>
    {
        public GetBarcodeRequestHandler(IMapper mapper, IPackageContext packageContext) 
            : base(mapper, packageContext)
        {
        }

        public Task<byte[]> Handle(GetBarcodeRequest request, CancellationToken cancellationToken)
        {
            var package = _packageContext.Packages.SingleOrDefault(p => p.Id == request.PackageId);

            if (package == null)
                return null;

            var hexa = Encoding.Default.GetBytes(package.PackageIdentifier);
            long value = BitConverter.ToInt64(hexa, 0);
            var strNumber = value.ToString();

            byte[] imgBytes;

            Barcode barcode = new Barcode();
            using (var img = barcode.Encode(TYPE.CODE128, strNumber))
            {
                ImageConverter converter = new ImageConverter();
                imgBytes = (byte[])converter.ConvertTo(img, typeof(byte[]));
            }
            return Task.FromResult(imgBytes);
        }
    }
}
