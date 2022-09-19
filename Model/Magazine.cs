using System;
 
namespace Model
{
    /// <summary>
    /// Класс для журналов
    /// </summary>
    public class Magazine : ILibrary
    {
        /// <summary>Сведения о названии журнала</summary>
        public string NameMag { set; get; }

        /// <summary>Номер выпуска журнала</summary>
        public int Number { set; get; }

        /// <summary>Конструктор с параметрами класса Magazine</summary>
        /// <param name="fio">Автор журнала</param>
        /// <param name="name">Название статьи</param>
        /// <param name="year">Год издания</param>
        /// <param name="mameMag">Название журнала</param>
        /// <param name="number">Номер журнала</param>
        public Magazine(string fio, string name, int year, string mameMag, int number) : base(fio, name, year)
        {
            if (mameMag.Length == 0)
                throw new ArgumentOutOfRangeException("Неверное название журнала");
            else
                NameMag = mameMag;

            if (number < 0)
                throw new ArgumentOutOfRangeException("Неверный номер журнала");
            else
                Number = number;
        }

        public override string Information()
        {
            return $"{Author(true)} {Name} [Текст] / {Author(false)} // {NameMag}. – {Year}. – №{Number}.";
        }
    }
}
