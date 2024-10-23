using Microsoft.EntityFrameworkCore;
using OnionLearn.Application.Interfaces.Repositories;
using OnionLearn.Application.Interfaces.UnitOfWork;
using OnionLearn.Domain.Common;
using Persistence.Context;
using Persistence.Repository;

namespace Persistence.UnitOfWorks;

public class UnitOfWork(AppDbContext dbContext) : IUnitOfWork
{
    public ValueTask DisposeAsync() => dbContext.DisposeAsync();

    public IReadRepository<T> GetReadRepository<T>() where T : class, IEntityBase, new() =>
        new ReadRepository<T>(dbContext);

    public IWriteRepository<T> GetWriteRepository<T>() where T : class, IEntityBase, new() => new WriteRepository<T>(dbContext);

    public async Task<int> SaveAsync() => await dbContext.SaveChangesAsync();

    public int Save() => dbContext.SaveChanges();
}