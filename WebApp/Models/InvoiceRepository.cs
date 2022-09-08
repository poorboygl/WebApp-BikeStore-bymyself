using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class InvoiceRepository : BaseRepository
    {
        public InvoiceRepository(IDbConnection connetion) : base(connetion) { }
        public int Add(Invoice obj)
        {
            return connection.Execute("AddInvoice",
                new { cartid = obj.CartID, obj.Fullname, obj.Email, obj.Phone, obj.WardID, obj.Address, obj.AccountID },
                commandType: CommandType.StoredProcedure
                );
        }
        public Invoice GetInvoicebyID(Guid id)
        {
            string sql = "select * from Invoice where InvoiceID = @ID";
            return connection.QuerySingle<Invoice>(sql, new { ID = id });
        }

    }
}
