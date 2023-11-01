using Jewlery.Models;
using SampleMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JewleryWPF_Lab.ViewModels
{
    public class OrderViewModel : ViewModelBase
    {
        private Good _good;
        public Good Good
        {
            get { return _good; }
            set
            {
                _good = value;
                OnPropertyChanged("Good");
            }
        }

        private Customer _customer;
        public Customer Customer
        {
            get { return _customer; }
            set
            {
                _customer = value;
                OnPropertyChanged("Customer");
            }
        }

        private double _total;
        public double Total
        {
            get { return _total; }
            set
            {
                _total = value;
                OnPropertyChanged("Total");
            }
        }

        private OrderStatus _orderStatus;
        public OrderStatus OrderStatus
        {
            get { return _orderStatus; }
            set
            {
                _orderStatus = value;
                OnPropertyChanged("OrderStatus");
            }
        }
    }
}
