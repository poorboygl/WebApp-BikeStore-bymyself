using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class InvoiceDetailRepository : BaseRepository
    {
        public InvoiceDetailRepository(IDbConnection connetion) : base(connetion) { }
        public IEnumerable<InvoiceDetail> GetInvoiceDetailsByInvoice(Guid id)
        {
            string sql = "select invoicedetail.*, ProductName,ImageURL from InvoiceDetail " +
                "Join Product on InvoiceDetail.ProductID=Product.ProductID where InvoiceID=@iD";
            return connection.Query<InvoiceDetail>(sql, new { ID = id });
        }
    }
}
