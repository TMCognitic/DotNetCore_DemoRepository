using GS = DemoRepository.Models.Services;
using GE = DemoRepository.Models.Entities;
using DemoRepository.Interfaces;
using DemoRepository.Models.Client.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using DemoRepository.Models.Client.Mappers;

namespace DemoRepository.Models.Client.Services
{
    public class CategoryService : ICategoryRepository<Category>
    {
        readonly ICategoryRepository<GE.Category> _globalRepository;

        public CategoryService()
        {
            _globalRepository = new GS.CategoryService();
        }

        public IEnumerable<Category> Get()
        {
            return _globalRepository.Get().Select(c => c.ToClient());
        }

        public Category Get(int id)
        {
            return _globalRepository.Get(id)?.ToClient();
        }

        public Category Insert(Category entity)
        {
            return _globalRepository.Insert(entity.ToGlobal()).ToClient();
        }

        public void Update(int id, Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
