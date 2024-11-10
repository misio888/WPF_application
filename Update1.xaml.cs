using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp1.Model;
using WpfApp1.Repositories;

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private readonly IOrderRepository _orderRepository = new OrderRepository();
        List<Order> listPlace = new List<Order>();
        private string? _imagePath;

        public Window1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void BtnUploadPhoto_Click(object sender, RoutedEventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "Image files(.jpg)|.jpg; *.png";
            if (openFileDialog.ShowDialog() == true)
            {
                _imagePath = openFileDialog.FileName;
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = new Uri(_imagePath);
                image.EndInit();

            }
        }
        private void BtnSave_Click1(object sender, RoutedEventArgs e)
        {
            {

                Order order = new Order();
                order.Name = txtName.Text;
                order.Count = txtCountry.Text;
                order.Price = txtDescription.Text;
                order.Image = new byte[0];
                if (order.Image != null)
                {
                    //_imagePath = "car1.jpg"; //Domyślny Obrazek Mercedesa
                    FileStream fileStream = File.Open(_imagePath, FileMode.Open);
                    order.Image = Utility.ImageToByteArray(fileStream);
                }
                else {
                        MessageBox.Show("Wprowadz wszystkie dane !", "Blad", MessageBoxButton.OK);
                }
                if (_orderRepository.Update(order))
                {
                    this.Close();
                }

            }
        }
    }
}
