using BuckApp.Pages;
using System.Windows;

namespace BuckApp
{
    public partial class MainWindow : Window
    {

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
        /// Инициализация навигацинного стека для страниц
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            frame_navigation.Content = startUp;
        }
    }
}
