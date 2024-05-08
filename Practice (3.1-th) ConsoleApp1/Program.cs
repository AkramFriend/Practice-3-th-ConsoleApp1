using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice__3._1_th__ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добрый день! Сколько у Вас карт на руке? ");
            int count = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Напишите номинал карты");
                string value = Console.ReadLine();
                switch (value)
                {
                    case "J":
                    case "Q":
                    case "K":
                    case "T":
                        sum += 10;
                        break;
                    default:
                        int num = int.Parse(value);
                        sum += num;
                        break;
                }             
            }
            Console.WriteLine($"Общая сумма очков: {sum}");
            Console.ReadKey();
        }
    }
}
