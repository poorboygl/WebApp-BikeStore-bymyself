using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Core
{
    class CategoryMapper :IRowMapper<Category>
    {
        public Category MapRow(IDataReader reader)
        {
            return new Category
            {
                ID = (short)reader["CategoryID"],
                Name = (string)reader["CategoryName"]
            };
        }
    }
}
