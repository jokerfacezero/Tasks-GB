using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Count2
    {
        
        public void Checking (int num)
        {
            if (num%2 == 0 && num != 0)
            {
                Console.WriteLine("Число четное");
            }
            else if (num == 0)
            {
                Console.WriteLine("Вы ввели ноль");
            }
            else
            {
                Console.WriteLine("Число нечетное");
            }
        }
    }
}
