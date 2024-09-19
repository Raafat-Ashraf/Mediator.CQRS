using Mediator.CQRS.Shared.Models;
using MediatR;

namespace Mediator.CQRS.Application.Commands;

public record AddUserCommand(
    int Id,
    string FirstName,
    string LastName
) : IRequest<UserModel>;