using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelliT.Domain.Entities
{
    class InvoiceElement
    {
        public Guid ID { get; set; }
        public string InvoiceID { get; set; }
        public string ProductID { set; get; }
        
    }
}
