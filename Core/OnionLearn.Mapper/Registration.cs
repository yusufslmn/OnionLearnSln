using Microsoft.Extensions.DependencyInjection;
using OnionLearn.Application.Interfaces.AutoMapper;

namespace OnionLearn.AutoMapper;

public static class Registration
{
    public static void AddCustomMapper(this IServiceCollection services)
    {
        services.AddSingleton<IMapper, AutoMapper.Mapper>();
    }
    
}