using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Invoice
    {
        public Guid InvoiceID { get; set; }
        public Guid CartID { get; set; }
        public Guid AccountID { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string ProvincedID { get; set; }
        public string DistrictID { get; set; }
        public string WardID { get; set; }
        public IEnumerable<InvoiceDetail> InvoiceDetails { get; set; }

    }
}
