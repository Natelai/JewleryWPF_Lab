using SampleMVVM.ViewModels;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;

namespace JewleryWPF_Lab.ViewModels
{
    public class DataViewModel : ViewModelBase
    {
        public DataViewModel()
        {
            SetControlVisibility = new Command(ControlVisibility);
            CancelOrderCommand = new Command(CancelOrder);
        }

        private string _visibleControl = "Orders";

        public string VisibleControl
        {
            get { return _visibleControl; }
            set
            {
                _visibleControl = value;
                OnPropertyChanged("VisibleControl");
            }
        }

        public ICommand SetControlVisibility { get; set; }
        public void ControlVisibility(object args)
        {
            VisibleControl = args.ToString();
        }

        public ICommand CancelOrderCommand { get; set; }

        public void CancelOrder(object args)
        {
            SelectedOrder.OrderStatus = Jewlery.Models.OrderStatus.Cancelled;
        }

        private OrderViewModel _selectedOrder;

        public OrderViewModel SelectedOrder
        {
            get { return _selectedOrder; }
            set
            {
                _selectedOrder = value;
                OnPropertyChanged("SelectedOrder");
            }
        }
        private ObservableCollection<OrderViewModel> _orders;
        public ObservableCollection<OrderViewModel> Orders
        {
            get { return _orders; }
            set {
                _orders = value;
                OnPropertyChanged("Orders");
            }
        }

        private ObservableCollection<CustomerViewModel> _customers;
        public ObservableCollection<CustomerViewModel> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;
                OnPropertyChanged("Customers");
            }
        }

        private ObservableCollection<MaterialViewModel> _materials;
        public ObservableCollection<MaterialViewModel> Materials
        {
            get { return _materials; }
            set
            {
                _materials = value;
                OnPropertyChanged("Materials");
            }
        }

        private ObservableCollection<GoodViewModel> _goods;
        public ObservableCollection<GoodViewModel> Goods
        {
            get { return _goods; }
            set
            {
                _goods = value;
                OnPropertyChanged("Goods");
            }
        }
    }
}
