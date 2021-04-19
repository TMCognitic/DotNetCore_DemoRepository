using DemoRepository.Models.Client.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRepository.ViewModels
{
    public class CategoryViewModel
    {
        private Category _entity;

        public CategoryViewModel(Category entity)
        {
            _entity = entity;
        }

        public string Name
        {
            get { return _entity.Name; }
        }

        public string Description
        {
            get { return _entity.Description; }
        }
    }
}
