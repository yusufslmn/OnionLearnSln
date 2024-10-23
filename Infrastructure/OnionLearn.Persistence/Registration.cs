using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnionLearn.Application.Interfaces.Repositories;
using OnionLearn.Application.Interfaces.UnitOfWork;
using Persistence.Context;
using Persistence.Repository;
using Persistence.UnitOfWorks;

namespace Persistence;

public static class Registration
{
    public static void AddPersistence(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
        services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));
        services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
    
    
}