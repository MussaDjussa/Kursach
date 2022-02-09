﻿using BuckApp.Model;
using BuckApp.Pages;
using System.Windows;

namespace BuckApp
{
    public partial class MainWindow : Window
    {
        /// <summary>
        /// модель, через которую идёт обращение к БД
        /// </summary>
        public static BuckDBEntities model = new BuckDBEntities();

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
        /// Инициализация навигацинного стека для страниц
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            frame_navigation.Content = startUp;
        }
    }
}
