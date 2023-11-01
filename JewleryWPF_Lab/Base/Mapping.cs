using AutoMapper;
using Jewlery.Models;
using JewleryWPF_Lab.ViewModels;
using System.Collections.ObjectModel;

namespace JewleryWPF_Lab.Base
{
    public class Mapping
    {
        public void Create()
        {
            Mapper.CreateMap<DataModel, DataViewModel>()
                .ForMember(d => d.Orders, o => o.MapFrom(s => s.Orders))
                .ForMember(d => d.Materials, o => o.MapFrom(s => s.Materials))
                .ForMember(d => d.Goods, o => o.MapFrom(s => s.Goods))
                .ForMember(d => d.Customers, o => o.MapFrom(s => s.Customers));

            Mapper.CreateMap<DataViewModel, DataModel>()
                .ForMember(d => d.Orders, o => o.MapFrom(s => s.Orders))
                .ForMember(d => d.Materials, o => o.MapFrom(s => s.Materials))
                .ForMember(d => d.Goods, o => o.MapFrom(s => s.Goods))
                .ForMember(d => d.Customers, o => o.MapFrom(s => s.Customers));

            Mapper.CreateMap<Customer, CustomerViewModel>();

            Mapper.CreateMap<CustomerViewModel, Customer>();

            Mapper.CreateMap<Good, GoodViewModel>();

            Mapper.CreateMap<Good, Good>();
            Mapper.CreateMap<Order, Order>();
            Mapper.CreateMap<Material, Material>();
            Mapper.CreateMap<OrderStatus, OrderStatus>();

            Mapper.CreateMap<GoodViewModel, Good>();

            Mapper.CreateMap<Material, MaterialViewModel>();

            Mapper.CreateMap<MaterialViewModel, Material>();

            Mapper.CreateMap<Order, OrderViewModel>();

            Mapper.CreateMap<OrderViewModel, Order>();
        }
    }
}
