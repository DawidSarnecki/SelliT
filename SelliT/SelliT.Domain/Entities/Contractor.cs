using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelliT.Domain.Entities
{
    public class Contractor
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string NIP { set; get; }
        public string Street { set; get; }
        public string Number { set; get; }
        public string ZipCode { set; get; }
        public string City { set; get; }
    }
}
