using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            # region Temperature
            //Вывести среднюю температуру за день. Запросить у пользователя минимальную и максимальную.
            TemperatureClass temperature = new TemperatureClass();

                temperature.Question();
                temperature.MidTemp();
                temperature.OnScreen();
                double check = temperature.ToMouthes();
                Console.Clear();
            #endregion

            #region Проверка четности числа
            //Проверка четности числа, заданное пользователем. 
            Console.WriteLine("Введите число, скажу четное ли оно?");
                int GuestNum = int.Parse(Console.ReadLine());

                Count2 count2 = new Count2();
                count2.Checking(GuestNum);

                Console.ReadLine();
                Console.Clear();
            #endregion

            #region Запросить у пользователя порядковый номер текущего месяца и вывести его название.
            //(*) Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести сообщение «Дождливая зима».

            Mouthes mouthes = new Mouthes();
            mouthes.SwitchCase(check);
                Console.ReadLine();
            #endregion

            #region "Нарисовать чек"
            //Для полного закрепления понимания простых типов найдите любой чек,
            //либо фотографию этого чека в интернете и схематично нарисуйте его в консоли,
            //только за место динамических, по вашему мнению, данных (это может быть дата,
            //название магазина, сумма покупок) подставляйте переменные, которые
            //были заранее заготовлены до вывода на консоль.
            int sumBrek = 8801;
            int sumStone = 5400;
            Console.WriteLine($"        OOO'SuperCheck'           \n" +
                $"          Чек №4542           \n" +
                $"1.Кирпич пустотелый М-150800 Х 10.22\n" +
                $"  Стоймость ............{sumBrek}\n" +
                $"2.Щебень фракция 20 Х 40т. \n" +
                $"  Стоймость ............{sumStone}\n" +
                $"Всего ..................{sumBrek + sumStone}\n");

            Console.ReadLine();

            #endregion 

        }
    }
}
