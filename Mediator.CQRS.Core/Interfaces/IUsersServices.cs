using Mediator.CQRS.Shared.Models;

namespace Mediator.CQRS.Core.Interfaces;

public interface IUsersServices
{
    UserModel AddUser(UserModel user);
    List<UserModel> GetUsers();
    UserModel GetUserByIndex(int index);
}
