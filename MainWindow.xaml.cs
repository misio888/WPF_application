using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Repositories;
using WpfApp1.Model;
using System.IO;
using System.Data.Common;
using Microsoft.Win32;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IOrderRepository _orderRepository = new OrderRepository();
        List<Order> listPlace = new List<Order>();
        private string? _imagePath;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            CreateWindow createWindow = new CreateWindow();
            this.Hide();
            createWindow.ShowDialog();
            this.Show();
        }

        private void cmbListView_DropDownOpened(object sender, EventArgs e)
        {
            listPlace = _orderRepository.ReadAll();
            cmbListView.ItemsSource = listPlace.Select(n  => n.Name);

        }

        private void cmbListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtName.Text = listPlace[cmbListView.SelectedIndex].Name;
            txtCountry.Text = listPlace[cmbListView.SelectedIndex].Count;
            txtDescription.Text = listPlace[cmbListView.SelectedIndex].Price;
#pragma warning disable CS8604 // Możliwy argument odwołania o wartości null.
            imgPhoto.Source = Utility.ByteArrayToBitmapImage(listPlace[cmbListView.SelectedIndex].Image);
#pragma warning restore CS8604 // Możliwy argument odwołania o wartości null.
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (_orderRepository.Delete(listPlace[cmbListView.SelectedIndex]) == true)
            {
                if (cmbListView.SelectedIndex != 0)
                {
                    cmbListView.SelectedIndex = 0;
                }

            }
        }
        private void BtnSave_Click1(object sender, RoutedEventArgs e)
        {
            {
                Window1 update = new Window1();
                update.ShowDialog();
            }
        }
    }
}