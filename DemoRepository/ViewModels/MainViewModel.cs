using DemoRepository.Interfaces;
using DemoRepository.Models.Client.Entities;
using DemoRepository.Models.Client.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Patterns.Repository;

namespace DemoRepository.ViewModels
{
    public class MainViewModel
    {
        private ObservableCollection<CategoryViewModel> _items;

        public ObservableCollection<CategoryViewModel> Items
        {
            get
            {
                return _items ??= LoadItems();
            }
        }

        private ICategoryRepository<Category> _service;

        public MainViewModel()
        {
            _service = new CategoryService();            
        }

        private ObservableCollection<CategoryViewModel> LoadItems()
        {
            return new ObservableCollection<CategoryViewModel>(_service.Get().Select(c => new CategoryViewModel(c)));
        }
    }
}
