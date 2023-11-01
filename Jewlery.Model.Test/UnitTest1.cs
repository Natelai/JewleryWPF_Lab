//using DocumentFormat.OpenXml.Drawing.Diagrams;
using Jewlery.Model.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jewlery.Model.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestMethod]
        public void Test1()
        {
            var model = new DataModel();
            model.Goods = new List<Good>() { new Good() { Name = "fdsfsd", Description = "fdsfsdfsdf", Material = new Material() { Name = "Gold", Value = 0.2, Price = 5 }, Price = 10 } };
            model.Materials = new List<Material>() { new Material() { Name = "Gold", Value = 0.2, Price = 5 } };
            model.Customers = new List<Customer>() { new Customer() { Name = "Sasha", Category = "Norm", Discount = 0 } };
            model.Orders = new List<Order>() { new Order() { Customer = new Customer() { Name = "Sasha", Category = "Norm", Discount = 0 }, Goods = new List<Good>() { new Good { Name = "fdsfsd", Description = "fdsfsdfsdf", Material = new Material() { Name = "Gold", Value = 0.2, Price = 5 }, Price = 10 } } } };

            DataSerializer.SerializeData(@"D:\\jewlery.dat", model);
        }
    }
}