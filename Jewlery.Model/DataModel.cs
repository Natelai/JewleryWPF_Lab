using Jewlery.Model.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Jewlery.Model
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
            Goods = new List<Good>() { new Good() { Name = "Ring", Description = "Very cool ring", Material = new Material() { Name = "Gold", Value = 0.4, Price = 100 }, Price = 120 } };
            Materials = new List<Material> { new Material() { Name = "Gold", Value = 0.4, Price = 100 } };
            Customers = new List<Customer> { new Customer() { Name = "Ruslan", Category = "Student", Discount = 0.1 } };
            Orders = new List<Order> { new Order() { Customer = this.Customers.First(), Goods = this.Goods, Total = 100 } };
        }

        public static string DataPath = "jewlery.dat";

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
