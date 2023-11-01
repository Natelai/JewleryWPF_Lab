using SampleMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JewleryWPF_Lab.ViewModels
{
    public class CustomerViewModel : ViewModelBase
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        private string _category;
        public string Category {
            get { return _category; }
            set
            {
                _category = value;
                OnPropertyChanged("Category");
            }
        }

        private double _discount;
        public double Discount
        {
            get { return _discount; }
            set
            {
                _discount = value;
                OnPropertyChanged("Discount");
            }
        }
    }
}
