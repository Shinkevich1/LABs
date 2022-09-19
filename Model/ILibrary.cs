using System;
 
namespace Model
{
    /// <summary>
    /// Абстрактный класс - система библиотечных карточек для разных изданий
    /// </summary>
    public abstract class ILibrary
    {
        /// <summary>Сведения об авторе</summary>
        public string Fio { set; get; }

        /// <summary>Сведения о названии источника</summary>
        public string Name { set; get; }

        /// <summary>Год издания</summary>
        public int Year { set; get; }

        /// <summary>Конструктор абстрактного класса ILibrary</summary>
        /// <param name="fio">ФИО автора</param>
        /// <param name="name">Название источника</param>
        /// <param name="year">Год издания</param>
        public ILibrary(string fio, string name, int year)
        {
            int cnt = 0;
            for (int i = 0; i < fio.Length; i++)
                if (fio[i] == ' ')
                    cnt++;
            if (cnt != 2)
                throw new ArgumentOutOfRangeException("Неверное имя автора");
            else
                Fio = fio;

            if (name.Length == 0)
                throw new ArgumentOutOfRangeException("Неверное название");
            else
                Name = name;

            if (year < 0 || year > 2021)
                throw new ArgumentOutOfRangeException("Неверный год издания");
            else
                Year = year;
        }

        /// <summary>Информацияо об издании в виде строки, оформленной по ГОСТу</summary>
        /// <returns>Возвращает строку с информацией</returns>
        public abstract string Information();

        protected string Author(bool i)
        {
            string[] words = Fio.Split(new char[] { ' ' });
            return (i ? (words[0] + ", " + words[1][0] + "." + words[2][0] + ".") : 
                        (words[1][0] + "." + words[2][0] + ". " + words[0]));
        }
    }
}
