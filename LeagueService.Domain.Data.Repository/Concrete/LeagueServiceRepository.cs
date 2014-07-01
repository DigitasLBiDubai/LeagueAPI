using System;
using System.Data.Entity;
using System.Linq;
using LeagueService.Domain.Data.Repository.Abstract;

namespace LeagueService.Domain.Data.Repository.Concrete
{
    public class LeagueServiceRepository : IRepository
    {
        private readonly DbContext _context;

        public LeagueServiceRepository(DbContext context)
        {
            _context = context;
        }

        public LeagueServiceRepository()
		{
            _context = new LeagueServiceContext();
		}

        public IQueryable<TEntity> GetAll<TEntity>()
        {
            var entities = _context.Set(typeof(TEntity));
            return entities.OfType<TEntity>().AsQueryable();
        }

        public IQueryable<TEntity> Find<TEntity>(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            var entities = _context.Set(typeof(TEntity));
            return entities.OfType<TEntity>().Where(predicate).AsQueryable();
        }

        public TEntity Single<TEntity>(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            var entities = _context.Set(typeof(TEntity));
            return entities.OfType<TEntity>().Where(predicate).Single();
        }

        public TEntity First<TEntity>(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            var entities = _context.Set(typeof(TEntity));
            return entities.OfType<TEntity>().Where(predicate).First();
        }

        public void Add<TEntity>(TEntity entity)
        {
            _context.Set(typeof(TEntity)).Add(entity);
        }

        public void Delete<TEntity>(TEntity entity)
        {
            _context.Set(typeof(TEntity)).Remove(entity);
        }

        public void Attach<TEntity>(TEntity entity)
        {
            _context.Set(typeof(TEntity)).Attach(entity);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}