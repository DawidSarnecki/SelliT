using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelliT.Domain.Entities
{
    class Invoice
    {
        public Guid ID { get; set; }
        public string Number { get; set; }
        public string PurchaserID { get; set; }
        public string SellerID { get; set; }
        public string DateOfInvoice{ set; get; }
        public string DateOfSell { set; get; }
        public string DateOfPay { set; get; }
    }
}
