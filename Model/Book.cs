using System;
 
namespace Model
{
    /// <summary>
    /// Класс для книг
    /// </summary>
    public class Book : ILibrary
    {
        /// <summary>Сведения об издательстве</summary>
        public string Publisher { set; get; }

        /// <summary>Сведения о городе издания</summary>
        public string City { set; get; }

        /// <summary>Количество страниц</summary>
        public int Pages { set; get; }

        /// <summary>Конструктор с параметрами класса Book</summary>
        /// <param name="fio">Имя автора</param>
        /// <param name="name">Название книги</param>
        /// <param name="year">Год издания книги</param>
        /// <param name="publisher">Издательство</param>
        /// <param name="city">Город издания</param>
        /// <param name="pages">Количество страниц</param>
        public Book(string fio, string name, int year, string publisher, string city, int pages) : base(fio, name, year)
        {
            if (publisher.Length == 0)
                throw new ArgumentOutOfRangeException("Неверное издательство");
            else
                Publisher = publisher;

            if (city.Length == 0)
                throw new ArgumentOutOfRangeException("Неверный город");
            else
                City = city;

            if (pages < 0)
                throw new ArgumentOutOfRangeException("Неверное количество страниц");
            else
                Pages = pages;
        }

        public override string Information()
        {
            return $"{Author(true)} {Name} [Текст] / {Author(false)}. – {City}: {Publisher}, {Year}. – {Pages} c.";
        }
    }
}
