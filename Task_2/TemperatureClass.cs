using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class TemperatureClass
    {
        double mid;
        double max;
        double min;
        public void Question()
        {
            Console.WriteLine("Min Temp?");
            min = double.Parse(Console.ReadLine());

            Console.WriteLine("Max Temp?");
            max = double.Parse(Console.ReadLine());
        }
        public void MidTemp ()
            {
             mid  = (max + min) / 2;
            }
        public void OnScreen ()
        {
            Console.WriteLine (mid);
            Console.ReadLine();
        }
        public double ToMouthes ()
        {
            return mid;
        }
    }
}
