using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Jewlery.Model
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Category { get; set; }

        [DataMember]
        public double Discount { get; set; }
    }
}
