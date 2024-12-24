using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    /// <summary>
    /// Вывести четные двузначные числа и подсчитать их количество.
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
            int a = 0;
            for(int i=10;i<=99;i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);a++;
                }
            }
            Console.WriteLine($"a={a}");
        }
    }
}
