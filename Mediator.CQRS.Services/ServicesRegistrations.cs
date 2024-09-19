using Mediator.CQRS.Core.Interfaces;
using Mediator.CQRS.Services.Users;
using Microsoft.Extensions.DependencyInjection;

namespace Mediator.CQRS.Services;
public static class ServicesRegistrations
{
    public static void AddServicesRegistrations(this IServiceCollection services)
    {
        services.AddScoped<IUsersServices, UserServices>();
    }
}
