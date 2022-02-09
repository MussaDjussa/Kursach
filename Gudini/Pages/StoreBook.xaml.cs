using BuckApp.ViewModel;
using System.Windows.Controls;

namespace BuckApp.Pages
{
    /// <summary>
    /// Interaction logic for StoreBook.xaml
    /// </summary>
    public partial class StoreBook : Page
    {
        public StoreBook()
        {
            InitializeComponent();
            DataContext = new StoreBook_ViewModel();
        }
    }
}
