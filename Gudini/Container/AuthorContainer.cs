using BuckApp.Model;

namespace BuckApp.Container
{
    public class AuthorContainer
    {
        /// <summary>
        /// Имя автора
        /// </summary>
        public string FName { get; set; } = string.Empty;
        /// <summary>
        /// Фамилия автора
        /// </summary>
        public string LName { get; set; } = string.Empty;
        /// <summary>
        /// Отчество автора
        /// </summary>
        public string MName { get; set; } = string.Empty;


        /// <summary>
        /// Выбор Жанра из ComboBox
        /// </summary>
        public Author SelectedItemAuthor { get; set; } = null;

        /// <summary>
        /// Проверка на пустые поля
        /// </summary>
        /// <returns>true - пусто</returns>
        public bool EmptyFields()
        {
            if(string.IsNullOrWhiteSpace(FName) || string.IsNullOrWhiteSpace(LName) || string.IsNullOrWhiteSpace(MName))
            {
                return true;
            }
            return false;
        }
    }
}
