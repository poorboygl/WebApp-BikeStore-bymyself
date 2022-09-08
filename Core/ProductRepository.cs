using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Core
{
    class ProductRepository:BaseRepository<Product>
    {
        public ProductRepository(IDbConnection connection) : base(connection)
        {

        }
       
        public List<Product> GetProducts()
        {
            string sql = "select*from ProductID, CategoryID,ProductCode,ProductName,ImageUrl,Unit,UnitOfPrice from Product";
            return FetchAll(sql,new ProductMapper());
        }
        public List<Product> GetProductsByCategory(short id)
        {
            DynamicParameter parameter = new DynamicParameter();
            parameter.Add("@Id", id);
            return FetchAll("select * from product where categoryid = @id", parameter);
        }
        protected override Product Fetch(IDataReader reader)
        {
            return new Product
            {
                ID = (int)reader["ProductID"],
                CategoryID = (short)reader["CategoryID"],
                Code = (string)reader["ProductCode"],
                Name = (string)reader["ProductName"],
                ImageURL = (string)reader["ImageURL"],
                Unit= (string)reader["Unit"],
                UnitOfPrice = (int)reader["UnitOfPrice"]

            };
        }
    }
}
