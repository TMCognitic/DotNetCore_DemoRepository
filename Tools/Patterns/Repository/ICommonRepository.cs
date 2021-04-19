using System;
using System.Collections.Generic;
using System.Text;

namespace Tools.Patterns.Repository
{
    public interface ICommonRepository<TEntity>
    {
        IEnumerable<TEntity> Get();
        TEntity Get(int id);
        TEntity Insert(TEntity entity);
        void Update(int id, TEntity entity);
        void Delete(int id);
    }
}
