

namespace Persistense.DAL
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        TEntity Create(TEntity entity);

        TEntity Get(Guid id);

        void Update(TEntity entity);

        void Delete(Guid id);
    }

}

