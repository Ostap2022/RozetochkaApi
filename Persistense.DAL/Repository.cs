using Microsoft.EntityFrameworkCore;
using Persistense.DAL.Entities;

namespace Persistense.DAL
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
   
    
        private readonly RozetochkaDbContext _ctx;

        public Repository(RozetochkaDbContext ctx)
        {
            _ctx = ctx;
        }

        public DbSet<TEntity> GetTable() => _ctx.Set<TEntity>();

        public TEntity Create(TEntity entity)
        {
            var result = GetTable().Add(entity).Entity;
            _ctx.SaveChanges();
            return result;
        }

        public void Delete(Guid id)
        {
            var entity = GetTable().FirstOrDefault(e => e.Id == id);
            _ctx.Entry(entity).State = EntityState.Deleted;
            _ctx.SaveChanges();
        }

        public TEntity Get(Guid id)
        {
            return GetTable().FirstOrDefault(e => e.Id == id);
        }

        public void Update(TEntity entity)
        {
            _ctx.Entry(entity).State = EntityState.Modified;
            _ctx.SaveChanges();
        }

    }
}
