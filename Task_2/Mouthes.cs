using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Mouthes
    {
        public void SwitchCase(double i)
        {
            Console.WriteLine("Введите порядковый номер месяца");
            int mounth = int.Parse(Console.ReadLine());
            TemperatureClass temperatureClass = new TemperatureClass();


            switch (mounth)
            {
                case 1:
                    Console.WriteLine("January");

                    if (i > 0)
                    {
                        Console.WriteLine("Дождливая зима");
                    }
                    break;
                case 2:
                    Console.WriteLine("February");
                    if (i > 0)
                    {
                        Console.WriteLine("Дождливая зима");
                    }
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    if (i > 0)
                    {
                        Console.WriteLine("Дождливая зима");
                    }
                    break;
            }
            Console.ReadLine();
        }
    }
}
