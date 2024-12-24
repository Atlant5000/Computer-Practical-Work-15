using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    /// <summary>
    /// Напечатать ряд чисел 20 в виде: 20 20 20 20 20 20 20 20 20 20.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Func();
            Console.ReadKey();
        }
        public static void Func()
        {
            int x = 0;
            while (x < 11) 
            {
                Console.Write(" 20");
                x++;
            }
        }
    }
}
