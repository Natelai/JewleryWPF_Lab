using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Jewlery.Model
{
    [DataContract]
    public class Order
    {
        [DataMember]
        public IEnumerable<Good> Goods { get; set; }

        [DataMember]
        public Customer Customer { get; set; }

        [DataMember]
        public double Total { get; set; }
    }
}
