using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    /// <summary>
    /// Одна штука некоторого товара стоит 20,4 руб. Напечатать таблицу стоимости 2, 3, ..., 20 штук этого товара.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Func();
            Console.ReadLine();
        }
        public static void Func()
        {
            double x = 20.4;
            int a = 2;
            int b = 0;
            while (b < 19)
            {
                Console.WriteLine($"{a} товара стоят {x*a}");
                a++;
                b++;
            }
        }
    }
}
