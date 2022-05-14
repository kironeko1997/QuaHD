using Microsoft.EntityFrameworkCore;
using QuaHD.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Application
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private QuaHDContext _context;

        public Repository(QuaHDContext context)
        {
            _context = context;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().AsEnumerable();
        }

        public TEntity GetById(object id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public void Insert(TEntity entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Insert(List<TEntity> entities)
        {
            _context.Add(entities);
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Update(List<TEntity> entities)
        {
            _context.Entry(entities).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public void Delete(List<TEntity> entities)
        {
            _context.Remove(entities);
            _context.SaveChanges();
        }
    }
}
