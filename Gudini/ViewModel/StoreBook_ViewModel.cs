using System.Collections.ObjectModel;
using System.ComponentModel;
using BuckApp.Model;
using System.Windows.Data;
using System.Linq;
using System.Text.RegularExpressions;

namespace BuckApp.ViewModel
{
    public class StoreBook_ViewModel : INotifyPropertyChanged
    {
        private User_Book _selectedItem;
        private string _filtertext;
        private ICollectionView _collectionView;
        public User_Book SelectedItem
        {
            get { return _selectedItem; }
            set { _selectedItem = value; OnPropertyChanged("SelectedItem"); }
        }

        public ObservableCollection<User_Book> UserBook { get; set; } = new ObservableCollection<User_Book>();

        public event PropertyChangedEventHandler PropertyChanged;


        public string FilterText
        {
            get { return _filtertext; }
            set
            {
                if (value != null)
                {
                    _filtertext = value;
                    _collectionView.Refresh(); 
                    OnPropertyChanged("FilterText");
                }

            }
        }


        /// <summary>
        /// определение объектов с модели к UserBook свойству(необходимо переделать)
        /// </summary>
        public StoreBook_ViewModel()
        {
            Pages.Login.user.Id = 2;
            foreach (var item in MainWindow.model.User_Book.ToList().Where(c=> c.User.Id == Pages.Login.user.Id))
            {
               
                UserBook.Add(item);
            }

            _collectionView = CollectionViewSource.GetDefaultView(UserBook);
            _collectionView.Filter = Filter;
        }

        private bool Filter(object obj)
        {
            User_Book User_Book = (User_Book)obj;
            if (string.IsNullOrWhiteSpace(FilterText))
            {
                return true;
            }
            else if(User_Book.Book.Name.Contains(FilterText))
            {
                return true;
            }
            else if(User_Book.Book.Author.LName.Contains(FilterText))
            {
                return true;
            }
            else if (User_Book.Book.Genre.Name.Contains(FilterText)) 
                
            {
                return true;
            }
            return false;
        }

        public void OnPropertyChanged(string propertyname = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
    }
}
