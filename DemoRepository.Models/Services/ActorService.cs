using DemoRepository.Interfaces;
using DemoRepository.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoRepository.Models.Services
{
    public class ActorService : IActorRepository<Actor>
    {
        public IEnumerable<Actor> Get()
        {
            throw new NotImplementedException();
        }

        public Actor Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Actor> GetByMovieId(int movieId)
        {
            throw new NotImplementedException();
        }

        public void Insert(Actor entity)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Actor entity)
        {
            throw new NotImplementedException();
        }
    }
}
