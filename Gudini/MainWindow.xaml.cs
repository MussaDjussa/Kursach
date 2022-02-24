using BuckApp.Container;
using BuckApp.Model;
using BuckApp.Pages;
using BuckApp.ViewModel;
using BuckApp.Windows;
using System.Windows;

namespace BuckApp
{
    public partial class MainWindow : Window
    {
        /// <summary>
        /// модель, через которую идёт обращение к БД
        /// </summary>
        public static BookDBEntities model = new BookDBEntities();

        /// <summary>
        /// создание стартовой страницы в началае навигационного стека
        /// </summary>
        public static StartUp startUp = new StartUp();

        /// <summary>
        /// создание страницы с регистрацией
        /// </summary>
        public static Registration registration = new Registration();

        //создание страницы с логином
        /// <summary>
        /// создание страницы с авторацией
        /// </summary>
        public static Login login = new Login();

        /// <summary>
        /// создание страницы с книгами
        /// </summary>
        public static StoreBook book = new StoreBook();

        /// <summary>
        /// создание окна с контентом книги
        /// </summary>
        public static Window1 window1 = new Window1();

        /// <summary>
        /// создание окна Добавление автора
        /// </summary>
        public static AddAuthor addAuthor = new AddAuthor();

        /// <summary>
        /// создание окна Добавление книги
        /// </summary>
        public static AddWindow addWindow = new AddWindow();

        /// <summary>
        /// создание окна Добавление Жанра
        /// </summary>
        public static AddGenre addGenre = new AddGenre();
        

        /// <summary>
        /// создание контейнера для хранения жанра
        /// </summary>
        public static GenreContainter genreContainer = new GenreContainter();


        /// <summary>
        /// создание контейнера для хранения автора
        /// </summary>
        public static AuthorContainer authorContainer = new AuthorContainer();

        /// <summary>
        /// создание DataGrid Admin Panel
        /// </summary>
        public static DataGridAdminPanel dataGridAdminPanel = new DataGridAdminPanel();

        /// <summary>
        /// создание окна для изменения данных книг
        /// </summary>
        public static EditWindow editWindow = new EditWindow();

        /// <summary>
        /// Инициализация навигацинного стека для страниц
        /// </summary>
        /// 
        public MainWindow()
        {
            InitializeComponent();
            frame_navigation.Content = startUp;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            frame_navigation.Navigate(MainWindow.startUp);
        }
    }
}
