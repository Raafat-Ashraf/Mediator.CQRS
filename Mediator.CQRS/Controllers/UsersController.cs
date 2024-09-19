using Mediator.CQRS.Application.Commands;
using Mediator.CQRS.Application.Queries;
using Mediator.CQRS.Shared.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Mediator.CQRS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }



        [HttpGet("")]
        public async Task<ActionResult<List<UserModel>>> GetAll()
        {
            return Ok(await _mediator.Send(new ReadUsersQuery()));
        }


        [HttpGet("{index:int}")]
        public async Task<ActionResult<UserModel>> Get(int index)
        {
            return await _mediator.Send(new ReadUserByIndexQuery(index));
        }


        [HttpPost("")]
        public async Task<ActionResult<UserModel>> Add(AddUserCommand command)
        {
            var query = new AddUserCommand(command.Id, command.FirstName, command.LastName);
            return await _mediator.Send(query);
        }


    }
}
