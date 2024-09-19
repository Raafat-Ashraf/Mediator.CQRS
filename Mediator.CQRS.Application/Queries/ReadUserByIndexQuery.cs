using Mediator.CQRS.Shared.Models;
using MediatR;

namespace Mediator.CQRS.Application.Queries;

public record ReadUserByIndexQuery(int Index) : IRequest<UserModel>;