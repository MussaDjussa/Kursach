using System.Collections.ObjectModel;
using System.ComponentModel;
using BuckApp.Model;
using System.Linq;

namespace BuckApp.ViewModel
{
    internal class StoreBook_ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyname = null)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }

        public ObservableCollection<User_Book> UserBook { get; set; } = new ObservableCollection<User_Book>();

        public StoreBook_ViewModel()
        {
            foreach(var item in MainWindow.model.User_Book.ToList())
            {
                UserBook.Add(item);
            }
        }
        


    }
}
