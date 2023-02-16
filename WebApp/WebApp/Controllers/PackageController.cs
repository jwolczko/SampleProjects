using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApp.Dto;
using WebApp.Requests;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackageController : AppControllerBase
    {

        public PackageController(IMediator mediator)
            : base(mediator)
        {
        }
        // GET: api/<PackageController>
        [HttpGet]
        public async Task<IEnumerable<PackageDto>> Get()
        {
            return await _mediator.Send(new AllPackagesRequest());
        }


        [HttpGet("delivered")]
        public async Task<IEnumerable<PackageDto>> GetDeliveredPackages()
        {
            return await _mediator.Send(new GetDeliveredPackagesRequest()).ConfigureAwait(false);
        }

        [HttpGet("{id}")]
        public async Task<PackageDto> Get(int id)
        {
            return await _mediator.Send(new PackageByIdRequest { Id = id }).ConfigureAwait(false);
        }

        // GET: api/<PackageController>
        [HttpGet("recipient/{recipientsName}")]
        public async Task<IEnumerable<PackageDto>> GetForRecipient(string recipientsName)
        {
            return await _mediator.Send(new GetForRecipientPackagesRequest(recipientsName)).ConfigureAwait(false);           
        }

        [HttpGet("barcode/{id}")]
        public async Task<IActionResult> GetBarcode(int id)
        {
            byte[] image = await _mediator.Send(new GetBarcodeRequest(id)).ConfigureAwait(false);
            return File(image, "image/jpeg");          
        }

        [HttpPost]
        public async Task AddPackage([FromBody]PackageDto package)
        {
            await _mediator.Send(new AddPackageRequest { Package = package }).ConfigureAwait(false);
        }

        // PUT api/<PackageController>/5
        [HttpPut("edit")]
        public async Task EditPackage([FromBody] PackageDto package)
        {
            await _mediator.Send(new EditPackageRequest { Package = package }).ConfigureAwait(false);
        }
    }
}
