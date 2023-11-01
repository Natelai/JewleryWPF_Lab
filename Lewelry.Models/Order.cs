using System.Runtime.Serialization;

namespace Jewlery.Models
{
    [DataContract]
    public class Order
    {
        [DataMember]
        public Good Good { get; set; }

        [DataMember]
        public Customer Customer { get; set; }

        [DataMember]
        public double Total { get; set; }

        [DataMember]
        public OrderStatus OrderStatus { get; set; }
    }

    [DataContract]
    public enum OrderStatus
    {
        [EnumMember]
        New,
        [EnumMember]
        Cancelled,
        [EnumMember]
        Finished
    }

}
