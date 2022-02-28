using System.Windows;
using BuckApp.Model;
using BuckApp.ViewModel;
using BuckApp.Pages;
using System.Linq;
using System.Text;
using System.Windows.Documents;
using System.Windows.Media;

namespace BuckApp.Windows
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            DataContext = MainWindow.book.ViewModel.SelectedItem;
            
        }


        Paragraph _paragraph = new Paragraph();
        public FlowDocument AddDocument(byte[] textbook)
        {
            _paragraph.Inlines.Clear();
            string s = Encoding.UTF8.GetString(textbook.ToArray());
            _paragraph.Inlines.Add(s);
            FlowDocument document = new FlowDocument(_paragraph);
            document.ColumnWidth = 2000;
            document.Background = Brushes.White;
            return document;
        }
    }
}
