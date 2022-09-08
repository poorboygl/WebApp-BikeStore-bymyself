using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class CartRepository : BaseRepository
    {
        public CartRepository(IDbConnection connetion) : base(connetion) { }
        public IEnumerable<Cart> GetCarts(Guid id)
        {
            string sql = "Select Cart.*,ProductName,UnitOfPrice, ImageURL from Cart Join Product On cart.productID = product.ProductID  where cartid = @id";
            return connection.Query<Cart>(sql, new { ID = id });
        }
        public int Add(Cart obj)
        {
            string sql = "AddCart";
            return connection.Execute(sql, new { cartID = obj.CartID, obj.ProductID, obj.Quantity }, commandType: CommandType.StoredProcedure);
        }
        public int Delete(Guid cartID, int productID)
        {
            string sql = "Delete from Cart Where CartID = @CartID and ProductID = @productid";
            return connection.Execute(sql, new { cartID, ProductID = productID });
        }
        public int Update(Cart obj)
        {
            string sql = "Update Cart set quantity=@quantity where CartID = @CartID and ProductID = @productid";
            return connection.Execute(sql, new { cartID = obj.CartID, obj.ProductID, obj.Quantity });
        }
    }
}
