using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace opendataws.business.Abstract
{
    public interface IGenericService<TEntity>
    {
        void Delete(int id);
        TEntity GetById(int id);
        List<TEntity> GetAll();
        TEntity Update(TEntity test);
        TEntity Create(TEntity test);

    }
}