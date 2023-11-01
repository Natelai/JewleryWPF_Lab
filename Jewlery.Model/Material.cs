using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Jewlery.Model
{
    [DataContract]
    public class Material
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public double Value { get; set; }

        [DataMember]
        public double Price { get; set; }
    }
}
