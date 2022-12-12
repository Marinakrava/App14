using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace App14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProdName = "Манго",
                ProdPrice = 367,
                ProdImage = "Data/mango.jpg",
                ProductCategories = ProductCategories.Food
            });

            products.Add(new Product()
            {
                ProdName = "Яблоки",
                ProdPrice = 128,
                ProdImage = "Data/apples.jpg",
                ProductCategories = ProductCategories.Food
            });

            products.Add(new Product()
            {
                ProdName = "Оливковое масло",
                ProdPrice = 659,
                ProdImage = "Data/oil.jpg",
                ProductCategories = ProductCategories.Food
            });

            products.Add(new Product()
            {
                ProdName = "Стайлер Dyson",
                ProdPrice = 47700,
                ProdImage = "Data/dyson.jpg",
                ProductCategories = ProductCategories.Appliances
            });

            products.Add(new Product()
            {
                ProdName = "Iphone 14 Pro",
                ProdPrice = 109900,
                ProdImage = "Data/iphone.png",
                ProductCategories = ProductCategories.Appliances
            });

            products.Add(new Product()
            {
                ProdName = "Стиральная машинка",
                ProdPrice = 29800,
                ProdImage = "Data/washing.jpg",
                ProductCategories = ProductCategories.Appliances
            });
            listBox.ItemsSource = products;
        }
    }
}
