using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace opendataws.data.Abstract
{
    public interface IGenericRepository<TEntity>
    {
        TEntity Create(TEntity entity);

        List<TEntity> GetAll();

        TEntity Update(TEntity entity);

        TEntity GetById(int id);

        void Delete(int id);
    }
}