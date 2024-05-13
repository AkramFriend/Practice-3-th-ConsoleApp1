using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice__3._2_th__ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool firstNumber = false;

            Console.WriteLine("Напишите число на простоту: ");
            string NoName = Console.ReadLine();
            int num = Convert.ToInt32(NoName);
            int divider = 2;
            
            while (divider <= num - 1)
            {
                int remains = num % divider;
                if (remains == 0)
                {
                    firstNumber = true;
                    break;
                }
                
                divider++;
            }
            if (firstNumber)
            {
                Console.WriteLine("Составное");
            }                
            else
            {
                Console.WriteLine("Простое");
            }
            Console.ReadKey();
        }
    }
}
