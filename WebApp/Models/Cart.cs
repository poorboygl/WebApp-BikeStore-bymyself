using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Cart
    {
        public Guid CartID { get; set; }
        public int ProductID { get; set; }

        public string ProductName { get; set; }
        public int UnitofPrice { get; set; }
        public string ImageUrl { get; set; }
        public short Quantity { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
