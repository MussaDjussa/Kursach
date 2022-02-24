using BuckApp.Model;

namespace BuckApp.Container
{
    public class GenreContainter
    {
        /// <summary>
        /// Запись жанра из поля
        /// </summary>
        public string NameGenre { get; set; } = string.Empty;


        /// <summary>
        /// Выбор Жанра из ComboBox
        /// </summary>
        public Genre SelectedItemGenre { get; set; } = null;

        /// <summary>
        /// Проверка на пустое поле
        /// </summary>
        /// <returns>true - пусто</returns>
        public bool EmptyFields()
        {
            if(string.IsNullOrWhiteSpace(NameGenre))
            {
                return true;
            }
            return false;
        }
    }
}
