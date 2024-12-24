using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    /// <summary>
    /// Генерируются 15 случайных целых чисел в интервале (-20, 30). Вывести эти числа и подсчитать количество положительных чисел.
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
            int b = 0;
            Random number= new Random();
            for (int x = 0; x < 15; x++)
            {
                int a = number.Next(-20, 30);
                Console.WriteLine(a);
                if (a > 0) 
                {
                   b++;
                }
            }
            Console.WriteLine($"Количество положительных чисел={b}");
        }
    }
}
