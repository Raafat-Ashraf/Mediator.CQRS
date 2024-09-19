using Mediator.CQRS.Application.Commands;
using Mediator.CQRS.Core.Interfaces;
using Mediator.CQRS.Shared.Models;
using MediatR;

namespace Mediator.CQRS.Application.Handlers.CommandHandler;

public class AddUserCommandHandler : IRequestHandler<AddUserCommand, UserModel>
{
    private readonly IUsersServices _usersServices;
    public AddUserCommandHandler(IUsersServices usersServices)
    {
        _usersServices = usersServices;
    }


    public Task<UserModel> Handle(AddUserCommand request, CancellationToken cancellationToken)
    {
        UserModel user = new()
        {
            Id = request.Id,
            FirstName = request.FirstName,
            LastName = request.LastName
        };

        return Task.FromResult(_usersServices.AddUser(user));
    }

}
