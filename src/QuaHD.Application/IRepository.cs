using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Application
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();

        TEntity GetById(object id);

        void Insert(TEntity entity);

        void Insert(List<TEntity> entities);

        void Update(TEntity entity);

        void Update(List<TEntity> entities);

        void Delete(TEntity entity);

        void Delete(List<TEntity> entities);
    }
}
