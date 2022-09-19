using System; 

using Model;

namespace ConsoleLoader
{
    class Program
    {
        static void Main(string[] args)
        {
            ILibrary L;

            int switch_on = 0;

            Console.WriteLine("Выбор для формирования информации об издании"
                + "\n\t1: Книга"
                + "\n\t2: Журнал"
                + "\n\t3: Сборник"
                + "\n\t4: Диссертация"
                + "\n\t5: Выход из программы");

            while (switch_on != 5)
            {
                try
                {
                    Console.Write("Выбор: ");
                    switch_on = Convert.ToInt32(Console.ReadLine());
                    if (switch_on == 5)
                        continue;

                    Console.WriteLine("Введите информацию:");
                    Console.Write("\tФамилия, имя, отчество автора (разделяя пробелами): "); string fio = Console.ReadLine();
                    Console.Write("\tНазвание источника: "); string name = Console.ReadLine();
                    Console.Write("\tГод издания: "); int year = Convert.ToInt32(Console.ReadLine());

                    switch (switch_on)
                    {
                        case 1: //Книга
                            Console.Write("\tНазвние издательства: "); string publisher = Console.ReadLine();
                            Console.Write("\tГород издания: "); string city = Console.ReadLine();
                            Console.Write("\tКоличество страниц: "); int pages = Convert.ToInt32(Console.ReadLine());
                            L = new Book(fio, name, year, publisher, city, pages);
                            break;
                        case 2: //Журнал
                            Console.Write("\tНазвние журнала: "); string mameMag = Console.ReadLine();
                            Console.Write("\tНомер журнала: "); int number = Convert.ToInt32(Console.ReadLine());
                            L = new Magazine(fio, name, year, mameMag, number);
                            break;
                        case 3: //Сборник
                            Console.Write("\tНазвние сборника: "); string nameCol = Console.ReadLine();
                            Console.Write("\tГород издания: "); string cityC = Console.ReadLine();
                            L = new Collection(fio, name, year, nameCol, cityC);
                            break;
                        case 4: //Диссертация
                            Console.Write("\tУченая степень автора (напр.: канд. техн. наук): "); string rank = Console.ReadLine();
                            Console.Write("\tГород издания: "); string cityT = Console.ReadLine();
                            Console.Write("\tКоличество страниц: "); int pagesT = Convert.ToInt32(Console.ReadLine());
                            L = new Thesis(fio, name, year, rank, cityT, pagesT);
                            break;
                        default:
                            throw new ArgumentException("Неверный пункт меню");
                    }
                    Console.WriteLine(L.Information());
                    L = null;
                }
                catch (Exception exp)
                {
                    Console.WriteLine("Ошибка: " + exp.Message);
                }
            }
            
            Console.ReadLine();
        }
    }
}
