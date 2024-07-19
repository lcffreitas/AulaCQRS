using CQRS.Domain.Handlers;
using CQRS.Domain.Request;
using CQRS.Domain.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Controllers
{
    [Route("v1/api/[controller]")]
    [ApiController]
    public class PersonController(IAddPersonHandler handler) : ControllerBase
    {
        private readonly IAddPersonHandler _handler = handler;

        [HttpPost]
        public AddPersonResponse Add(AddPersonRequest command)
        {
            return _handler.Handler(command);
        }
    }
}
