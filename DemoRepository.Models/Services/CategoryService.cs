using DemoRepository.Interfaces;
using DemoRepository.Models.Entities;
using DemoRepository.Models.Mappers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Tools.Connections.Database;
using Tools.Patterns.Repository;

namespace DemoRepository.Models.Services
{
    public class CategoryService : ICategoryRepository<Category>
    {
        private readonly Connection _connection;

        public CategoryService()
        {
            _connection = new Connection(SqlClientFactory.Instance, @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MoviesDB;Integrated Security=True;");
        }        

        public IEnumerable<Category> Get()
        {
            Command command = new Command("Select Id, Name, [Description] from Category;");
            return _connection.ExecuteReader(command, (dr) => dr.ToCategory());
        }

        public Category Get(int id)
        {
            Command command = new Command("Select Id, Name, [Description] from Category Where Id = @Id;");
            command.AddParameter("Id", id);
            return _connection.ExecuteReader(command, (dr) => dr.ToCategory()).SingleOrDefault();
        }

        public Category Insert(Category entity)
        {
            Command command = new Command("insert into Category (Name, [Description]) output inserted.id values (@Name, @Description);");
            command.AddParameter("Name", entity.Name);
            command.AddParameter("Description", entity.Description);
            //Recuperer l'id
            entity.Id = (int)_connection.ExecuteScalar(command);            
            //retourner la categorie avec son id
            return entity;
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
