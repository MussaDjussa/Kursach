using System.Linq;
using System.Windows;

namespace BuckApp.Windows
{
    /// <summary>
    /// Interaction logic for AddAuthor.xaml
    /// </summary>
    public partial class AddAuthor : Window
    {
        public AddAuthor()
        {
            InitializeComponent();
            author.ItemsSource = MainWindow.model.Author.ToList();
        }
    }
}
