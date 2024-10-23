using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace OnionLearn.Application;

public static class Registration
{
    public static void AddApplication(this IServiceCollection services)
    {
        var assembly = Assembly.GetExecutingAssembly();
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assembly));
        

    }
}