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

namespace SaleApplication
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> Products { get; set; }
        

        public static int id = 1;

        public MainWindow()
        {
           InitializeComponent();
            LoadAll(id);
            CountPag(Products);
            
        }

       

        private void LoadAll(int i)
        {
           
                List<Product> prod = App.dbContext.Product.ToList();
                ListProducts.DataContext = prod.Take(i * 20).ToList().Skip((i - 1) * 20);
                Products = prod;
                List<Type_Product> list = new List<Type_Product>();
                list.Add(new Type_Product()
                {
                    Name = "Все типы",
                    Product = App.dbContext.Product.ToList()
                });
                list.AddRange(App.dbContext.Type_Product.ToList());
                Type.ItemsSource = list;
                Sort.ItemsSource = new List<string>() { "По возрастанию", "По убыванию" };
            
        }

        private void Search_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            CheckItAll();
        }

        private void Sort_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CheckItAll();
        }
        private void Type_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CheckItAll();
        }

        private void AddProduct(object sender, RoutedEventArgs e)
        {
            EditOrAddProduct windowAppProd = new EditOrAddProduct();
            if (windowAppProd.ShowDialog() == true)
            {
                Type.SelectedIndex = 0;
                Sort.SelectedIndex = 0;
                Search.Text = "";
                Pagination(1);
                CountPag(Products);
            }

        }

        private void ListProducts_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Product item = ListProducts.SelectedItem as Product;
            if (item != null)
            {
                EditOrAddProduct windowAppProd = new EditOrAddProduct(item);
                if (windowAppProd.ShowDialog() == true)
                {
                    Type.SelectedIndex = 0;
                    Sort.SelectedIndex = 0;
                    Search.Text = "";
                    Pagination(1);
                    CountPag(Products);
                }
            }

        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string content = (sender as Label).Content as string;
            id = int.Parse(content);
            Pagination(id);
        }

        private void Pagination(int id)
        {
            ListProducts.ItemsSource = Products.Take(id * 20).ToList().Skip((id - 1) * 20);
        }
        private void CountPag(List<Product> products)
        {
            if (products.Count() > 20)
                two.Visibility = Visibility.Visible;
            else
                two.Visibility = Visibility.Hidden;
            if (products.Count() > 40)
                three.Visibility = Visibility.Visible;
            else
                three.Visibility = Visibility.Hidden;
            if (products.Count() > 60)
                four.Visibility = Visibility.Visible;
            else
                four.Visibility = Visibility.Hidden;
            if (products.Count() > 80)
                five.Visibility = Visibility.Visible;
            else
                five.Visibility = Visibility.Hidden;
            if (products.Count() > 100)
                six.Visibility = Visibility.Visible;
            else
                six.Visibility = Visibility.Hidden;
            if (products.Count() > 120)
                seven.Visibility = Visibility.Visible;
            else
                seven.Visibility = Visibility.Hidden;
            if (products.Count() > 140)
                eight.Visibility = Visibility.Visible;
            else
                eight.Visibility = Visibility.Hidden;
        }
        private void CheckItAll()
        {
            Products = App.dbContext.Product.ToList();
            if (Sort.SelectedIndex == 0)
            {
                if (Type.SelectedIndex == 0)
                    Products = Products.OrderBy(g => g.Min_cost_from_agent).ToList();
                else
                    Products = Products.OrderBy(g => g.Min_cost_from_agent).Where(w => w.Id_Type_product == Type.SelectedIndex).ToList();
                ListProducts.ItemsSource = Products.ToList();
            }
            if (Sort.SelectedIndex == 1)
            {
                if (Type.SelectedIndex == 0)
                    Products = Products.OrderByDescending(g => g.Min_cost_from_agent).ToList();
                else
                    Products = Products.OrderByDescending(g => g.Min_cost_from_agent).Where(w => w.Id_Type_product == Type.SelectedIndex).ToList();
                ListProducts.ItemsSource = Products.ToList();
            }
            if (Search.Text != "")
            {
                Products = Products.Where(w => w.Name.Contains(Search.Text)).ToList();
                ListProducts.ItemsSource = Products.ToList();
            }
            CountPag(Products);
            Pagination(id);
        }

        private void Image_Initialized(object sender, EventArgs e)
        {
            //Image image = sender as Image;
            //Product product = (sender as Image).DataContext as Product;
            //ImageSourceConverter imageSourceConverter = new ImageSourceConverter();
            //if (product.Image != null)
            //{
            //    string imgPath = product.Image;
            //    Uri imgUri = new Uri(imgPath);
            //    ImageSource img = new BitmapImage(imgUri);
            //    image.Source = img;
            //}
        }
    }
}
