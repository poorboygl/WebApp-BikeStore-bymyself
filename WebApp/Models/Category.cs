using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Category
    {
        public short CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryCode { get; set; }
        public List<Product> Products { get; set; }
    }
}
