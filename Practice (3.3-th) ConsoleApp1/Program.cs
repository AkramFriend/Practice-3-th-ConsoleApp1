using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice__3._3_th__ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Длина последовательности: ");
            int count = int.Parse(Console.ReadLine());
            int minValue = int.MaxValue;

            for (int i = 0; i < count; i++) 
            {
                Console.WriteLine("Введите число");
                int userValue = int.Parse(Console.ReadLine());
                if (userValue < minValue)
                {
                    minValue = userValue;
                }          
            }
            Console.WriteLine($"Наименьшее число: {minValue}");
            Console.ReadKey();
        }
    }
}
