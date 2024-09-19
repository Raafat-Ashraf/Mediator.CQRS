using Mediator.CQRS.Application.Queries;
using Mediator.CQRS.Core.Interfaces;
using Mediator.CQRS.Shared.Models;
using MediatR;

namespace Mediator.CQRS.Application.Handlers.QueriesHandler;

public class ReadUsersQueryHandler : IRequestHandler<ReadUsersQuery, List<UserModel>>
{
    private readonly IUsersServices _usersServices;
    public ReadUsersQueryHandler(IUsersServices usersServices)
    {
        _usersServices = usersServices;
    }


    public async Task<List<UserModel>> Handle(ReadUsersQuery request, CancellationToken cancellationToken)
    {
        return await Task.FromResult(_usersServices.GetUsers());
    }


}
