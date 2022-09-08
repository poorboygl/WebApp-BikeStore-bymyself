using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    class Product
    {
        public int ID { get; set; }
        public short CategoryID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public string Description { get; set; }

        public string Specification { get; set; }
        public string ImageURL { get; set; }
        public int UnitOfPrice { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
