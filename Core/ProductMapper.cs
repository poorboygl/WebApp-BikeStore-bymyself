using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Core
{
    class ProductMapper : IRowMapper<Product>
    {
        public virtual Product MapRow(IDataReader reader)
        {
            return new Product
            {
                ID = (int)reader["ProductID"],
                CategoryID = (short)reader["CategoryID"],
                Code = (string)reader["ProductCode"],
                Name = (string)reader["ProductName"],
                ImageURL = (string)reader["ImageURL"],
                Unit = (string)reader["Unit"],
                UnitOfPrice = (int)reader["UnitOfPrice"]

            };
        }
        public class ProductExMapper: ProductMapper
        {
            public override Product MapRow(IDataReader reader)
            {
                Product obj = base.MapRow( reader);
                obj.Description = (string)reader["Description"];
                obj.Specification = (string)reader["Specification"];
                return obj;

            }
        }
    }
}
