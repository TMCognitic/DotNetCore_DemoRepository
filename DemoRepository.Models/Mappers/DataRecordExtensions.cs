using DemoRepository.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DemoRepository.Models.Mappers
{
    internal static class DataRecordExtensions
    {
        internal static Category ToCategory(this IDataRecord dataRecord)
        {
            return new Category() { Id = (int)dataRecord["Id"], Name = (string)dataRecord["Name"], Description = dataRecord["Description"] is DBNull ? null : (string)dataRecord["Description"] };
        }
    }
}
