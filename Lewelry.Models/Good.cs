using System.Runtime.Serialization;

namespace Jewlery.Models
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
        
        public override string ToString()
        {
            return Name;
        }
    }
}
