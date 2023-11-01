using System.Runtime.Serialization;

namespace Jewlery.Models
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
        public override string ToString()
        {
            return Name;
        }
    }
}
