using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public abstract class AppControllerBase : ControllerBase
    {
        protected readonly IMediator _mediator;

        protected AppControllerBase(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
