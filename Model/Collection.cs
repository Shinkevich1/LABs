using System;
 
namespace Model
{
    /// <summary>
    /// Класс для сборников
    /// </summary>
    public class Collection : ILibrary
    {
        /// <summary>Сведения о названии сборника</summary>
        public string NameCol { set; get; }

        /// <summary>Сведения о городе издания</summary>
        public string City { set; get; }

        /// <summary>Конструктор с параметрами класса Collection</summary>
        /// <param name="fio">Автор сборника</param>
        /// <param name="name">Название статьи</param>
        /// <param name="year">Год издания</param>
        /// <param name="nameCol">Название сборника</param>
        /// <param name="city">Город издания</param>
        public Collection(string fio, string name, int year, string nameCol, string city) : base(fio, name, year)
        {
            if (nameCol.Length == 0)
                throw new ArgumentOutOfRangeException("Неверное название сборника");
            else
                NameCol = nameCol;

            if (city.Length == 0)
                throw new ArgumentOutOfRangeException("Неверный город");
            else
                City = city;
        }

        public override string Information()
        {
            return $"{Author(true)} {Name} [Текст] / {Author(false)} // {NameCol}: сб. статей. – {City}, {Year}.";
        }
    }
}
