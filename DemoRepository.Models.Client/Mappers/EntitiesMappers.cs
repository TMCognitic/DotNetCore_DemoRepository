using DemoRepository.Models.Client.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using GE = DemoRepository.Models.Entities;

namespace DemoRepository.Models.Client.Mappers
{
    internal static class EntitiesMappers
    {
        internal static GE.Category ToGlobal(this Category entity)
        {
            return new GE.Category()
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description
            };
        }

        internal static Category ToClient(this GE.Category entity)
        {
            return new Category(entity.Id, entity.Name, entity.Description);
        }
    }
}
