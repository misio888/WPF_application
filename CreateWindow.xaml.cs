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
    /// Interaction logic for CreateWindow.xaml
    /// </summary>
    public partial class CreateWindow : Window
    {
        private readonly IOrderRepository _orderRepository = new OrderRepository();
        public CreateWindow()
        {
            InitializeComponent();
        }

        private string? _imagePath;
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
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
                imgPhoto.Source = image;

            }
        }
            private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            Order order = new Order();  
            order.Name = txtName.Text;
            order.Count = txtCountry.Text;
            order.Price = txtDescription.Text;
            order.Image = new byte[0];
            if (order.Image != null)
            {
                FileStream fileStream = File.Open(_imagePath, FileMode.Open);
                order.Image = Utility.ImageToByteArray(fileStream); 
            }
            if (_orderRepository.Create(order) == false)
            {
                MessageBox.Show("Błąd dodania elementu do bazy", "Error", MessageBoxButton.OK);
            }

        }
    }
}
