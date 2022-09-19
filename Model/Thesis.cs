using System;
 
namespace Model
{
    /// <summary>
    /// Класс для диссертаций
    /// </summary>
    public class Thesis : ILibrary
    {
        /// <summary>Ученая степень</summary>
        public string Rank { set; get; }

        /// <summary>Сведения о городе издания</summary>
        public string City { set; get; }

        /// <summary>Количество страниц</summary>
        public int Pages { set; get; }

        /// <summary>Конструктор с параметрами класса Thesis</summary>
        /// <param name="fio">Имя автора диссертации</param>
        /// <param name="name">Назвние диссертации</param>
        /// <param name="year">Год издания</param>
        /// <param name="rank">Ученая степень автора</param>
        /// <param name="city">Город издания</param>
        /// <param name="pages">Количество страниц</param>
        public Thesis(string fio, string name, int year, string rank, string city, int pages) : base(fio, name, year)
        {
            int cnt1 = 0, cnt2 = 0;
            for (int i = 0; i < rank.Length; i++)
            {
                if (rank[i] == ' ')
                    cnt1++;
                if (rank[i] == '.')
                    cnt2++;
            }
            if (cnt1 != 2 || cnt2 != 2)
                throw new ArgumentOutOfRangeException("Неверная ученая степень автора");
            else
                Rank = rank;

            if (city.Length == 0)
                throw new ArgumentOutOfRangeException("Неверный город");
            else
                City = city;

            if (pages <= 0)
                throw new ArgumentOutOfRangeException("Неверное количество страниц");
            else
                Pages = pages;
        }

        public override string Information()
        {
            return $"{Author(true)} {Name} [Текст]: дис....{Rank} / {Fio}. {City}, {Year}. – {Pages} с.";
        }
    }
}
