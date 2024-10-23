using System.Collections;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using OnionLearn.Application.Interfaces.Repositories;
using OnionLearn.Domain.Common;

namespace Persistence.Repository;

public class ReadRepository<T>(DbContext context) : IReadRepository<T>
    where T : class, IEntityBase, new()

{
    private DbSet<T> Table => context.Set<T>();

    public async Task<IList<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, bool enableTracking = false)
    {
        IQueryable<T> queryable = Table;
        if(!enableTracking) queryable = queryable.AsNoTracking();
        if(include != null) queryable = include(queryable);
        if(predicate != null) queryable = queryable.Where(predicate);
        if(orderBy != null) return await  orderBy(queryable).ToListAsync();
        
        return await queryable.ToListAsync();

    }

    public async Task<IList<T>> GetAllByPagingAsync(Expression<Func<T, bool>>? predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
        bool enableTracking = false, int currentPage = 1, int pageSize = 3)
    {
        IQueryable<T> queryable = Table;
        if(!enableTracking) queryable = queryable.AsNoTracking();
        if(include != null) queryable = include(queryable);
        if(predicate != null) queryable = queryable.Where(predicate);
        if(orderBy != null) return await  orderBy(queryable).Skip((currentPage -1 ) * pageSize).ToListAsync();
        
        return await queryable.Skip((currentPage -1 ) * pageSize).ToListAsync();

    }

    public async Task<T> GetAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, bool enableTracking = false)
    {
        IQueryable<T> queryable = Table;
        if(!enableTracking) queryable = queryable.AsNoTracking();
        if(include != null) queryable = include(queryable);
      
        return await queryable.FirstOrDefaultAsync(predicate) ?? throw new NullReferenceException();

    }

    public  IQueryable<T> Find(Expression<Func<T, bool>> predicate, bool enableTracking = false)
    {
       if(!enableTracking) Table.AsNoTracking();
       return  Table.Where(predicate);
    }

    public async Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null)
    {
        Table.AsNoTracking();
        if (predicate is not null) Table.AsNoTracking();
        
        return await Table.CountAsync();
    }
}