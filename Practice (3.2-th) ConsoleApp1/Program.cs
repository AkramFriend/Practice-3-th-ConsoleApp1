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
            for (; ; )
            {
                Console.WriteLine("Напишите число на простоту");
                int num = Convert.ToInt32(Console.ReadLine());
                
                while (true)
                {
                    if ((num % 2 == 1) && (num % num == 0))
                    {
                        Console.WriteLine("Число простое");
                    }
                    else
                    {
                        Console.WriteLine("Это число является составным");
                    }
                    break;
                    Console.ReadKey();
                }             
            }
        }
    }
}
