using System;
using System.Collections.Generic;
using System.Text;
using Tools.Patterns.Repository;

namespace DemoRepository.Interfaces
{
    public interface IActorRepository<TEntity>
    {
        IEnumerable<TEntity> Get();
        TEntity Get(int id);
        void Insert(TEntity entity);
        void Update(int id, TEntity entity);
        IEnumerable<TEntity> GetByMovieId(int movieId);
    }
}
