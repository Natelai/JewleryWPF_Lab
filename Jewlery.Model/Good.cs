using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Jewlery.Model
{
    [DataContract]
    public class Good
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public double Price { get; set; }

        [DataMember]
        public Material Material { get; set; }
    }
}
