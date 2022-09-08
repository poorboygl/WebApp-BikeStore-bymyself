using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class InvoiceDetail
    {
        public Guid InvoiceID { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ImageUrl { get; set; }
        public int UnitOfPrice { get; set; }
        public short Quantity { get; set; }
    }
}
