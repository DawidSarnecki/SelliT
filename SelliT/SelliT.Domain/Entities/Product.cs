using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelliT.Domain.Entities
{
    public class Product
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        //public string Description { get; set; }
        public string Unit { set; get; }
        public int Quantity { set; get; }
        public decimal Price { get; set; }
        public int Tax { set; get; }
        //public int ValueWithTax { set; get; }
        //public string Category { set; get; }
    }
}
