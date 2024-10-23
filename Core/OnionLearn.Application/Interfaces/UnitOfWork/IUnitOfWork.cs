using OnionLearn.Application.Interfaces.Repositories;
using OnionLearn.Domain.Common;

namespace OnionLearn.Application.Interfaces.UnitOfWork;

public interface IUnitOfWork : IAsyncDisposable
{
    IReadRepository<T> GetReadRepository<T>() where T : class,IEntityBase,new ();
    IWriteRepository<T> GetWriteRepository<T>() where T : class,IEntityBase,new ();
    Task<int> SaveAsync();
    int Save();
    
    
    
}