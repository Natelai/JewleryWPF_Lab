using Jewlery.Models;
using JewleryWPF_Lab.ViewModels;
using System.Threading.Tasks;
using System.Windows;

namespace JewleryWPF_Lab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           // var order = (OrderViewModel)dataGridTasks.SelectedItem;
           // order.OrderStatus = OrderStatus.Cancelled;
        }
    }
}
