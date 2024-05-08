using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice__3_th__ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число на чётность: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Это чётное число");
            }
            else
            {
                Console.WriteLine("Это нечётное число");
                Console.ReadKey();
            }
        }
    }
}
