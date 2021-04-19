using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRepository.Models.Client.Entities
{
    public class Category
    {       
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }        

        public Category(string name, string description = null)
        {
            Name = name;
            Description = description;
        }

        internal Category(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}
