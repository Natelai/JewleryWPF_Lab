using System.Runtime.Serialization;

namespace Jewlery.Models
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
