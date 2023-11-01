using Jewlery.Models.Serialization;
using System.Runtime.Serialization;

namespace Jewlery.Models
{
    [DataContract]
    public class DataModel
    {
        [DataMember]
        public IEnumerable<Order> Orders { get; set; }

        [DataMember]
        public IEnumerable<Customer> Customers { get; set; }
        
        [DataMember]
        public IEnumerable<Material> Materials { get; set; }
        
        [DataMember]
        public IEnumerable<Good> Goods { get; set; }

        public DataModel()
        {
            Goods = new List<Good>() { new Good() { Name = "Ring", Description = "Very cool ring",  Price = 120 } };
            Materials = new List<Material> { new Material() { Name = "Gold", Value = 0.4, Price = 100 } };
            Customers = new List<Customer> { new Customer() { Name = "Ruslan", Category = "Student", Discount = 0.1 } };
            Orders = new List<Order> { new Order() { Customer = this.Customers.First(), Good = this.Goods.First(), Total = 100, OrderStatus = 0 } };
        }

        public static string DataPath = "jewlery2.dat";

        public static DataModel Load()
        {
            if(File.Exists(DataPath))
            {
                return DataSerializer.DesearializeItem(DataPath);
            }
            return new DataModel();
        }

        public void Save()
        {
            DataSerializer.SerializeData(DataPath, this);
        }
    }
}
