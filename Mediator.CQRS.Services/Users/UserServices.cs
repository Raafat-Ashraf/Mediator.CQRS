using Mediator.CQRS.Core.Interfaces;
using Mediator.CQRS.Shared.Models;

namespace Mediator.CQRS.Services.Users;

public class UserServices : IUsersServices
{

    private static readonly List<UserModel> Users = new()
    {
        new UserModel {Id = 1,FirstName = "Ahmed",LastName = "Mohamed" },
        new UserModel {Id = 2,FirstName = "Raafat",LastName = "Ashraf" },
        new UserModel {Id = 3,FirstName = "Mohamed",LastName = "Ashraf" },
        new UserModel {Id = 4,FirstName = "Maia",LastName = "Ali" },
    };


    public List<UserModel> GetUsers()
    {
        return Users;
    }


    public UserModel GetUserByIndex(int index)
    {
        return Users[index];
    }


    public UserModel AddUser(UserModel user)
    {
        Users.Add(user);
        return user;
    }

}
