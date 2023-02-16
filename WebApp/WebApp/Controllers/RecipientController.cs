using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApp.Dto;
using WebApp.Requests;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipientController : AppControllerBase
    {
        public RecipientController(IMediator mediator) : base(mediator)
        {
        }

        // POST api/<RecipientController>
        [HttpPost]
        public async Task Post([FromBody] RecipientDto recipient)
        {
            await _mediator.Send(new AddRecipientRequest { Recipient = recipient }).ConfigureAwait(false);
        }

        // PUT api/<RecipientController>/5
        [HttpPut("edit")]
        public async Task Put([FromBody] RecipientDto recipient)
        {
            await _mediator.Send(new EditRecipientRequest { Recipient = recipient}).ConfigureAwait(false);
        }        
    }
}