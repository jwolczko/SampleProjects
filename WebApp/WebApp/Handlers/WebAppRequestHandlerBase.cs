using AutoMapper;
using WebApp.Models;

namespace WebApp.Handlers
{
    public abstract class WebAppRequestHandlerBase
    {
        protected readonly IMapper _mapper;
        protected readonly IPackageContext _packageContext;
        protected WebAppRequestHandlerBase(IMapper mapper, IPackageContext packageContext) 
        { 
            _mapper = mapper;
            _packageContext = packageContext;
        }
    }
}
