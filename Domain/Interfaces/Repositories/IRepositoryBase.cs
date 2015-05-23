using System.Collections.Generic;

namespace Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        TEntity Add(TEntity item);
        TEntity GetById(int id);
        IEnumerable<TEntity> Get();
        void Update(TEntity item);
        void Delete(int id);
    }
}