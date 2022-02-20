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
using System.Windows.Shapes;
using Microsoft.Win32;
using System.Text.RegularExpressions;
using System.Collections.ObjectModel;

namespace SaleApplication
{
    /// <summary>
    /// Логика взаимодействия для EditOrAddProduct.xaml
    /// </summary>
    public partial class EditOrAddProduct : Window
    {
        public Product Product;
        public ObservableCollection<Production> Productions { get; set; }
        public bool IsEdit { get; set; }
        public List<Material> Materials { get; set; }

        Regex regex = new Regex("[^0-9]+");

        public EditOrAddProduct()
        {
            InitializeComponent();
            LoadAll();
        }
        public EditOrAddProduct(Product prod)
        {
            InitializeComponent();
            LoadInfoAboutProd(prod);
        }
        private void AddImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Image File (*.jpeg;*.jpg;*.bmp;*.png)|*.jpeg; *.jpg;*.bmp;*.png",
                Multiselect = false
            };
            if (openFileDialog.ShowDialog() == true)
                ImageProduct.Source = new BitmapImage(new Uri(openFileDialog.FileName, UriKind.Absolute));

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
           
            TypeProduct typeProdutct = type.SelectedItem as TypeProduct;
            if (typeProdutct == null || name.Text == "" || article.Text == "" || price.Text == "")
            {
                MessageBox.Show("Проверьте заполненность данных");
                return;
            }
            if (App.dbContext.Product.Where(x => x.Article == article.Text).FirstOrDefault() != null && !IsEdit)
            {
                MessageBox.Show("Продукт с таким артиклом существует");
                return;
            }
            Product.Name = name.Text;
            Product.Min_cost_from_agent = Convert.ToInt32(price.Text);
            Product.Count_Person = Convert.ToInt32(countPeople.Text);
            Product.Article = article.Text;
            Product.Number_WorkShop = (guild.SelectedItem as Product).Number_WorkShop;
            Product.Id_Type_product = typeProdutct.id;
            Product.Production.Clear();
            Product.Production = Productions.Where(x => x.Material != null).ToList();
            if (ImageProduct.Source == (BitmapImage)TryFindResource("DefoltImage"))
                Product.Image = null;
            else
                Product.Image = ImageProduct.Source.ToString();
            if (!IsEdit)
                App.dbContext.Product.Add(Product);
            App.dbContext.SaveChanges();
            DialogResult = true;
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var delete = MessageBox.Show("Вы действительно хотите удалить продукт?", "Предупреждение", MessageBoxButton.YesNo);
            if (delete == MessageBoxResult.Yes)
            {
                App.dbContext.Product.Remove(Product);
                App.dbContext.SaveChanges();
                DialogResult = true;
            }
        }
        private void Article_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Price_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = regex.IsMatch(e.Text);
        }
        private void DeleteProduction_Click(object sender, RoutedEventArgs e)
        {
            Production material = (sender as Button).DataContext as Production;
            Productions.Remove(material);
            ListMaterials.ItemsSource = Productions;
            ListMaterials.UpdateLayout();
        }
        private void LoadAll()
        {
            title.Text = "Добавление";
            Materials = App.dbContext.Material.ToList();
            type.ItemsSource = App.dbContext.Type_Product.ToList();
            guild.ItemsSource = App.dbContext.Product.ToList().Select(c=> c.Number_WorkShop);
            BoxColumn.ItemsSource = Materials;
            Productions = new ObservableCollection<Production>();
            Product = new Product();
            ListMaterials.ItemsSource = Productions;
            IsEdit = false;
        }
        private void LoadInfoAboutProd(Product prod)
        {
            LoadAll();
            IsEdit = true;
            title.Text = "Редактирование";
            Product = prod;
            article.Text = prod.Article;
            name.Text = prod.Name;
            type.SelectedItem = prod.Id_Type_product;
            guild.SelectedItem = prod.Number_WorkShop;
            Productions = new ObservableCollection<Production>(Product.Production);
            ListMaterials.ItemsSource = Productions;
            countPeople.Text = prod.Count_Person.ToString();
            price.Text = prod.Min_cost_from_agent.ToString();
            if (prod.Image == null || prod.Image == " ")
                ImageProduct.Source = (BitmapImage)TryFindResource("DefoltImage");
            else
                ImageProduct.Source = new BitmapImage(new Uri(prod.Image, UriKind.RelativeOrAbsolute));
        }
    }
}
