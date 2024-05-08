using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice__3._4_th__ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int x = r.Next(1, 101);
            int count = 0;
          
            for (; ;)
            {
                Console.WriteLine("Отгадайте загаданное число");
                count++;
                int userNumber = Convert.ToInt32(Console.ReadLine());
                if (userNumber < x)
                {
                    Console.WriteLine("Число меньше загаданного");
                }
                else if (userNumber > x)
                {
                    Console.WriteLine("Число больше загаданного");
                }
                else
                {
                    Console.WriteLine("Вы отгадали число! Ура!");
                    Console.ReadKey();
                    break;
                } 
            }
        }
    }
}
