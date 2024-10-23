using Microsoft.EntityFrameworkCore;
using OnionLearn.Application.Interfaces.Repositories;
using OnionLearn.Domain.Common;

namespace Persistence.Repository;

public class WriteRepository<T>(DbContext dbContext) : IWriteRepository<T>
    where T : class, IEntityBase, new()
{
    private DbSet<T> Table => dbContext.Set<T>();

    public async Task AddAsync(T entity)
    {
        await Table.AddAsync(entity);
    }

    public async Task AddRangeAsync(IList<T> entities)
    {
        await Table.AddRangeAsync(entities);
    }
    public async Task<T> UpdateAsync(T entity)
    {
        await Task.Run(() => Table.Update(entity));
        return entity;
    }
    public async Task HardDeleteAsync(T entity)
    {
        await Task.Run(() => Table.Remove(entity));
    }
        
    public async Task HardDeleteRangeAsync(IList<T> entity)
    {
        await Task.Run(() => Table.RemoveRange(entity));
    }

    public async Task SoftDeleteAsync(T entity)
    {
        await Task.Run(() => Table.Update(entity));
    }
}