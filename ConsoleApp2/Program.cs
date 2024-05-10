using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            while (true)
            {
                Console.Write("Сколько см у тебя хуй: ");
                int penis = Convert.ToInt32(Console.ReadLine());

                if (penis < 20)
                {
                    Console.WriteLine("Капец у тебя маленький стручочек");
                }
                else
                {
                    Console.WriteLine("Хуя ты конь");
                }
            }
        }
        
    }
}
