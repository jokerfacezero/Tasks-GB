using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class ReverseString
    {
        string hello = "hello";
        public void ReverseWords() { 
        Console.WriteLine(hello);
            for (int i = hello.Length; i > 0; i--)
            {
                char nowChar = hello[i - 1];
                Console.Write(nowChar);
            }
        }

        publ
}
}
