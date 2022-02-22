using System.Linq;
using System.Windows;

namespace BuckApp.Windows
{
    /// <summary>
    /// Interaction logic for AddGenre.xaml
    /// </summary>
    public partial class AddGenre : Window
    {
        public AddGenre()
        {
            InitializeComponent();
            oldgenre.ItemsSource = MainWindow.model.Genre.ToList();
        }
    }
}
