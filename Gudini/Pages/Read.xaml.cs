using System.Windows;
using System.Windows.Controls;
namespace BuckApp.Pages
{
    /// <summary>
    /// Interaction logic for Read.xaml
    /// </summary>
    public partial class Read : Page
    {
        public Read()
        {
            InitializeComponent();
            DataContext = MainWindow.book.ViewModel.SelectedItem;
        }
    }
}
