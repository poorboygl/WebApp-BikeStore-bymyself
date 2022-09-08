using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class ProductRepository : BaseRepository
    {
        public ProductRepository(IDbConnection connection) : base(connection) { }
        public IEnumerable<Product> SearchProducts(string q)
        {
            string sql = "SearchProducts";
            return connection.Query<Product>(sql, new { Q = '%' + q + '%' }, commandType: CommandType.StoredProcedure);
        }
        public IEnumerable<Product> GetProductsByCategory(short id, int index, int size, out int total)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@id", id, dbType: DbType.Int16);
            parameters.Add("@Index", index, dbType: DbType.Int32);
            parameters.Add("@Size", size, dbType: DbType.Int32);
            parameters.Add("@Total", dbType: DbType.Int32, direction: ParameterDirection.Output);
            IEnumerable<Product> list = connection.Query<Product>("GetProductsByCategory", parameters, commandType: CommandType.StoredProcedure);
            total = parameters.Get<int>("@Total");
            return list;
        }
        public IEnumerable<Product> GetProducts(int index, int size, out int total)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Index", index, dbType: DbType.Int32);
            parameters.Add("@Size", size, dbType: DbType.Int32);
            parameters.Add("@Total", dbType: DbType.Int32, direction: ParameterDirection.Output);
            IEnumerable<Product> list = connection.Query<Product>("GetProductsPagination", parameters, commandType: CommandType.StoredProcedure);
            total = parameters.Get<int>("@Total");
            return list;
        }
        public Dictionary<short, List<Product>> keyValuePairs()
        {
            IEnumerable<Product> products = GetProducts();
            Dictionary<short, List<Product>> dict = new Dictionary<short, List<Product>>();
            foreach (Product item in products)
            {
                short key = item.CategoryId;
                if (!dict.ContainsKey(key))
                {
                    dict[key] = new List<Product>();
                }
                dict[key].Add(item);
            }
            return dict;
        }
        public IEnumerable<Product> GetProducts()
        {
            return connection.Query<Product>("GetProducts", commandType: CommandType.StoredProcedure);
        }
        public IEnumerable<Product> GetProductsByCategory(short id)
        {
            string sql = "select * from Product Where categoryID = @ID";
            return connection.Query<Product>(sql, new { ID = id });
        }
        public Product GetProduct(int id)
        {
            string sql = "select * from Product Where ProductID = @ID";
            return connection.QuerySingle<Product>(sql, new { ID = id });
        }
        public IEnumerable<Product> GetProductsRelation(short categoryID, int id)
        {
            string sql = "select Top 6 * from Product Where CategoryID = @CategoryID and productID <> @ID order by NewID()";
            return connection.Query<Product>(sql, new { CategoryID = categoryID, ID = id });
        }
    }
}
